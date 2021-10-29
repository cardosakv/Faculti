
namespace Faculti.UI.Cards
{
    partial class TheirMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheirMessage));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MessagePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MessageContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePictureBox)).BeginInit();
            this.MessageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeLabel.BackColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Gotham", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.TimeLabel.Location = new System.Drawing.Point(51, 100);
            this.TimeLabel.MaximumSize = new System.Drawing.Size(350, 500);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(115, 25);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "12:00 PM ";
            // 
            // MessagePictureBox
            // 
            this.MessagePictureBox.AllowFocused = false;
            this.MessagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MessagePictureBox.AutoSizeHeight = false;
            this.MessagePictureBox.BorderRadius = 20;
            this.MessagePictureBox.Image = global::Faculti.Properties.Resources.profile;
            this.MessagePictureBox.IsCircle = false;
            this.MessagePictureBox.Location = new System.Drawing.Point(2, 59);
            this.MessagePictureBox.Name = "MessagePictureBox";
            this.MessagePictureBox.Size = new System.Drawing.Size(40, 40);
            this.MessagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MessagePictureBox.TabIndex = 13;
            this.MessagePictureBox.TabStop = false;
            this.MessagePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // MessageContainer
            // 
            this.MessageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MessageContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.MessageContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MessageContainer.BackgroundImage")));
            this.MessageContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.MessageContainer.BorderRadius = 15;
            this.MessageContainer.BorderThickness = 1;
            this.MessageContainer.Controls.Add(this.MessageLabel);
            this.MessageContainer.Location = new System.Drawing.Point(52, 0);
            this.MessageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MessageContainer.MaximumSize = new System.Drawing.Size(370, 500);
            this.MessageContainer.MinimumSize = new System.Drawing.Size(35, 35);
            this.MessageContainer.Name = "MessageContainer";
            this.MessageContainer.ShowBorders = true;
            this.MessageContainer.Size = new System.Drawing.Size(370, 98);
            this.MessageContainer.TabIndex = 14;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.MessageLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.MessageLabel.Location = new System.Drawing.Point(11, 11);
            this.MessageLabel.MaximumSize = new System.Drawing.Size(350, 500);
            this.MessageLabel.MinimumSize = new System.Drawing.Size(20, 15);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(349, 75);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = resources.GetString("MessageLabel.Text");
            // 
            // TheirMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MessagePictureBox);
            this.Controls.Add(this.MessageContainer);
            this.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Name = "TheirMessage";
            this.Size = new System.Drawing.Size(548, 110);
            ((System.ComponentModel.ISupportInitialize)(this.MessagePictureBox)).EndInit();
            this.MessageContainer.ResumeLayout(false);
            this.MessageContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox MessagePictureBox;
        private Bunifu.UI.WinForms.BunifuPanel MessageContainer;
        private System.Windows.Forms.Label TimeLabel;
    }
}
