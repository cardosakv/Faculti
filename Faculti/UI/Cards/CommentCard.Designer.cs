
namespace Faculti.UI.Cards
{
    partial class CommentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentCard));
            this.CommentPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CommentAuthorLabel = new System.Windows.Forms.Label();
            this.CommentContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.CommentBodyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CommentPictureBox)).BeginInit();
            this.CommentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommentPictureBox
            // 
            this.CommentPictureBox.AllowFocused = false;
            this.CommentPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentPictureBox.AutoSizeHeight = false;
            this.CommentPictureBox.BorderRadius = 16;
            this.CommentPictureBox.Image = global::Faculti.Properties.Resources.profile;
            this.CommentPictureBox.IsCircle = false;
            this.CommentPictureBox.Location = new System.Drawing.Point(31, 2);
            this.CommentPictureBox.Name = "CommentPictureBox";
            this.CommentPictureBox.Size = new System.Drawing.Size(33, 33);
            this.CommentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CommentPictureBox.TabIndex = 0;
            this.CommentPictureBox.TabStop = false;
            this.CommentPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // CommentAuthorLabel
            // 
            this.CommentAuthorLabel.AutoSize = true;
            this.CommentAuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.CommentAuthorLabel.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.CommentAuthorLabel.Location = new System.Drawing.Point(11, 9);
            this.CommentAuthorLabel.Name = "CommentAuthorLabel";
            this.CommentAuthorLabel.Size = new System.Drawing.Size(102, 15);
            this.CommentAuthorLabel.TabIndex = 1;
            this.CommentAuthorLabel.Text = "Bellatrix Lestrange";
            // 
            // CommentContainer
            // 
            this.CommentContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CommentContainer.BackgroundColor = System.Drawing.Color.White;
            this.CommentContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CommentContainer.BackgroundImage")));
            this.CommentContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CommentContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.CommentContainer.BorderRadius = 15;
            this.CommentContainer.BorderThickness = 1;
            this.CommentContainer.Controls.Add(this.CommentBodyLabel);
            this.CommentContainer.Controls.Add(this.CommentAuthorLabel);
            this.CommentContainer.Location = new System.Drawing.Point(66, 1);
            this.CommentContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CommentContainer.MaximumSize = new System.Drawing.Size(401, 401);
            this.CommentContainer.Name = "CommentContainer";
            this.CommentContainer.ShowBorders = true;
            this.CommentContainer.Size = new System.Drawing.Size(401, 51);
            this.CommentContainer.TabIndex = 2;
            // 
            // CommentBodyLabel
            // 
            this.CommentBodyLabel.AutoSize = true;
            this.CommentBodyLabel.BackColor = System.Drawing.Color.Transparent;
            this.CommentBodyLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentBodyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.CommentBodyLabel.Location = new System.Drawing.Point(11, 27);
            this.CommentBodyLabel.MaximumSize = new System.Drawing.Size(380, 400);
            this.CommentBodyLabel.MinimumSize = new System.Drawing.Size(380, 5);
            this.CommentBodyLabel.Name = "CommentBodyLabel";
            this.CommentBodyLabel.Size = new System.Drawing.Size(380, 12);
            this.CommentBodyLabel.TabIndex = 2;
            this.CommentBodyLabel.Text = "Basta guys inom kayo ng isang basong tubig ";
            // 
            // CommentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.CommentContainer);
            this.Controls.Add(this.CommentPictureBox);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MaximumSize = new System.Drawing.Size(480, 400);
            this.MinimumSize = new System.Drawing.Size(480, 10);
            this.Name = "CommentCard";
            this.Size = new System.Drawing.Size(480, 52);
            ((System.ComponentModel.ISupportInitialize)(this.CommentPictureBox)).EndInit();
            this.CommentContainer.ResumeLayout(false);
            this.CommentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox CommentPictureBox;
        private System.Windows.Forms.Label CommentAuthorLabel;
        private Bunifu.UI.WinForms.BunifuPanel CommentContainer;
        private System.Windows.Forms.Label CommentBodyLabel;
    }
}
