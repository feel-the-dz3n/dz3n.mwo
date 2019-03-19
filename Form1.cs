using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dz3n.MWO
{
    public partial class Form1 : Form
    {
        public static bool FirstPing = true;
        public static bool ForceCloseForm = false;
        public static string Lang = "en";
        public static Color PanelDefault = Color.FromArgb(28, 28, 28);
        public static int LogInTimes = 0;
        public static bool ServerIsOkay = false;
        public static string AccessToken = "";
        public static string[] Servers = { "US", "RU", "EU" };
        public static string ServerHost = "haont.ru";
        public static int server = 1;
        public static Point panelLocation = new Point(41, 0/*142*/);
        public static Size panelSize = new Size(440, 77);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public UnloggedCtrl Unlogged;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region DWM
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect, // x-coordinate of upper-left corner
       int nTopRect, // y-coordinate of upper-left corner
       int nRightRect, // x-coordinate of lower-right corner
       int nBottomRect, // y-coordinate of lower-right corner
       int nWidthEllipse, // height of ellipse
       int nHeightEllipse // width of ellipse
    );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();

        //        CreateParams cp = base.CreateParams;
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW;

        //        return cp;
        //    }
        //}
        public class ShadowedForm : Form
        {
            protected override CreateParams CreateParams
            {
                get
                {
                    const int CS_DROPSHADOW = 0x20000;
                    CreateParams cp = base.CreateParams;
                    cp.ClassStyle |= CS_DROPSHADOW;
                    return cp;
                }
            }

            // ... other code ...
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }
        #endregion

        private UserControl currentPanel = null;
        public UserControl CurrentPanel
        {
            get => currentPanel;
            set => SetPanel(value);
        }

        public void SetPanel(UserControl panel)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() => SetPanel(panel)));
                return;
            }

            if (BorderOfPanel.Controls.Contains(panel))
                BorderOfPanel.Controls.Remove(panel);

            if (CurrentPanel is UnloggedCtrl)
                CurrentPanel.Visible = false;
            else if (CurrentPanel != null)
                CurrentPanel.Dispose();

            if (panel == null)
                return;

            BorderOfPanel.Controls.Add(panel);

            currentPanel = panel;
            currentPanel.Visible = true;
            currentPanel.Location = panelLocation;
            // currentPanel.Size = panelSize;
            
            if (panel is LoggedCtrl)
            {
                flowLayoutPanel1.Visible = true;

                var ctrl = panel as LoggedCtrl;

                if (Lang == "ru") ctrl.LoggedAsLabel.Text = "Хэй, " + Unlogged.LoginBox.Text;
                else if (Lang == "uk") ctrl.LoggedAsLabel.Text = "Гей, " + Unlogged.LoginBox.Text;
                else if (Lang == "pl") ctrl.LoggedAsLabel.Text = "Witaj, " + Unlogged.LoginBox.Text;
                else ctrl.LoggedAsLabel.Text = "Hey, " + Unlogged.LoginBox.Text;

                BorderOfPanel.BackColor = PanelDefault;
            }
            else
                BorderOfPanel.BackColor = Color.Transparent;

            if (panel is StatusCtrl) { }
            else if (WindowState != FormWindowState.Minimized)
                Activate();
        }

        public void SetMessage(string text, UserControl okPanel = null, string okText = "OK")
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetMessage(text, okPanel, okText)));
                return;
            }

            var status = new StatusCtrl(this, okText, text, okPanel);
            SetPanel(status);
        }

        public void SetOnline(string Text)
        {
            this.Invoke(new Action(() => 
            {
                if (CurrentPanel is LoggedCtrl)
                {
                    ((LoggedCtrl)CurrentPanel).OnlinePlayers.Text = Text;
                }
            }));
        }

        public string ComputeSHA256(string input)
        {
            byte[] buffer2 = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer2.Length; i++)
            {
                builder.Append(buffer2[i].ToString("x2"));
            }
            return builder.ToString();
        }

        public string RequestStringHTTP(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
        
        public void PingTool()
        {
            //Thread.Sleep(1000);
            string ping = "";
            string player = "";
            while (true)
            {
                if (ForceCloseForm) break;
                if (flowLayoutPanel1.Visible || FirstPing)
                {
                    FirstPing = false;
                    try
                    {
                        Ping pinger = new Ping();
                        PingReply reply = pinger.Send(Servers[server] + "." + ServerHost);

                        if (Lang == "uk") ping = "(пінг: " + reply.RoundtripTime + "мс)";
                        else if (Lang == "ru") ping = "(пинг: " + reply.RoundtripTime + "мс)";
                        else ping = "(ping: " + reply.RoundtripTime + "ms)";

                        if (reply.RoundtripTime <= 0)
                        {
                            throw new Exception("Ping = 0");
                        }
                        ServerIsOkay = true;
                    }
                    catch
                    {
                        ping = "";
                        ServerIsOkay = false;
                    }

                    if (!ForceCloseForm) PingLabel.Invoke(new Action(() => PingLabel.Text = ping));

                    if (ServerIsOkay)
                    {
                        try
                        {
                            int num;
                            string s = this.RequestStringHTTP("https://" + Servers[server] + ".haont.ru/mwo/online.dat?ajax=1");
                            if (int.TryParse(s, out num))
                            {
                                player = s + " players online";
                                if (Lang == "ru") player = s + " игроков онлайн";
                                if (Lang == "uk") player = s + " гравців онлайн";
                                if (Lang == "pl") player = s + " gracz(y/ów) online";
                            }
                            else
                            {
                                player = "Monitoring unavailable";
                                if (Lang == "ru") player = "Мониторинг не доступен";
                                if (Lang == "uk") player = "Моніторинг не доступний";
                                if (Lang == "pl") player = "Monitoring nie dostępny";
                            }
                        }
                        catch
                        {
                            player = "Problems with connection";
                            if (Lang == "ru") player = "Проблемы с соединением";
                            if (Lang == "uk") player = "Проблеми зі з'єднанням";
                            if (Lang == "pl") player = "Problemy z połączeniem";
                        }
                    }
                    else
                    {
                        player = "Server is offline";
                        if (Lang == "ru") player = "Сервер выключен";
                        if (Lang == "uk") player = "Сервер вимкнено";
                        if (Lang == "pl") player = "Serwer jest nie dostępny";
                    }

                    if (!ForceCloseForm) SetOnline(player);
                }
                Thread.Sleep(2000);
            }
        }
        public Form1()
        {
            Lang = Properties.Settings.Default.Language;

            if (Lang == "") 
            {
                if (CultureInfo.InstalledUICulture.ToString().StartsWith("en")) Lang = "en";
                else if (CultureInfo.InstalledUICulture.ToString().StartsWith("ru")) Lang = "ru";
                else if (CultureInfo.InstalledUICulture.ToString().StartsWith("uk")) Lang = "uk";
                else if (CultureInfo.InstalledUICulture.ToString().StartsWith("pl")) Lang = "pl";
                else Lang = "en";
            }

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Lang);
            m_aeroEnabled = false;

         
            InitializeComponent();

            Unlogged = new UnloggedCtrl(this);

            Icon = Properties.Resources.icon;
            flowLayoutPanel1.Visible = false;

            SetMessage("");
            PingLabel.Text = "";

            ExitButton.BackColor = Color.Transparent;

            BorderOfPanel.Size = new Size(522, 77);

            LoadSettings();
            SetServer(server);
        }

        public void CheckToken()
        {
            string wback = "Welcome back to MWO, " + Unlogged.LoginBox.Text + "!";
            if (Lang == "ru") wback = "С возвращением в MWO, " + Unlogged.LoginBox.Text + "!";
            if (Lang == "uk") wback = "З поверненням в MWO, " + Unlogged.LoginBox.Text + "!";
            if (Lang == "pl") wback = "Witaj z powrotem w MWO, " + Unlogged.LoginBox.Text + "!";
            SetMessage(wback);

            try
            {
                using (WebClient client = new WebClient())
                {
                    new NameValueCollection()["token"] = AccessToken;
                    if (client.DownloadString("https://haont.ru/api/tokverify?ajax=1&target=mwo&token=" + AccessToken) == "true\n")
                    {
                        Invoke(new Action(() => { SetPanel(new LoggedCtrl(this)); }));
                    }
                    else
                    {
                        AccessToken = "";
                        SaveSettings();
                        SetPanel(Unlogged);
                    }
                }
            }
            catch (Exception exception)
            {
                AccessToken = "";
                SetMessage("Token verification failed with an exception: " + exception.ToString(), Unlogged);
                //MessageBox.Show("Token verification failed with an exception: " + exception.ToString(), "Dz3n.MWO Error");
                //SetPanel(UnloggedPanel);
            }
            this.BeginInvoke(new Action(delegate {
                WindowState = FormWindowState.Normal; Activate();  }));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public bool CheckMWO()
        {
#if DEBUG
            return true;
#endif
            string path = @"scripts\MostWantedOnline.asi";
            if (!File.Exists("speed.exe"))
            {
                string YouDoNotHaveMW = "You do not have Need for Speed Most Wanted installed!";
                if (Lang == "uk") YouDoNotHaveMW = "Гра Need for Speed Most Wanted не встановлена!";
                if (Lang == "ru") YouDoNotHaveMW = "Игра Need for Speed Most Wanted не установлена!";
                if (Lang == "pl") YouDoNotHaveMW = "Nie masz zainstalowanego Need for Speed Most Wanted!";
                SetMessage(YouDoNotHaveMW);
                //MessageBox.Show("You do not have Need for Speed Most Wanted installed!", "Dz3n.MWO");
                return false;
            }
            else if (!File.Exists(path))
            {
                string YouDoNotHaveMW = "You do not have Most Wanted Online installed!";
                if (Lang == "uk") YouDoNotHaveMW = "Most Wanted Online не установлен!";
                if (Lang == "ru") YouDoNotHaveMW = "Most Wanted Online не встановлений!";
                if (Lang == "pl") YouDoNotHaveMW = "Nie masz zainstalowanego Most Wanted Online!";
                SetMessage(YouDoNotHaveMW);
                return false;
            }
            return true;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Language = Lang;
            Properties.Settings.Default.Username = Unlogged.LoginBox.Text;
            Properties.Settings.Default.AccessToken = AccessToken;
            Properties.Settings.Default.ServerId = server;
            Properties.Settings.Default.Save();
        }

        public void LoadSettings()
        {
            Unlogged.LoginBox.Text = Properties.Settings.Default.Username;
            AccessToken = Properties.Settings.Default.AccessToken;
            server = Properties.Settings.Default.ServerId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormExit();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Transparent;
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Firebrick;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ExitButton.BackColor = Color.DarkRed;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.Firebrick;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckMWO())
            {
                new Thread(LauncherStart).Start();
                
            }
        }

        private void LauncherStart()
        {
            new Thread(PingTool).Start();

            if (AccessToken.Length >= 1)
            {
                if (CheckUpdates()) return;
                // MWO 1.0.0.0 is available. You can't play MWO until update.
                //WindowState = FormWindowState.Minimized;
                new Thread(CheckToken).Start();
            }
            else SetPanel(Unlogged);
        }

        public bool CheckUpdates(bool ct = true)
        {
            return false;

            var versInfo = FileVersionInfo.GetVersionInfo("scripts\\MostWantedOnline.asi");
            string fileVersion = versInfo.ProductVersion;
            if(ct)SetMessage("MWO Version: " + fileVersion);
            string latest = new WebClient().DownloadString("https://raw.githubusercontent.com/MWOTeam/MWOUpdateInfo/master/mwo-latest.txt");

            //SetMessage("scripts\\MostWantedOnline.asi: " + fileVersion);
            //return true;
            if (latest != fileVersion)
            {
                string UpdateBtn = "Update";
                string UpdateAv = String.Format("MWO {0} is available. You can't play until you update MWO.", latest);
                if (Lang == "ru")
                {
                    UpdateAv = String.Format("Доступен MWO {0}. Вы не можете играть, пока не обновите MWO.", latest);
                    UpdateBtn = "Обновить";
                }
                if (Lang == "uk")
                {
                    UpdateAv = String.Format("Доступний MWO {0}. Ви не можете грати, поки не оновите MWO.", latest);
                    UpdateBtn = "Оновити";
                }
                if (Lang == "pl")
                {
                    UpdateAv = String.Format("MWO {0} jest dostępne. Nie możesz grać w mwo, dopuki nie zainstalujesz aktualizacji.", latest);
                    UpdateBtn = "Aktualizacja";
                }
                // SetMessage(UpdateAv,, UpdateBtn);
                return true;
            }
            return false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(20, 20, 20);
            WindowBorder.BackColor = Color.Transparent;// Color.FromArgb(80, 80, 80);
            WindowBorder2.BackColor = Color.Transparent;// Color.FromArgb(80, 80, 80);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            BackColor = PanelDefault;
            WindowBorder.BackColor = Color.Transparent;
            WindowBorder2.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void UnloggedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeSrv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (server == 0) SetServer(1);
            else if (server == 1) SetServer(2);
            else if (server == 2) SetServer(0);
            SaveSettings();
        }

        public void SetServer(int serv)
        {
            server = serv;
            ChangeSrv.Text = Servers[serv];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MoreWindow(this).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!ForceCloseForm) FormExit();
        }

        public void FormExit()
        {
            SaveSettings();
            Environment.Exit(0);
        }

        public void PlayMWOLink_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ServerIsOkay)
                {
                    string m1 = "The server is down! Please choose another one.";
                    if (Lang == "ru") m1 = "Сервер выключен! Пожалуйста, выберите другой.";
                    if (Lang == "uk") m1 = "Сервер вимкнено! Будь-ласка, виберіть інший.";
                    if (Lang == "pl") m1 = "Serwer upadł! Proszę wybrać inny.";
                    // 
                    SetMessage(m1, new LoggedCtrl(this));
                    //MessageBox.Show("The server is down!\nPlease choose another one.", "Dz3n.MWO Error");
                    return;
                }
                
                Process process1 = new Process
                {
                    StartInfo = { FileName = @".\speed.exe" }
                };
                string str = string.Format("-mwo {0} {1} {2}", Servers[server] + ".nfsmwo.xyz", Unlogged.LoginBox.Text, AccessToken);
                process1.StartInfo.Arguments = str;
                process1.Start();

                string m = "Enjoy cats and drink weed";

                if (Lang == "ru") m = "Наслаждайтесь котами и пейте траву";
                else if (Lang == "uk") m = "Насолоджуйтесь плаками та споживайте травичечку";
                else if (Lang == "pl") m = "Kochaj koty i pal zioło";

                SetMessage(m);

                flowLayoutPanel1.Visible = false;

                new Thread(() => 
                {
                    Thread.Sleep(8000);
                    Invoke(new Action(() => FormExit()));
                }).Start();
            }
            catch (Exception ex)
            {
                string m = "Failed to run MWO!\n" + ex.Message;

                if (Lang == "ru") m = "Невозможно запустить MWO!\n" + ex.Message;
                else if (Lang == "uk") m = "Неможливо запустити MWO!\n" + ex.Message;
                else if (Lang == "pl") m = "Nie można uruchomić MWO!\n" + ex.Message;

                SetMessage(m, new LoggedCtrl(this));
            }

        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        public static string StrFromArray(string[] arr)
        {
            StringBuilder d = new StringBuilder();
            for (int i = 1; i < arr.Length; i++)
                d.Append(arr[i] + " ");
            return d.ToString();
        }

        public void LogInThread()
        {

            string m = Unlogged.LoginBox.Text + " is hacking the Pentagon now...";
            if (Lang == "ru") m = Unlogged.LoginBox.Text + " сейчас взламывает Пентагон...";
            if (Lang == "uk") m = Unlogged.LoginBox.Text + " наразі зламує Пентагон...";
            if (Lang == "pl") m = Unlogged.LoginBox.Text + " właśnie hakuje Pentagon...";
            SetMessage(m);

            if (CheckUpdates(false)) return;
            try
            {
                using (WebClient client = new WebClient())
                {
                    NameValueCollection data = new NameValueCollection();
                    data["login"] = Unlogged.LoginBox.Text;
                    data["password"] = Unlogged.PwdBox.Text;
                    byte[] bytes = client.UploadValues("https://haont.ru/api/auth?ajax=1&target=mwo", "POST", data);
                    char[] separator = new char[] { ' ' };
                    string[] strArray = Encoding.UTF8.GetString(bytes).Split(separator);
                    if (Convert.ToInt32(strArray[0]) == 0)
                    {
                        SetMessage("Sign-in failed: " + StrFromArray(strArray), Unlogged);
                        //MessageBox.Show(, "Dz3n.MWO Error");
                        AccessToken = "";
                        //SetPanel(UnloggedPanel);
                        return;
                    }
                    AccessToken = strArray[1].Remove(strArray[1].Length - 1);
                }
            }
            catch (Exception exception)
            {
                SetMessage("Sign-in failed with an exception: " + exception.ToString(), Unlogged);
                //MessageBox.Show("Sign-in failed with an exception: " + exception.ToString(), "Dz3n.MWO Error");
                //SetPanel(UnloggedPanel);
            }
            if (AccessToken.Length < 64)
            {
                if (LogInTimes < 4)
                {
                    if (AccessToken.Length >= 1)
                    {
                        SetMessage("Sign-in failed:\n" + AccessToken);
                        //MessageBox.Show("Sign-in failed: " + AccessToken, "Dz3n.MWO Error");
                    }
                    else
                    {
                        SetMessage("Attempts made: " + LogInTimes + "/3");
                    }

                    AccessToken = "";
                    LogInTimes++;
                    LogInThread();
                }
                else
                {
                    SetMessage("Unknown error", Unlogged);
                }
            }
            else
            {
                
                SetPanel(new LoggedCtrl(this));
                SaveSettings();
            }
            LogInTimes = 0;
        }

        public void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessToken = "";
            SetPanel(Unlogged);
            flowLayoutPanel1.Visible = false;
            new Thread(Unlog).Start();
            SaveSettings();
        }

        public void Unlog()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string str = client.DownloadString("https://haont.ru/api/logout?target=mwo&ajax=1&token=" + AccessToken);
                    if (str.Length == 0)
                    {
                        
                    }
                    else
                    {
                       // MessageBox.Show("Logging out failed: " + str, "Dz3n.MWO Error");
                    }
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Logging out failed with an exception: " + exception.ToString(), "Dz3n.MWO Error");
            }

        }

        private void SingUpButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/hkJhjrT");
            Process.Start("https://discord.gg/383Q6q5");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }

        private void OnlinePlayers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void OkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        public void StartUpdate()
        {
            string url = "https://raw.githubusercontent.com/MWOTeam/MWOUpdateInfo/master/MWO_Setup.exe";
            WebClient w = new WebClient();
            w.DownloadFileCompleted += UpdateCompleted;
            w.DownloadProgressChanged += UpdateProgress;
            w.DownloadFileAsync(new Uri(url), "MWO_Setup.exe");
        }

        private void UpdateProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            // UpdProgress.Value = e.ProgressPercentage;
        }

        private void UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                SetMessage("Error: " + e.Error.Message);
                return;
            }
            Process.Start(".\\MWO_Setup.exe", "-s");
            Environment.Exit(0);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Lang = "en";
            SaveSettings();
            Process.Start("Dz3n.MWO.exe");
            Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Lang = "ru";
            SaveSettings();
            Process.Start("Dz3n.MWO.exe");
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lang = "uk";
            SaveSettings();
            Process.Start("Dz3n.MWO.exe");
            Environment.Exit(0);
        }

        public void SetLang(string l)
        {
            Lang = l;
            SaveSettings();
            Process.Start("Dz3n.MWO.exe");
            //new Form1().Show();
            //ForceCloseForm = true;
            //this.Close();
            Environment.Exit(0);
        }
    }
}
