
namespace Faculti.UI.Cards
{
    partial class MyMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessage));
            this.CommentContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CommentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommentContainer
            // 
            this.CommentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CommentContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CommentContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CommentContainer.BackgroundImage")));
            this.CommentContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CommentContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.CommentContainer.BorderRadius = 15;
            this.CommentContainer.BorderThickness = 0;
            this.CommentContainer.Controls.Add(this.MessageLabel);
            this.CommentContainer.Location = new System.Drawing.Point(163, 10);
            this.CommentContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CommentContainer.MaximumSize = new System.Drawing.Size(370, 500);
            this.CommentContainer.Name = "CommentContainer";
            this.CommentContainer.ShowBorders = true;
            this.CommentContainer.Size = new System.Drawing.Size(370, 97);
            this.CommentContainer.TabIndex = 8;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(11, 11);
            this.MessageLabel.MaximumSize = new System.Drawing.Size(350, 500);
            this.MessageLabel.MinimumSize = new System.Drawing.Size(350, 5);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(350, 75);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = resources.GetString("MessageLabel.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.MaximumSize = new System.Drawing.Size(350, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "12:00 PM ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentContainer);
            this.Name = "MyMessage";
            this.Size = new System.Drawing.Size(535, 107);
            this.CommentContainer.ResumeLayout(false);
            this.CommentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private Bunifu.UI.WinForms.BunifuPanel CommentContainer;
        private System.Windows.Forms.Label label1;
    }
}
