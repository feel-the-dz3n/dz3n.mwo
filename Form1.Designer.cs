namespace Dz3n.MWO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitButton = new System.Windows.Forms.Label();
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.WindowBorder2 = new System.Windows.Forms.Panel();
            this.ChangeSrv = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PingLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BorderOfPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelAeroBackground = new System.Windows.Forms.Panel();
            this.linkProblems = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Name = "ExitButton";
            this.toolTip.SetToolTip(this.ExitButton, resources.GetString("ExitButton.ToolTip"));
            this.ExitButton.UseCompatibleTextRendering = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.ExitButton.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.ExitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // WindowBorder
            // 
            resources.ApplyResources(this.WindowBorder, "WindowBorder");
            this.WindowBorder.BackColor = System.Drawing.Color.Gray;
            this.WindowBorder.ForeColor = System.Drawing.Color.White;
            this.WindowBorder.Name = "WindowBorder";
            this.toolTip.SetToolTip(this.WindowBorder, resources.GetString("WindowBorder.ToolTip"));
            // 
            // WindowBorder2
            // 
            resources.ApplyResources(this.WindowBorder2, "WindowBorder2");
            this.WindowBorder2.BackColor = System.Drawing.Color.Gray;
            this.WindowBorder2.ForeColor = System.Drawing.Color.White;
            this.WindowBorder2.Name = "WindowBorder2";
            this.toolTip.SetToolTip(this.WindowBorder2, resources.GetString("WindowBorder2.ToolTip"));
            // 
            // ChangeSrv
            // 
            resources.ApplyResources(this.ChangeSrv, "ChangeSrv");
            this.ChangeSrv.ActiveLinkColor = System.Drawing.Color.White;
            this.ChangeSrv.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeSrv.Name = "ChangeSrv";
            this.ChangeSrv.TabStop = true;
            this.toolTip.SetToolTip(this.ChangeSrv, resources.GetString("ChangeSrv.ToolTip"));
            this.ChangeSrv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeSrv_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.ChangeSrv);
            this.flowLayoutPanel1.Controls.Add(this.PingLabel);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // PingLabel
            // 
            resources.ApplyResources(this.PingLabel, "PingLabel");
            this.PingLabel.ForeColor = System.Drawing.Color.White;
            this.PingLabel.Name = "PingLabel";
            this.toolTip.SetToolTip(this.PingLabel, resources.GetString("PingLabel.ToolTip"));
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.toolTip.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.toolTip.SetToolTip(this.linkLabel2, resources.GetString("linkLabel2.ToolTip"));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Dz3n.MWO.Properties.Resources.mwo_logo;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // BorderOfPanel
            // 
            resources.ApplyResources(this.BorderOfPanel, "BorderOfPanel");
            this.BorderOfPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BorderOfPanel.Name = "BorderOfPanel";
            this.toolTip.SetToolTip(this.BorderOfPanel, resources.GetString("BorderOfPanel.ToolTip"));
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 0;
            this.toolTip.InitialDelay = 1;
            this.toolTip.ReshowDelay = 100;
            // 
            // PanelAeroBackground
            // 
            resources.ApplyResources(this.PanelAeroBackground, "PanelAeroBackground");
            this.PanelAeroBackground.BackColor = System.Drawing.Color.Black;
            this.PanelAeroBackground.Name = "PanelAeroBackground";
            this.toolTip.SetToolTip(this.PanelAeroBackground, resources.GetString("PanelAeroBackground.ToolTip"));
            // 
            // linkProblems
            // 
            resources.ApplyResources(this.linkProblems, "linkProblems");
            this.linkProblems.ActiveLinkColor = System.Drawing.Color.White;
            this.linkProblems.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkProblems.Name = "linkProblems";
            this.linkProblems.TabStop = true;
            this.toolTip.SetToolTip(this.linkProblems, resources.GetString("linkProblems.ToolTip"));
            this.linkProblems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProblems_LinkClicked);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.linkProblems);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.WindowBorder2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BorderOfPanel);
            this.Controls.Add(this.PanelAeroBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.Panel WindowBorder2;
        private System.Windows.Forms.LinkLabel ChangeSrv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PingLabel;
        private System.Windows.Forms.Panel BorderOfPanel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel PanelAeroBackground;
        private System.Windows.Forms.LinkLabel linkProblems;
    }
}

