namespace Dz3n.MWO
{
    partial class StatusCtrl
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
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.LinkLabel();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.LoadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingPanel.Controls.Add(this.OkButton);
            this.LoadingPanel.Controls.Add(this.LoadingLabel);
            this.LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(440, 77);
            this.LoadingPanel.TabIndex = 22;
            // 
            // OkButton
            // 
            this.OkButton.ActiveLinkColor = System.Drawing.Color.White;
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OkButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(125)))));
            this.OkButton.Location = new System.Drawing.Point(0, 57);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(440, 20);
            this.OkButton.TabIndex = 23;
            this.OkButton.TabStop = true;
            this.OkButton.Text = "OK";
            this.OkButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.OkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OkButton_LinkClicked);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LoadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.LoadingLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadingLabel.Location = new System.Drawing.Point(3, 0);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(433, 77);
            this.LoadingLabel.TabIndex = 14;
            this.LoadingLabel.Text = "Connecting to Haont...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LoadingPanel);
            this.Name = "StatusCtrl";
            this.Size = new System.Drawing.Size(440, 77);
            this.LoadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel LoadingPanel;
        public System.Windows.Forms.LinkLabel OkButton;
        public System.Windows.Forms.Label LoadingLabel;
    }
}
