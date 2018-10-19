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
            this.LoggedAsLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.LoggedInPanel = new System.Windows.Forms.Panel();
            this.OnlinePlayers = new System.Windows.Forms.LinkLabel();
            this.PlayMWOLink = new System.Windows.Forms.LinkLabel();
            this.WindowBorder2 = new System.Windows.Forms.Panel();
            this.ChangeSrv = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PingLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.UnloggedPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SingUpButton = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.LinkLabel();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BorderOfPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelAeroBackground = new System.Windows.Forms.Panel();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.UpdProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LoggedInPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.UnloggedPanel.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.UpdatePanel.SuspendLayout();
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
            // LoggedAsLabel
            // 
            resources.ApplyResources(this.LoggedAsLabel, "LoggedAsLabel");
            this.LoggedAsLabel.ForeColor = System.Drawing.Color.White;
            this.LoggedAsLabel.Name = "LoggedAsLabel";
            this.toolTip.SetToolTip(this.LoggedAsLabel, resources.GetString("LoggedAsLabel.ToolTip"));
            // 
            // LogoutLink
            // 
            resources.ApplyResources(this.LogoutLink, "LogoutLink");
            this.LogoutLink.ActiveLinkColor = System.Drawing.Color.White;
            this.LogoutLink.LinkColor = System.Drawing.Color.Silver;
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.TabStop = true;
            this.toolTip.SetToolTip(this.LogoutLink, resources.GetString("LogoutLink.ToolTip"));
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // LoggedInPanel
            // 
            resources.ApplyResources(this.LoggedInPanel, "LoggedInPanel");
            this.LoggedInPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LoggedInPanel.Controls.Add(this.OnlinePlayers);
            this.LoggedInPanel.Controls.Add(this.PlayMWOLink);
            this.LoggedInPanel.Controls.Add(this.LoggedAsLabel);
            this.LoggedInPanel.Controls.Add(this.LogoutLink);
            this.LoggedInPanel.Name = "LoggedInPanel";
            this.toolTip.SetToolTip(this.LoggedInPanel, resources.GetString("LoggedInPanel.ToolTip"));
            // 
            // OnlinePlayers
            // 
            resources.ApplyResources(this.OnlinePlayers, "OnlinePlayers");
            this.OnlinePlayers.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OnlinePlayers.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.OnlinePlayers.LinkColor = System.Drawing.Color.White;
            this.OnlinePlayers.Name = "OnlinePlayers";
            this.OnlinePlayers.TabStop = true;
            this.toolTip.SetToolTip(this.OnlinePlayers, resources.GetString("OnlinePlayers.ToolTip"));
            this.OnlinePlayers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnlinePlayers_LinkClicked);
            // 
            // PlayMWOLink
            // 
            resources.ApplyResources(this.PlayMWOLink, "PlayMWOLink");
            this.PlayMWOLink.ActiveLinkColor = System.Drawing.Color.White;
            this.PlayMWOLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.PlayMWOLink.Name = "PlayMWOLink";
            this.PlayMWOLink.TabStop = true;
            this.toolTip.SetToolTip(this.PlayMWOLink, resources.GetString("PlayMWOLink.ToolTip"));
            this.PlayMWOLink.Click += new System.EventHandler(this.PlayMWOLink_Click);
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
            // UnloggedPanel
            // 
            resources.ApplyResources(this.UnloggedPanel, "UnloggedPanel");
            this.UnloggedPanel.BackColor = System.Drawing.Color.Transparent;
            this.UnloggedPanel.Controls.Add(this.label7);
            this.UnloggedPanel.Controls.Add(this.SingUpButton);
            this.UnloggedPanel.Controls.Add(this.panel1);
            this.UnloggedPanel.Controls.Add(this.label5);
            this.UnloggedPanel.Controls.Add(this.PwdBox);
            this.UnloggedPanel.Controls.Add(this.LoginBox);
            this.UnloggedPanel.Controls.Add(this.LogInButton);
            this.UnloggedPanel.Controls.Add(this.label4);
            this.UnloggedPanel.Name = "UnloggedPanel";
            this.toolTip.SetToolTip(this.UnloggedPanel, resources.GetString("UnloggedPanel.ToolTip"));
            this.UnloggedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UnloggedPanel_Paint);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            this.toolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // SingUpButton
            // 
            resources.ApplyResources(this.SingUpButton, "SingUpButton");
            this.SingUpButton.ActiveLinkColor = System.Drawing.Color.White;
            this.SingUpButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.TabStop = true;
            this.toolTip.SetToolTip(this.SingUpButton, resources.GetString("SingUpButton.ToolTip"));
            this.SingUpButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SingUpButton_LinkClicked);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Name = "panel1";
            this.toolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            this.toolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // PwdBox
            // 
            resources.ApplyResources(this.PwdBox, "PwdBox");
            this.PwdBox.Name = "PwdBox";
            this.toolTip.SetToolTip(this.PwdBox, resources.GetString("PwdBox.ToolTip"));
            // 
            // LoginBox
            // 
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.Name = "LoginBox";
            this.toolTip.SetToolTip(this.LoginBox, resources.GetString("LoginBox.ToolTip"));
            // 
            // LogInButton
            // 
            resources.ApplyResources(this.LogInButton, "LogInButton");
            this.LogInButton.ActiveLinkColor = System.Drawing.Color.White;
            this.LogInButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.TabStop = true;
            this.toolTip.SetToolTip(this.LogInButton, resources.GetString("LogInButton.ToolTip"));
            this.LogInButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogInButton_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // LoadingPanel
            // 
            resources.ApplyResources(this.LoadingPanel, "LoadingPanel");
            this.LoadingPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingPanel.Controls.Add(this.OkButton);
            this.LoadingPanel.Controls.Add(this.LoadingLabel);
            this.LoadingPanel.Name = "LoadingPanel";
            this.toolTip.SetToolTip(this.LoadingPanel, resources.GetString("LoadingPanel.ToolTip"));
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.ActiveLinkColor = System.Drawing.Color.White;
            this.OkButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.OkButton.Name = "OkButton";
            this.OkButton.TabStop = true;
            this.toolTip.SetToolTip(this.OkButton, resources.GetString("OkButton.ToolTip"));
            this.OkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OkButton_LinkClicked);
            // 
            // LoadingLabel
            // 
            resources.ApplyResources(this.LoadingLabel, "LoadingLabel");
            this.LoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LoadingLabel.Name = "LoadingLabel";
            this.toolTip.SetToolTip(this.LoadingLabel, resources.GetString("LoadingLabel.ToolTip"));
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
            // UpdatePanel
            // 
            resources.ApplyResources(this.UpdatePanel, "UpdatePanel");
            this.UpdatePanel.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePanel.Controls.Add(this.UpdProgress);
            this.UpdatePanel.Controls.Add(this.label1);
            this.UpdatePanel.Name = "UpdatePanel";
            this.toolTip.SetToolTip(this.UpdatePanel, resources.GetString("UpdatePanel.ToolTip"));
            // 
            // UpdProgress
            // 
            resources.ApplyResources(this.UpdProgress, "UpdProgress");
            this.UpdProgress.Name = "UpdProgress";
            this.toolTip.SetToolTip(this.UpdProgress, resources.GetString("UpdProgress.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.UnloggedPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.WindowBorder2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.LoggedInPanel);
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
            this.LoggedInPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.UnloggedPanel.ResumeLayout(false);
            this.UnloggedPanel.PerformLayout();
            this.LoadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.UpdatePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.Label LoggedAsLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Panel LoggedInPanel;
        private System.Windows.Forms.LinkLabel PlayMWOLink;
        private System.Windows.Forms.Panel WindowBorder2;
        private System.Windows.Forms.LinkLabel ChangeSrv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PingLabel;
        private System.Windows.Forms.Panel UnloggedPanel;
        private System.Windows.Forms.TextBox PwdBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.LinkLabel LogInButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel SingUpButton;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Panel BorderOfPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel OnlinePlayers;
        private System.Windows.Forms.LinkLabel OkButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel PanelAeroBackground;
        private System.Windows.Forms.Panel UpdatePanel;
        private System.Windows.Forms.ProgressBar UpdProgress;
        private System.Windows.Forms.Label label1;
    }
}

