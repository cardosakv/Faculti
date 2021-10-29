namespace Faculti.UI.Cards
{
    partial class TheirImageMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheirImageMessage));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ImageMessagePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MessagePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMessagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeLabel.BackColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Gotham", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.TimeLabel.Location = new System.Drawing.Point(50, 378);
            this.TimeLabel.MaximumSize = new System.Drawing.Size(350, 500);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 25);
            this.TimeLabel.TabIndex = 11;
            this.TimeLabel.Text = "12:00 PM ";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageMessagePictureBox
            // 
            this.ImageMessagePictureBox.AllowFocused = false;
            this.ImageMessagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ImageMessagePictureBox.AutoSizeHeight = false;
            this.ImageMessagePictureBox.BorderRadius = 10;
            this.ImageMessagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImageMessagePictureBox.Image")));
            this.ImageMessagePictureBox.IsCircle = false;
            this.ImageMessagePictureBox.Location = new System.Drawing.Point(52, 0);
            this.ImageMessagePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ImageMessagePictureBox.MaximumSize = new System.Drawing.Size(370, 1000);
            this.ImageMessagePictureBox.MinimumSize = new System.Drawing.Size(370, 50);
            this.ImageMessagePictureBox.Name = "ImageMessagePictureBox";
            this.ImageMessagePictureBox.Size = new System.Drawing.Size(370, 382);
            this.ImageMessagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageMessagePictureBox.TabIndex = 12;
            this.ImageMessagePictureBox.TabStop = false;
            this.ImageMessagePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // MessagePictureBox
            // 
            this.MessagePictureBox.AllowFocused = false;
            this.MessagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MessagePictureBox.AutoSizeHeight = false;
            this.MessagePictureBox.BorderRadius = 20;
            this.MessagePictureBox.Image = global::Faculti.Properties.Resources.profile;
            this.MessagePictureBox.IsCircle = false;
            this.MessagePictureBox.Location = new System.Drawing.Point(2, 343);
            this.MessagePictureBox.Name = "MessagePictureBox";
            this.MessagePictureBox.Size = new System.Drawing.Size(40, 40);
            this.MessagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MessagePictureBox.TabIndex = 14;
            this.MessagePictureBox.TabStop = false;
            this.MessagePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.MessagePictureBox.Click += new System.EventHandler(this.MessagePictureBox_Click);
            // 
            // TheirImageMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MessagePictureBox);
            this.Controls.Add(this.ImageMessagePictureBox);
            this.Controls.Add(this.TimeLabel);
            this.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Name = "TheirImageMessage";
            this.Size = new System.Drawing.Size(535, 395);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMessagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TimeLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox ImageMessagePictureBox;
        private Bunifu.UI.WinForms.BunifuPictureBox MessagePictureBox;
    }
}
