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
using static DotNetTranslator.WinFormsExtension;

namespace Dz3n.MWO
{
    public partial class Form1 : Form
    {
        FastDiagnostic FastDiag;
        public static string Me = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static bool FirstPing = true;
        public static bool ForceCloseForm = false;
        public static string Lang => Program.Translation.SelectedTranslation.Locale.Split('-')[0];
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
            currentPanel.UpdateTranslation(Program.Translation);
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

        public string t(string element) => Program.Translation.Get(element);

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

                    if (!ForceCloseForm) labelPing.Invoke(new Action(() => labelPing.Text = ping));

                    if (ServerIsOkay)
                    {
                        try
                        {
                            int num;
                            string s = this.RequestStringHTTP("https://" + Servers[server] + ".haont.ru/mwo/online.dat?ajax=1");
                            if (int.TryParse(s, out num))
                            {
                                player = t("Players Online").Replace("{0}", s);
                            }
                            else
                            {
                                player = t("Monitoring unavailable");
                            }
                        }
                        catch
                        {
                            player = t("ConnectionProblems");
                        }
                    }
                    else
                    {
                        player = t("ServerOffline");
                    }

                    if (!ForceCloseForm) SetOnline(player);
                }
                Thread.Sleep(2000);
            }
        }

        public Form1()
        {
            InitializeComponent();

            FastDiag = new FastDiagnostic(new FileInfo(Me).Directory.FullName, this);

            Program.Translation.SelectedTranslationChanged += (source) =>
            {
                this.UpdateTranslation(source);
                if (CurrentPanel != null)
                    CurrentPanel.UpdateTranslation(source);
            };
            this.UpdateTranslation(Program.Translation);

            linkProblems.Visible = File.Exists("MWO-Diagnostic.exe");

            Unlogged = new UnloggedCtrl(this);

            Icon = Properties.Resources.icon;
            flowLayoutPanel1.Visible = false;

            SetMessage("");
            labelPing.Text = "";

            ExitButton.BackColor = Color.Transparent;

            // BorderOfPanel.Size = new Size(522, 77);

            LoadSettings();
            SetServer(server);
        }

        public void CheckToken()
        {
            SetMessage(t("Welcome").Replace("{0}", Unlogged.LoginBox.Text));

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
            Properties.Settings.Default.Language = Program.Translation.SelectedLocale;
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
                string UpdateBtn = t("UpdateButton");
                string UpdateAv = t("UpdateText").Replace("{0}", latest);
                // SetMessage(UpdateAv,, UpdateBtn);
                return true;
            }
            return false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(20, 20, 20);

            var border = Color.FromArgb(80, 80, 80);

            WindowBorderBottom.BackColor = border;
            WindowBorderTop.BackColor = border;
            WindowBorderLeft.BackColor = border;
            WindowBorderRight.BackColor = border;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            BackColor = PanelDefault;

            //WindowBorderBottom.BackColor = Color.Transparent;
            //WindowBorderTop.BackColor = Color.Transparent;
            //WindowBorderLeft.BackColor = Color.Transparent;
            //WindowBorderRight.BackColor = Color.Transparent;
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
            linkServer.Text = Servers[serv];
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
                    string m1 = t("ServerOfflineError");
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
                    data["password"] = /*ComputeSHA256(*/Unlogged.PwdBox.Text;//);
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
                Invoke(new Action(() => SetPanel(new LoggedCtrl(this))));
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

        public void SetLang(string l)
        {
            Program.Translation.SelectedTranslation = Program.Translation.GetTranslation(l);
            SaveSettings();
            // Process.Start(Me);
            //new Form1().Show();
            //ForceCloseForm = true;
            //this.Close();
            // Environment.Exit(0);
        }

        private void linkProblems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists("MWO-Diagnostic.exe"))
                Process.Start("MWO-Diagnostic.exe");
        }
    }
}
