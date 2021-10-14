namespace Faculti.UI.Cards
{
    partial class HolidayEventCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidayEventCard));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.AnnouncementBodyPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.EventTimeTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.HolidayTitleLabel = new System.Windows.Forms.Label();
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
            this.AnnouncementBodyPanel.Controls.Add(this.HolidayTitleLabel);
            this.AnnouncementBodyPanel.Controls.Add(this.EventTimeTextBox);
            this.AnnouncementBodyPanel.Location = new System.Drawing.Point(-1, -2);
            this.AnnouncementBodyPanel.Name = "AnnouncementBodyPanel";
            this.AnnouncementBodyPanel.ShowBorders = true;
            this.AnnouncementBodyPanel.Size = new System.Drawing.Size(232, 99);
            this.AnnouncementBodyPanel.TabIndex = 48;
            // 
            // EventTimeTextBox
            // 
            this.EventTimeTextBox.AcceptsReturn = false;
            this.EventTimeTextBox.AcceptsTab = false;
            this.EventTimeTextBox.AnimationSpeed = 200;
            this.EventTimeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EventTimeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EventTimeTextBox.AutoSizeHeight = true;
            this.EventTimeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EventTimeTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EventTimeTextBox.BackgroundImage")));
            this.EventTimeTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.EventTimeTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.EventTimeTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.EventTimeTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.EventTimeTextBox.BorderRadius = 10;
            this.EventTimeTextBox.BorderThickness = 1;
            this.EventTimeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EventTimeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventTimeTextBox.DefaultFont = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTimeTextBox.DefaultText = "HOLIDAY";
            this.EventTimeTextBox.Enabled = false;
            this.EventTimeTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.EventTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.EventTimeTextBox.HideSelection = true;
            this.EventTimeTextBox.IconLeft = null;
            this.EventTimeTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.EventTimeTextBox.IconPadding = 10;
            this.EventTimeTextBox.IconRight = null;
            this.EventTimeTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.EventTimeTextBox.Lines = new string[] {
        "HOLIDAY"};
            this.EventTimeTextBox.Location = new System.Drawing.Point(20, 21);
            this.EventTimeTextBox.MaxLength = 32767;
            this.EventTimeTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.EventTimeTextBox.Modified = false;
            this.EventTimeTextBox.Multiline = false;
            this.EventTimeTextBox.Name = "EventTimeTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EventTimeTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.EventTimeTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EventTimeTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EventTimeTextBox.OnIdleState = stateProperties4;
            this.EventTimeTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.EventTimeTextBox.PasswordChar = '\0';
            this.EventTimeTextBox.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.EventTimeTextBox.PlaceholderText = "Edit title";
            this.EventTimeTextBox.ReadOnly = false;
            this.EventTimeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EventTimeTextBox.SelectedText = "";
            this.EventTimeTextBox.SelectionLength = 0;
            this.EventTimeTextBox.SelectionStart = 0;
            this.EventTimeTextBox.ShortcutsEnabled = true;
            this.EventTimeTextBox.Size = new System.Drawing.Size(82, 28);
            this.EventTimeTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.EventTimeTextBox.TabIndex = 9;
            this.EventTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EventTimeTextBox.TextMarginBottom = 0;
            this.EventTimeTextBox.TextMarginLeft = -1;
            this.EventTimeTextBox.TextMarginTop = -1;
            this.EventTimeTextBox.TextPlaceholder = "Edit title";
            this.EventTimeTextBox.UseSystemPasswordChar = false;
            this.EventTimeTextBox.WordWrap = true;
            // 
            // HolidayTitleLabel
            // 
            this.HolidayTitleLabel.AutoSize = true;
            this.HolidayTitleLabel.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.HolidayTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.HolidayTitleLabel.Location = new System.Drawing.Point(18, 57);
            this.HolidayTitleLabel.Name = "HolidayTitleLabel";
            this.HolidayTitleLabel.Size = new System.Drawing.Size(114, 21);
            this.HolidayTitleLabel.TabIndex = 10;
            this.HolidayTitleLabel.Text = "Christmas Day";
            // 
            // HolidayEventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.AnnouncementBodyPanel);
            this.Name = "HolidayEventCard";
            this.Size = new System.Drawing.Size(235, 96);
            this.AnnouncementBodyPanel.ResumeLayout(false);
            this.AnnouncementBodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel AnnouncementBodyPanel;
        private Bunifu.UI.WinForms.BunifuTextBox EventTimeTextBox;
        private System.Windows.Forms.Label HolidayTitleLabel;
    }
}
