
namespace Faculti.UI.Cards
{
    partial class AnnouncementPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnouncementPanel));
            this.AnnouncementBodyPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.AnnouncementMessageLabel = new System.Windows.Forms.Label();
            this.AnnouncementTitleLabel = new System.Windows.Forms.Label();
            this.AnnouncementBodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnnouncementBodyPanel
            // 
            this.AnnouncementBodyPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.AnnouncementBodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnnouncementBodyPanel.BackgroundImage")));
            this.AnnouncementBodyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnnouncementBodyPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AnnouncementBodyPanel.BorderRadius = 15;
            this.AnnouncementBodyPanel.BorderThickness = 3;
            this.AnnouncementBodyPanel.Controls.Add(this.AnnouncementMessageLabel);
            this.AnnouncementBodyPanel.Controls.Add(this.AnnouncementTitleLabel);
            this.AnnouncementBodyPanel.Location = new System.Drawing.Point(-2, -2);
            this.AnnouncementBodyPanel.Name = "AnnouncementBodyPanel";
            this.AnnouncementBodyPanel.ShowBorders = true;
            this.AnnouncementBodyPanel.Size = new System.Drawing.Size(312, 171);
            this.AnnouncementBodyPanel.TabIndex = 46;
            // 
            // AnnouncementMessageLabel
            // 
            this.AnnouncementMessageLabel.AutoSize = true;
            this.AnnouncementMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.AnnouncementMessageLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.AnnouncementMessageLabel.Location = new System.Drawing.Point(19, 46);
            this.AnnouncementMessageLabel.MaximumSize = new System.Drawing.Size(265, 0);
            this.AnnouncementMessageLabel.Name = "AnnouncementMessageLabel";
            this.AnnouncementMessageLabel.Size = new System.Drawing.Size(247, 105);
            this.AnnouncementMessageLabel.TabIndex = 5;
            this.AnnouncementMessageLabel.Text = "Following the announcement of the local city government, classes are suspended on" +
    " October 30 as a preemptive public safety measure in view of the upcoming typhoo" +
    "n.\r\n\r\nStay safe everyone!";
            // 
            // AnnouncementTitleLabel
            // 
            this.AnnouncementTitleLabel.AutoSize = true;
            this.AnnouncementTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.AnnouncementTitleLabel.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.AnnouncementTitleLabel.Location = new System.Drawing.Point(19, 17);
            this.AnnouncementTitleLabel.MaximumSize = new System.Drawing.Size(265, 0);
            this.AnnouncementTitleLabel.Name = "AnnouncementTitleLabel";
            this.AnnouncementTitleLabel.Size = new System.Drawing.Size(144, 23);
            this.AnnouncementTitleLabel.TabIndex = 4;
            this.AnnouncementTitleLabel.Text = "No Classes Today";
            // 
            // AnnouncementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.AnnouncementBodyPanel);
            this.Name = "AnnouncementPanel";
            this.Size = new System.Drawing.Size(313, 172);
            this.AnnouncementBodyPanel.ResumeLayout(false);
            this.AnnouncementBodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel AnnouncementBodyPanel;
        private System.Windows.Forms.Label AnnouncementMessageLabel;
        private System.Windows.Forms.Label AnnouncementTitleLabel;
    }
}
