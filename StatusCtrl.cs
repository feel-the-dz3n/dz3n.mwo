using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dz3n.MWO
{
    public partial class StatusCtrl : UserControl
    {
        Form1 p;
        public UserControl ReturnPanel;

        public StatusCtrl(Form1 parent, string oktext = "", string text = "", UserControl returnPanel = null)
        {
            p = parent;

            InitializeComponent();
            OkButton.Text = oktext;
            LoadingLabel.Text = text;


            if (returnPanel == null)
                OkButton.Visible = false;
            else
            {
                OkButton.Visible = true;
                ReturnPanel = returnPanel;
            }
        }

        private void OkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // if (ReturnPanel == UpdatePanel) StartUpdate();
            p.SetPanel(ReturnPanel);
            ReturnPanel = null;
        }
    }
}
