using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Dz3n.MWO
{
    public partial class UnloggedCtrl : UserControl
    {
        public Form1 p;

        public UnloggedCtrl(Form1 parent)
        {
            p = parent;
            InitializeComponent();
        }

        private void SingUpButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Process { StartInfo = { FileName = "https://haont.ru/api/register" } }.Start();
        }

        private void LogInButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(p.LogInThread).Start();
        }

        private void UnloggedCtrl_Load(object sender, EventArgs e)
        {
        }
    }
}
