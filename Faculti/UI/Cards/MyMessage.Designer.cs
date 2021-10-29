
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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MessageContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeLabel.BackColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Gotham", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.TimeLabel.Location = new System.Drawing.Point(453, 88);
            this.TimeLabel.MaximumSize = new System.Drawing.Size(350, 500);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 25);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "12:00 PM ";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MessageContainer
            // 
            this.MessageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MessageContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MessageContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MessageContainer.BackgroundImage")));
            this.MessageContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MessageContainer.BorderRadius = 15;
            this.MessageContainer.BorderThickness = 0;
            this.MessageContainer.Controls.Add(this.MessageLabel);
            this.MessageContainer.Location = new System.Drawing.Point(158, 1);
            this.MessageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MessageContainer.MaximumSize = new System.Drawing.Size(370, 500);
            this.MessageContainer.Name = "MessageContainer";
            this.MessageContainer.ShowBorders = true;
            this.MessageContainer.Size = new System.Drawing.Size(370, 91);
            this.MessageContainer.TabIndex = 8;
            this.MessageContainer.Click += new System.EventHandler(this.MessageContainer_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MessageLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(11, 11);
            this.MessageLabel.MaximumSize = new System.Drawing.Size(350, 450);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(85, 15);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "sample chat";
            // 
            // MyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MessageContainer);
            this.Controls.Add(this.TimeLabel);
            this.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Name = "MyMessage";
            this.Size = new System.Drawing.Size(535, 105);
            this.MessageContainer.ResumeLayout(false);
            this.MessageContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private Bunifu.UI.WinForms.BunifuPanel MessageContainer;
        private System.Windows.Forms.Label TimeLabel;
    }
}
