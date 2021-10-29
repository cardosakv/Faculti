
namespace Faculti
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.LockupPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashScreenElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BouncingPictureBox = new System.Windows.Forms.PictureBox();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.FadeInTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LockupPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BouncingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LockupPictureBox
            // 
            this.LockupPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LockupPictureBox.Image = global::Faculti.Properties.Resources.Asset_131;
            this.LockupPictureBox.Location = new System.Drawing.Point(166, 130);
            this.LockupPictureBox.Name = "LockupPictureBox";
            this.LockupPictureBox.Size = new System.Drawing.Size(251, 144);
            this.LockupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LockupPictureBox.TabIndex = 0;
            this.LockupPictureBox.TabStop = false;
            // 
            // SplashScreenElipse
            // 
            this.SplashScreenElipse.ElipseRadius = 20;
            this.SplashScreenElipse.TargetControl = this;
            // 
            // BouncingPictureBox
            // 
            this.BouncingPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BouncingPictureBox.Image = global::Faculti.Properties.Resources.Ball_0_4s_54px;
            this.BouncingPictureBox.Location = new System.Drawing.Point(398, 160);
            this.BouncingPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.BouncingPictureBox.Name = "BouncingPictureBox";
            this.BouncingPictureBox.Size = new System.Drawing.Size(20, 34);
            this.BouncingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BouncingPictureBox.TabIndex = 1;
            this.BouncingPictureBox.TabStop = false;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Font = new System.Drawing.Font("Gotham", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.CopyrightLabel.Location = new System.Drawing.Point(189, 373);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(205, 10);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "Copyright © 2021 W4RR10RS. All Rights Reserved.";
            // 
            // FadeInTimer
            // 
            this.FadeInTimer.Enabled = true;
            this.FadeInTimer.Interval = 20;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Faculti.Properties.Resources.splashscreen_bg1;
            this.ClientSize = new System.Drawing.Size(584, 405);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.BouncingPictureBox);
            this.Controls.Add(this.LockupPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculti";
            this.Shown += new System.EventHandler(this.SplashScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.LockupPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BouncingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LockupPictureBox;
        private Bunifu.Framework.UI.BunifuElipse SplashScreenElipse;
        private System.Windows.Forms.PictureBox BouncingPictureBox;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Timer FadeInTimer;
    }
}