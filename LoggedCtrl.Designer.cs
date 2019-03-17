namespace Dz3n.MWO
{
    partial class LoggedCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedCtrl));
            this.LoggedInPanel = new System.Windows.Forms.Panel();
            this.OnlinePlayers = new System.Windows.Forms.LinkLabel();
            this.PlayMWOLink = new System.Windows.Forms.LinkLabel();
            this.LoggedAsLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.LoggedInPanel.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // OnlinePlayers
            // 
            resources.ApplyResources(this.OnlinePlayers, "OnlinePlayers");
            this.OnlinePlayers.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OnlinePlayers.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.OnlinePlayers.LinkColor = System.Drawing.Color.White;
            this.OnlinePlayers.Name = "OnlinePlayers";
            this.OnlinePlayers.TabStop = true;
            this.OnlinePlayers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnlinePlayers_LinkClicked);
            // 
            // PlayMWOLink
            // 
            resources.ApplyResources(this.PlayMWOLink, "PlayMWOLink");
            this.PlayMWOLink.ActiveLinkColor = System.Drawing.Color.White;
            this.PlayMWOLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
            this.PlayMWOLink.Name = "PlayMWOLink";
            this.PlayMWOLink.TabStop = true;
            this.PlayMWOLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PlayMWOLink_LinkClicked);
            // 
            // LoggedAsLabel
            // 
            resources.ApplyResources(this.LoggedAsLabel, "LoggedAsLabel");
            this.LoggedAsLabel.ForeColor = System.Drawing.Color.White;
            this.LoggedAsLabel.Name = "LoggedAsLabel";
            // 
            // LogoutLink
            // 
            resources.ApplyResources(this.LogoutLink, "LogoutLink");
            this.LogoutLink.ActiveLinkColor = System.Drawing.Color.White;
            this.LogoutLink.LinkColor = System.Drawing.Color.Silver;
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.TabStop = true;
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // LoggedCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LoggedInPanel);
            this.Name = "LoggedCtrl";
            this.LoggedInPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel LoggedInPanel;
        public System.Windows.Forms.LinkLabel OnlinePlayers;
        public System.Windows.Forms.LinkLabel PlayMWOLink;
        public System.Windows.Forms.Label LoggedAsLabel;
        public System.Windows.Forms.LinkLabel LogoutLink;
    }
}
