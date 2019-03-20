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
            this.ExitButton = new System.Windows.Forms.Label();
            this.linkServer = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelPing = new System.Windows.Forms.Label();
            this.linkMore = new System.Windows.Forms.LinkLabel();
            this.linkDiscord = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BorderOfPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.linkProblems = new System.Windows.Forms.LinkLabel();
            this.WindowBorderLeft = new System.Windows.Forms.Panel();
            this.WindowBorderRight = new System.Windows.Forms.Panel();
            this.WindowBorderTop = new System.Windows.Forms.Panel();
            this.WindowBorderBottom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(479, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 25);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "✕";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.UseCompatibleTextRendering = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.ExitButton.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.ExitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // linkServer
            // 
            this.linkServer.ActiveLinkColor = System.Drawing.Color.White;
            this.linkServer.AutoSize = true;
            this.linkServer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.linkServer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.linkServer.Location = new System.Drawing.Point(58, 0);
            this.linkServer.Margin = new System.Windows.Forms.Padding(0);
            this.linkServer.Name = "linkServer";
            this.linkServer.Size = new System.Drawing.Size(27, 20);
            this.linkServer.TabIndex = 11;
            this.linkServer.TabStop = true;
            this.linkServer.Text = "EU";
            this.toolTip.SetToolTip(this.linkServer, "Click to change the server");
            this.linkServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeSrv_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.labelServer);
            this.flowLayoutPanel1.Controls.Add(this.linkServer);
            this.flowLayoutPanel1.Controls.Add(this.labelPing);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 20);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.labelServer.Location = new System.Drawing.Point(0, 0);
            this.labelServer.Margin = new System.Windows.Forms.Padding(0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelServer.Size = new System.Drawing.Size(58, 20);
            this.labelServer.TabIndex = 13;
            this.labelServer.Text = "Server:";
            this.labelServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPing
            // 
            this.labelPing.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.labelPing.Location = new System.Drawing.Point(85, 0);
            this.labelPing.Margin = new System.Windows.Forms.Padding(0);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(121, 20);
            this.labelPing.TabIndex = 12;
            this.labelPing.Text = "(ping: 0ms)";
            this.labelPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkMore
            // 
            this.linkMore.ActiveLinkColor = System.Drawing.Color.White;
            this.linkMore.AutoSize = true;
            this.linkMore.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.linkMore.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.linkMore.Location = new System.Drawing.Point(206, 0);
            this.linkMore.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkMore.Name = "linkMore";
            this.linkMore.Size = new System.Drawing.Size(44, 20);
            this.linkMore.TabIndex = 12;
            this.linkMore.TabStop = true;
            this.linkMore.Text = "More";
            this.linkMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkDiscord
            // 
            this.linkDiscord.ActiveLinkColor = System.Drawing.Color.White;
            this.linkDiscord.AutoSize = true;
            this.linkDiscord.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.linkDiscord.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.linkDiscord.Location = new System.Drawing.Point(140, 0);
            this.linkDiscord.Name = "linkDiscord";
            this.linkDiscord.Size = new System.Drawing.Size(60, 20);
            this.linkDiscord.TabIndex = 13;
            this.linkDiscord.TabStop = true;
            this.linkDiscord.Text = "Discord";
            this.linkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Dz3n.MWO.Properties.Resources.mwo_logo;
            this.pictureBox2.Location = new System.Drawing.Point(44, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // BorderOfPanel
            // 
            this.BorderOfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderOfPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BorderOfPanel.Location = new System.Drawing.Point(0, 142);
            this.BorderOfPanel.Name = "BorderOfPanel";
            this.BorderOfPanel.Size = new System.Drawing.Size(521, 77);
            this.BorderOfPanel.TabIndex = 22;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 0;
            this.toolTip.InitialDelay = 1;
            this.toolTip.ReshowDelay = 100;
            // 
            // linkProblems
            // 
            this.linkProblems.ActiveLinkColor = System.Drawing.Color.White;
            this.linkProblems.AutoSize = true;
            this.linkProblems.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.linkProblems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkProblems.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.linkProblems.Location = new System.Drawing.Point(56, 0);
            this.linkProblems.Name = "linkProblems";
            this.linkProblems.Size = new System.Drawing.Size(78, 20);
            this.linkProblems.TabIndex = 24;
            this.linkProblems.TabStop = true;
            this.linkProblems.Text = "Problems?";
            this.linkProblems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProblems_LinkClicked);
            // 
            // WindowBorderLeft
            // 
            this.WindowBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.WindowBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.WindowBorderLeft.Name = "WindowBorderLeft";
            this.WindowBorderLeft.Size = new System.Drawing.Size(1, 290);
            this.WindowBorderLeft.TabIndex = 25;
            // 
            // WindowBorderRight
            // 
            this.WindowBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.WindowBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.WindowBorderRight.Location = new System.Drawing.Point(521, 0);
            this.WindowBorderRight.Name = "WindowBorderRight";
            this.WindowBorderRight.Size = new System.Drawing.Size(1, 290);
            this.WindowBorderRight.TabIndex = 26;
            // 
            // WindowBorderTop
            // 
            this.WindowBorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.WindowBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBorderTop.Location = new System.Drawing.Point(1, 0);
            this.WindowBorderTop.Name = "WindowBorderTop";
            this.WindowBorderTop.Size = new System.Drawing.Size(520, 1);
            this.WindowBorderTop.TabIndex = 27;
            // 
            // WindowBorderBottom
            // 
            this.WindowBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.WindowBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WindowBorderBottom.Location = new System.Drawing.Point(1, 289);
            this.WindowBorderBottom.Name = "WindowBorderBottom";
            this.WindowBorderBottom.Size = new System.Drawing.Size(520, 1);
            this.WindowBorderBottom.TabIndex = 28;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.linkMore);
            this.flowLayoutPanel2.Controls.Add(this.linkDiscord);
            this.flowLayoutPanel2.Controls.Add(this.linkProblems);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(254, 243);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 20);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(522, 290);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.WindowBorderBottom);
            this.Controls.Add(this.WindowBorderTop);
            this.Controls.Add(this.WindowBorderRight);
            this.Controls.Add(this.WindowBorderLeft);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BorderOfPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dz3n.MWO";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.LinkLabel linkServer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkDiscord;
        private System.Windows.Forms.LinkLabel linkMore;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelPing;
        private System.Windows.Forms.Panel BorderOfPanel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel linkProblems;
        private System.Windows.Forms.Panel WindowBorderLeft;
        private System.Windows.Forms.Panel WindowBorderRight;
        private System.Windows.Forms.Panel WindowBorderTop;
        private System.Windows.Forms.Panel WindowBorderBottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

