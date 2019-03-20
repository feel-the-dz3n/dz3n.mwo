using DotNetTranslator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class MoreWindow : Form
    {
        public static Form1 f1;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public MoreWindow(Form1 f)
        {
            f1 = f;
            
            InitializeComponent();
            Icon = Properties.Resources.icon;
            ExitButton.BackColor = Color.Transparent;

            this.UpdateTranslation(Program.Translation);

            foreach(var lang in Program.Translation.Translations)
            {
                var link = new LinkLabel();
                link.Tag = lang.Locale;
                link.Text = lang.LocalName;
                link.LinkColor = Color.FromArgb(255, 177, 177, 137);
                link.ActiveLinkColor = Color.White;
                link.Font = new Font("Segoe UI", 11);
                link.Padding = new Padding(0);
                link.Margin = new Padding(0, 0, 3, 0);
                link.AutoSize = true;
                link.LinkClicked += (o, e) =>
                {
                    var l = o as LinkLabel;
                    f1.SetLang((string)l.Tag);
                    this.UpdateTranslation(Program.Translation);
                };

                flowLayoutPanel1.Controls.Add(link);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            FormClose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(40, 40, 40);
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

        private void MoreWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing func
        }

        public void FormClose()
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f1.SetLang("en-US");
            this.UpdateTranslation(Program.Translation);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f1.SetLang("ru-RU");
            this.UpdateTranslation(Program.Translation);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f1.SetLang("uk-UA");
            this.UpdateTranslation(Program.Translation);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f1.SetLang("pl-PL");
            this.UpdateTranslation(Program.Translation);
        }
    }
}
