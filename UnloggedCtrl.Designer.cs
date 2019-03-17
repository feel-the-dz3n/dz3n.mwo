namespace Dz3n.MWO
{
    partial class UnloggedCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnloggedCtrl));
            this.UnloggedPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SingUpButton = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.UnloggedPanel.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // SingUpButton
            // 
            resources.ApplyResources(this.SingUpButton, "SingUpButton");
            this.SingUpButton.ActiveLinkColor = System.Drawing.Color.White;
            this.SingUpButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.TabStop = true;
            this.SingUpButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SingUpButton_LinkClicked);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // PwdBox
            // 
            resources.ApplyResources(this.PwdBox, "PwdBox");
            this.PwdBox.Name = "PwdBox";
            // 
            // LoginBox
            // 
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.Name = "LoginBox";
            // 
            // LogInButton
            // 
            resources.ApplyResources(this.LogInButton, "LogInButton");
            this.LogInButton.ActiveLinkColor = System.Drawing.Color.White;
            this.LogInButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.TabStop = true;
            this.LogInButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogInButton_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // UnloggedCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.UnloggedPanel);
            this.Name = "UnloggedCtrl";
            this.Load += new System.EventHandler(this.UnloggedCtrl_Load);
            this.UnloggedPanel.ResumeLayout(false);
            this.UnloggedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UnloggedPanel;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.LinkLabel SingUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox PwdBox;
        public System.Windows.Forms.TextBox LoginBox;
        public System.Windows.Forms.LinkLabel LogInButton;
        private System.Windows.Forms.Label label4;
    }
}
