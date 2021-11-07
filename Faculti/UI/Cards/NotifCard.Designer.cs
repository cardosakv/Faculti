namespace Faculti.UI.Cards
{
    partial class NotifCard
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
            this.components = new System.ComponentModel.Container();
            this.Description = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.IconLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Description.Location = new System.Drawing.Point(53, 5);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(209, 30);
            this.Description.TabIndex = 1;
            this.Description.Text = "Khyle Vincent Cardosa posted something in the feed channel.";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Gotham", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.TimeLabel.Location = new System.Drawing.Point(54, 35);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(70, 16);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "1 min ago";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // IconLabel
            // 
            this.IconLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IconLabel.Location = new System.Drawing.Point(0, 4);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(72, 62);
            this.IconLabel.TabIndex = 3;
            this.IconLabel.Text = "📆";
            // 
            // NotifCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.IconLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NotifCard";
            this.Size = new System.Drawing.Size(267, 51);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label IconLabel;
    }
}
