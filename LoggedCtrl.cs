using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dz3n.MWO
{
    public partial class LoggedCtrl : UserControl
    {
        public Form1 p;

        public LoggedCtrl(Form1 parent)
        {
            p = parent;

            InitializeComponent();

            OnlinePlayers.Text = "";

            //if (Form1.Lang == "ru")
            //{
            //    Play
            //}
            //else if (Form1.Lang == "uk") ctrl.LoggedAsLabel.Text = "Гей, " + Unlogged.LoginBox.Text;
            //else if (Form1.Lang == "pl") ctrl.LoggedAsLabel.Text = "Witaj, " + Unlogged.LoginBox.Text;
            //else ctrl.LoggedAsLabel.Text = "Hey, " + Unlogged.LoginBox.Text;
        }

        private void OnlinePlayers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(String.Format("https://{0}.haont.ru/mwo/mon", Form1.Servers[Form1.server]));
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p.LogoutLink_LinkClicked(sender, e);
        }

        private void PlayMWOLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p.PlayMWOLink_Click(sender, e);
        }
    }
}
