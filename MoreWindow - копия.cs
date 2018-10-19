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
        public Form1 f1;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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
        
        public MoreWindow(Form1 f)
        {

            f1 = f;

            m_aeroEnabled = false;
            InitializeComponent();
            ExitButton.BackColor = Color.Transparent;


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
            WindowBorder.BackColor = Color.White;
            WindowBorder2.BackColor = Color.White;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(40, 40, 40);
            WindowBorder.BackColor = Color.Gray;
            WindowBorder2.BackColor = Color.Gray;
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
            FormClose();
        }

        public void FormClose()
        {
            this.Close();
        }
    }
}
