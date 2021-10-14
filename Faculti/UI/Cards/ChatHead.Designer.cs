
namespace Faculti.UI.Cards
{
    partial class ChatHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatHead));
            this.ChatPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.ChatLastActiveLabel = new System.Windows.Forms.Label();
            this.ChatNameLabel = new System.Windows.Forms.Label();
            this.IsActivePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ChatPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ChatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsActivePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatPanel
            // 
            this.ChatPanel.BackgroundColor = System.Drawing.Color.White;
            this.ChatPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChatPanel.BackgroundImage")));
            this.ChatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChatPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ChatPanel.BorderRadius = 60;
            this.ChatPanel.BorderThickness = 1;
            this.ChatPanel.Controls.Add(this.ChatLastActiveLabel);
            this.ChatPanel.Controls.Add(this.ChatNameLabel);
            this.ChatPanel.Controls.Add(this.IsActivePictureBox);
            this.ChatPanel.Controls.Add(this.ChatPictureBox);
            this.ChatPanel.Location = new System.Drawing.Point(0, 0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.ShowBorders = true;
            this.ChatPanel.Size = new System.Drawing.Size(352, 70);
            this.ChatPanel.TabIndex = 35;
            this.ChatPanel.Click += new System.EventHandler(this.ChatHead_Click);
            this.ChatPanel.MouseEnter += new System.EventHandler(this.ChatHead_MouseHover);
            this.ChatPanel.MouseLeave += new System.EventHandler(this.ChatHead_MouseLeave);
            this.ChatPanel.MouseHover += new System.EventHandler(this.ChatHead_MouseHover);
            // 
            // ChatLastActiveLabel
            // 
            this.ChatLastActiveLabel.AutoSize = true;
            this.ChatLastActiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChatLastActiveLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatLastActiveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.ChatLastActiveLabel.Location = new System.Drawing.Point(66, 39);
            this.ChatLastActiveLabel.Name = "ChatLastActiveLabel";
            this.ChatLastActiveLabel.Size = new System.Drawing.Size(99, 12);
            this.ChatLastActiveLabel.TabIndex = 6;
            this.ChatLastActiveLabel.Text = "Online 1 hour ago";
            this.ChatLastActiveLabel.MouseEnter += new System.EventHandler(this.ChatHead_MouseHover);
            this.ChatLastActiveLabel.MouseLeave += new System.EventHandler(this.ChatHead_MouseLeave);
            this.ChatLastActiveLabel.MouseHover += new System.EventHandler(this.ChatHead_MouseHover);
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChatNameLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ChatNameLabel.Location = new System.Drawing.Point(65, 16);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(127, 15);
            this.ChatNameLabel.TabIndex = 5;
            this.ChatNameLabel.Text = "Bellatrix Lestrange";
            this.ChatNameLabel.MouseEnter += new System.EventHandler(this.ChatHead_MouseHover);
            this.ChatNameLabel.MouseLeave += new System.EventHandler(this.ChatHead_MouseLeave);
            this.ChatNameLabel.MouseHover += new System.EventHandler(this.ChatHead_MouseHover);
            // 
            // IsActivePictureBox
            // 
            this.IsActivePictureBox.AllowFocused = false;
            this.IsActivePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IsActivePictureBox.AutoSizeHeight = false;
            this.IsActivePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.IsActivePictureBox.BorderRadius = 7;
            this.IsActivePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsActivePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IsActivePictureBox.Image")));
            this.IsActivePictureBox.IsCircle = false;
            this.IsActivePictureBox.Location = new System.Drawing.Point(43, 43);
            this.IsActivePictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.IsActivePictureBox.Name = "IsActivePictureBox";
            this.IsActivePictureBox.Size = new System.Drawing.Size(15, 15);
            this.IsActivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsActivePictureBox.TabIndex = 1;
            this.IsActivePictureBox.TabStop = false;
            this.IsActivePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.IsActivePictureBox.MouseEnter += new System.EventHandler(this.ChatHead_MouseHover);
            this.IsActivePictureBox.MouseLeave += new System.EventHandler(this.ChatHead_MouseLeave);
            this.IsActivePictureBox.MouseHover += new System.EventHandler(this.ChatHead_MouseHover);
            // 
            // ChatPictureBox
            // 
            this.ChatPictureBox.AllowFocused = false;
            this.ChatPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChatPictureBox.AutoSizeHeight = false;
            this.ChatPictureBox.BackColor = System.Drawing.Color.White;
            this.ChatPictureBox.BorderRadius = 22;
            this.ChatPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ChatPictureBox.Image")));
            this.ChatPictureBox.IsCircle = false;
            this.ChatPictureBox.Location = new System.Drawing.Point(13, 12);
            this.ChatPictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ChatPictureBox.Name = "ChatPictureBox";
            this.ChatPictureBox.Size = new System.Drawing.Size(45, 45);
            this.ChatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChatPictureBox.TabIndex = 4;
            this.ChatPictureBox.TabStop = false;
            this.ChatPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.ChatPictureBox.MouseEnter += new System.EventHandler(this.ChatHead_MouseHover);
            this.ChatPictureBox.MouseLeave += new System.EventHandler(this.ChatHead_MouseLeave);
            this.ChatPictureBox.MouseHover += new System.EventHandler(this.ChatHead_MouseHover);
            // 
            // ChatHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.ChatPanel);
            this.Name = "ChatHead";
            this.Size = new System.Drawing.Size(355, 73);
            this.MouseEnter += new System.EventHandler(this.ChatHead_MouseHover);
            this.MouseLeave += new System.EventHandler(this.ChatHead_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ChatHead_MouseHover);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsActivePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel ChatPanel;
        private System.Windows.Forms.Label ChatNameLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox IsActivePictureBox;
        private Bunifu.UI.WinForms.BunifuPictureBox ChatPictureBox;
        private System.Windows.Forms.Label ChatLastActiveLabel;
    }
}
