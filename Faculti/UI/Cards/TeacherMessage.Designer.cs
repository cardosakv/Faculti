
namespace Faculti.UI.Cards
{
    partial class TeacherMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMessage));
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessagePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CommentContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePictureBox)).BeginInit();
            this.CommentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.MessageLabel.Location = new System.Drawing.Point(11, 11);
            this.MessageLabel.MaximumSize = new System.Drawing.Size(350, 500);
            this.MessageLabel.MinimumSize = new System.Drawing.Size(350, 5);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(350, 75);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = resources.GetString("MessageLabel.Text");
            // 
            // MessagePictureBox
            // 
            this.MessagePictureBox.AllowFocused = false;
            this.MessagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessagePictureBox.AutoSizeHeight = false;
            this.MessagePictureBox.BorderRadius = 20;
            this.MessagePictureBox.Image = global::Faculti.Properties.Resources.profile;
            this.MessagePictureBox.IsCircle = false;
            this.MessagePictureBox.Location = new System.Drawing.Point(2, 13);
            this.MessagePictureBox.Name = "MessagePictureBox";
            this.MessagePictureBox.Size = new System.Drawing.Size(40, 40);
            this.MessagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MessagePictureBox.TabIndex = 13;
            this.MessagePictureBox.TabStop = false;
            this.MessagePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // CommentContainer
            // 
            this.CommentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CommentContainer.BackgroundColor = System.Drawing.Color.White;
            this.CommentContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CommentContainer.BackgroundImage")));
            this.CommentContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CommentContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.CommentContainer.BorderRadius = 15;
            this.CommentContainer.BorderThickness = 1;
            this.CommentContainer.Controls.Add(this.MessageLabel);
            this.CommentContainer.Location = new System.Drawing.Point(52, 8);
            this.CommentContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CommentContainer.MaximumSize = new System.Drawing.Size(370, 500);
            this.CommentContainer.Name = "CommentContainer";
            this.CommentContainer.ShowBorders = true;
            this.CommentContainer.Size = new System.Drawing.Size(370, 99);
            this.CommentContainer.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(423, 81);
            this.label1.MaximumSize = new System.Drawing.Size(350, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "12:00 PM ";
            // 
            // TeacherMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessagePictureBox);
            this.Controls.Add(this.CommentContainer);
            this.Name = "TeacherMessage";
            this.Size = new System.Drawing.Size(548, 109);
            ((System.ComponentModel.ISupportInitialize)(this.MessagePictureBox)).EndInit();
            this.CommentContainer.ResumeLayout(false);
            this.CommentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox MessagePictureBox;
        private Bunifu.UI.WinForms.BunifuPanel CommentContainer;
        private System.Windows.Forms.Label label1;
    }
}
