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
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.WindowBorder.ForeColor = System.Drawing.Color.White;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(720, 1);
            this.WindowBorder.TabIndex = 4;
            // 
            // WindowBorder2
            // 
            this.WindowBorder2.BackColor = System.Drawing.Color.Gray;
            this.WindowBorder2.ForeColor = System.Drawing.Color.White;
            this.WindowBorder2.Location = new System.Drawing.Point(-1, 360);
            this.WindowBorder2.Name = "WindowBorder2";
            this.WindowBorder2.Size = new System.Drawing.Size(720, 1);
            this.WindowBorder2.TabIndex = 5;
            // 
            // MoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(522, 361);
            this.Controls.Add(this.WindowBorder2);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.ExitButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MoreWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dz3n.MWO";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoreWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.Panel WindowBorder2;
    }
}

