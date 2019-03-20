namespace Dz3n.MWO
{
    partial class MoreWindow
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
            this.ExitButton = new System.Windows.Forms.Label();
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.WindowBorder2 = new System.Windows.Forms.Panel();
            this.labelAboutMWO = new System.Windows.Forms.Label();
            this.labelChangeLanguage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
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
            // WindowBorder
            // 
            this.WindowBorder.BackColor = System.Drawing.Color.Gray;
            this.WindowBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBorder.ForeColor = System.Drawing.Color.White;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(522, 1);
            this.WindowBorder.TabIndex = 4;
            // 
            // WindowBorder2
            // 
            this.WindowBorder2.BackColor = System.Drawing.Color.Gray;
            this.WindowBorder2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WindowBorder2.ForeColor = System.Drawing.Color.White;
            this.WindowBorder2.Location = new System.Drawing.Point(0, 116);
            this.WindowBorder2.Name = "WindowBorder2";
            this.WindowBorder2.Size = new System.Drawing.Size(522, 1);
            this.WindowBorder2.TabIndex = 5;
            // 
            // labelAboutMWO
            // 
            this.labelAboutMWO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAboutMWO.Location = new System.Drawing.Point(7, 6);
            this.labelAboutMWO.Name = "labelAboutMWO";
            this.labelAboutMWO.Size = new System.Drawing.Size(466, 81);
            this.labelAboutMWO.TabIndex = 6;
            this.labelAboutMWO.Text = "Really big label with a huge amount of different information from different sourc" +
    "es. Do NOT believe humans, they are weird as fuck. скр скр скр в мертвых найках " +
    "";
            // 
            // labelChangeLanguage
            // 
            this.labelChangeLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChangeLanguage.AutoSize = true;
            this.labelChangeLanguage.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelChangeLanguage.Location = new System.Drawing.Point(8, 95);
            this.labelChangeLanguage.Name = "labelChangeLanguage";
            this.labelChangeLanguage.Size = new System.Drawing.Size(102, 13);
            this.labelChangeLanguage.TabIndex = 11;
            this.labelChangeLanguage.Text = "Change language:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(389, 22);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 115);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(521, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 115);
            this.panel2.TabIndex = 7;
            // 
            // MoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(522, 117);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelChangeLanguage);
            this.Controls.Add(this.labelAboutMWO);
            this.Controls.Add(this.WindowBorder2);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.ExitButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MoreWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Dz3n.MWO";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoreWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.Panel WindowBorder2;
        private System.Windows.Forms.Label labelAboutMWO;
        private System.Windows.Forms.Label labelChangeLanguage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

