
namespace Faculti
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.ForgotPasswordEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ForgotPasswordEllipse
            // 
            this.ForgotPasswordEllipse.ElipseRadius = 20;
            this.ForgotPasswordEllipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Circular Spotify Tx T Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Forgot Password?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(34, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(274, 12);
            this.label11.TabIndex = 35;
            this.label11.Text = "Please enter the code we have sent to your email.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Confirmation";
            // 
            // BackButton
            // 
            this.BackButton.ActiveImage = null;
            this.BackButton.AllowAnimations = true;
            this.BackButton.AllowBuffering = false;
            this.BackButton.AllowToggling = false;
            this.BackButton.AllowZooming = false;
            this.BackButton.AllowZoomingOnFocus = false;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BackButton.ErrorImage")));
            this.BackButton.FadeWhenInactive = true;
            this.BackButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BackButton.Image = global::Faculti.Properties.Resources.minimize_button;
            this.BackButton.ImageActive = null;
            this.BackButton.ImageLocation = null;
            this.BackButton.ImageMargin = 0;
            this.BackButton.ImageSize = new System.Drawing.Size(22, 24);
            this.BackButton.ImageZoomSize = new System.Drawing.Size(22, 24);
            this.BackButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("BackButton.InitialImage")));
            this.BackButton.Location = new System.Drawing.Point(21, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.Rotation = 90;
            this.BackButton.ShowActiveImage = true;
            this.BackButton.ShowCursorChanges = true;
            this.BackButton.ShowImageBorders = false;
            this.BackButton.ShowSizeMarkers = false;
            this.BackButton.Size = new System.Drawing.Size(22, 24);
            this.BackButton.TabIndex = 36;
            this.BackButton.ToolTipText = "";
            this.BackButton.WaitOnLoad = false;
            this.BackButton.Zoom = 0;
            this.BackButton.ZoomSpeed = 10;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Circular Spotify Tx T Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(31, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "ERRNGKKKK, NOT YET FINISHED";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faculti -Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ForgotPasswordEllipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuImageButton BackButton;
        private System.Windows.Forms.Label label2;
    }
}