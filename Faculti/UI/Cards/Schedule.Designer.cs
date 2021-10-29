namespace Faculti.UI.Cards
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.SchedulePanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Subject_Label = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SchedulePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchedulePanel
            // 
            this.SchedulePanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.SchedulePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SchedulePanel.BackgroundImage")));
            this.SchedulePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SchedulePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.SchedulePanel.BorderRadius = 15;
            this.SchedulePanel.BorderThickness = 3;
            this.SchedulePanel.Controls.Add(this.Time_Label);
            this.SchedulePanel.Controls.Add(this.Subject_Label);
            this.SchedulePanel.Location = new System.Drawing.Point(0, 0);
            this.SchedulePanel.Name = "SchedulePanel";
            this.SchedulePanel.ShowBorders = true;
            this.SchedulePanel.Size = new System.Drawing.Size(248, 39);
            this.SchedulePanel.TabIndex = 50;
            // 
            // Time_Label
            // 
            this.Time_Label.BackColor = System.Drawing.Color.Transparent;
            this.Time_Label.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.Time_Label.Location = new System.Drawing.Point(162, 11);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(75, 17);
            this.Time_Label.TabIndex = 4;
            this.Time_Label.Text = "9:00 AM";
            this.Time_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Subject_Label
            // 
            this.Subject_Label.AutoSize = true;
            this.Subject_Label.BackColor = System.Drawing.Color.Transparent;
            this.Subject_Label.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.Subject_Label.Location = new System.Drawing.Point(10, 11);
            this.Subject_Label.Name = "Subject_Label";
            this.Subject_Label.Size = new System.Drawing.Size(61, 17);
            this.Subject_Label.TabIndex = 3;
            this.Subject_Label.Text = "English";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.SchedulePanel);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(248, 39);
            this.SchedulePanel.ResumeLayout(false);
            this.SchedulePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel SchedulePanel;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Label Subject_Label;
        private System.Windows.Forms.Timer Timer;
    }
}
