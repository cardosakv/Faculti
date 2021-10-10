
namespace Faculti.UI.Cards
{
    partial class PostCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCard));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.PostPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.PostBodyLabel = new System.Windows.Forms.Label();
            this.CommentPostTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LikeButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PostPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.PostDateTimeLabel = new System.Windows.Forms.Label();
            this.PosterNameLabel = new System.Windows.Forms.Label();
            this.LikeCountLabel = new System.Windows.Forms.Label();
            this.PostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikeButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPanel
            // 
            this.PostPanel.AutoSize = true;
            this.PostPanel.BackColor = System.Drawing.Color.Transparent;
            this.PostPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.PostPanel.BorderRadius = 15;
            this.PostPanel.BorderThickness = 1;
            this.PostPanel.Controls.Add(this.LikeCountLabel);
            this.PostPanel.Controls.Add(this.PostBodyLabel);
            this.PostPanel.Controls.Add(this.CommentPostTextBox);
            this.PostPanel.Controls.Add(this.LikeButton);
            this.PostPanel.Controls.Add(this.panel1);
            this.PostPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.PostPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.PostPanel.Location = new System.Drawing.Point(0, 0);
            this.PostPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.PostPanel.MaximumSize = new System.Drawing.Size(480, 480);
            this.PostPanel.MinimumSize = new System.Drawing.Size(480, 147);
            this.PostPanel.Name = "PostPanel";
            this.PostPanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.PostPanel.PanelColor = System.Drawing.Color.White;
            this.PostPanel.PanelColor2 = System.Drawing.Color.White;
            this.PostPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.PostPanel.ShadowDept = 2;
            this.PostPanel.ShadowDepth = 1;
            this.PostPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.PostPanel.ShadowTopLeftVisible = false;
            this.PostPanel.Size = new System.Drawing.Size(480, 147);
            this.PostPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.PostPanel.TabIndex = 53;
            // 
            // PostBodyLabel
            // 
            this.PostBodyLabel.AutoSize = true;
            this.PostBodyLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostBodyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.PostBodyLabel.Location = new System.Drawing.Point(25, 70);
            this.PostBodyLabel.MaximumSize = new System.Drawing.Size(442, 400);
            this.PostBodyLabel.Name = "PostBodyLabel";
            this.PostBodyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostBodyLabel.Size = new System.Drawing.Size(89, 15);
            this.PostBodyLabel.TabIndex = 55;
            this.PostBodyLabel.Text = "This is a post";
            // 
            // CommentPostTextBox
            // 
            this.CommentPostTextBox.AcceptsReturn = false;
            this.CommentPostTextBox.AcceptsTab = false;
            this.CommentPostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CommentPostTextBox.AnimationSpeed = 200;
            this.CommentPostTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CommentPostTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CommentPostTextBox.AutoSizeHeight = true;
            this.CommentPostTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CommentPostTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CommentPostTextBox.BackgroundImage")));
            this.CommentPostTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.CommentPostTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CommentPostTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.CommentPostTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CommentPostTextBox.BorderRadius = 15;
            this.CommentPostTextBox.BorderThickness = 1;
            this.CommentPostTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CommentPostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentPostTextBox.DefaultFont = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentPostTextBox.DefaultText = "";
            this.CommentPostTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CommentPostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.CommentPostTextBox.HideSelection = true;
            this.CommentPostTextBox.IconLeft = null;
            this.CommentPostTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentPostTextBox.IconPadding = 10;
            this.CommentPostTextBox.IconRight = null;
            this.CommentPostTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentPostTextBox.Lines = new string[0];
            this.CommentPostTextBox.Location = new System.Drawing.Point(65, 106);
            this.CommentPostTextBox.MaxLength = 32767;
            this.CommentPostTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.CommentPostTextBox.Modified = false;
            this.CommentPostTextBox.Multiline = false;
            this.CommentPostTextBox.Name = "CommentPostTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CommentPostTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CommentPostTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CommentPostTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CommentPostTextBox.OnIdleState = stateProperties8;
            this.CommentPostTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.CommentPostTextBox.PasswordChar = '\0';
            this.CommentPostTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.CommentPostTextBox.PlaceholderText = "Write a reply";
            this.CommentPostTextBox.ReadOnly = false;
            this.CommentPostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CommentPostTextBox.SelectedText = "";
            this.CommentPostTextBox.SelectionLength = 0;
            this.CommentPostTextBox.SelectionStart = 0;
            this.CommentPostTextBox.ShortcutsEnabled = true;
            this.CommentPostTextBox.Size = new System.Drawing.Size(401, 28);
            this.CommentPostTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CommentPostTextBox.TabIndex = 54;
            this.CommentPostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CommentPostTextBox.TextMarginBottom = 0;
            this.CommentPostTextBox.TextMarginLeft = 0;
            this.CommentPostTextBox.TextMarginTop = 0;
            this.CommentPostTextBox.TextPlaceholder = "Write a reply";
            this.CommentPostTextBox.UseSystemPasswordChar = false;
            this.CommentPostTextBox.WordWrap = true;
            // 
            // LikeButton
            // 
            this.LikeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LikeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikeButton.Image = global::Faculti.Properties.Resources.like_inactive;
            this.LikeButton.Location = new System.Drawing.Point(17, 106);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(25, 25);
            this.LikeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikeButton.TabIndex = 5;
            this.LikeButton.TabStop = false;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PostPictureBox);
            this.panel1.Controls.Add(this.PostDateTimeLabel);
            this.panel1.Controls.Add(this.PosterNameLabel);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 38);
            this.panel1.TabIndex = 3;
            // 
            // PostPictureBox
            // 
            this.PostPictureBox.AllowFocused = false;
            this.PostPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostPictureBox.AutoSizeHeight = false;
            this.PostPictureBox.BorderRadius = 19;
            this.PostPictureBox.Image = global::Faculti.Properties.Resources.profile;
            this.PostPictureBox.IsCircle = false;
            this.PostPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PostPictureBox.Name = "PostPictureBox";
            this.PostPictureBox.Size = new System.Drawing.Size(38, 38);
            this.PostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PostPictureBox.TabIndex = 0;
            this.PostPictureBox.TabStop = false;
            this.PostPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // PostDateTimeLabel
            // 
            this.PostDateTimeLabel.AutoSize = true;
            this.PostDateTimeLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.PostDateTimeLabel.Location = new System.Drawing.Point(49, 21);
            this.PostDateTimeLabel.Name = "PostDateTimeLabel";
            this.PostDateTimeLabel.Size = new System.Drawing.Size(94, 12);
            this.PostDateTimeLabel.TabIndex = 2;
            this.PostDateTimeLabel.Text = "Oct 10 • 7:34 PM";
            // 
            // PosterNameLabel
            // 
            this.PosterNameLabel.AutoSize = true;
            this.PosterNameLabel.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosterNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.PosterNameLabel.Location = new System.Drawing.Point(48, 2);
            this.PosterNameLabel.Name = "PosterNameLabel";
            this.PosterNameLabel.Size = new System.Drawing.Size(121, 18);
            this.PosterNameLabel.TabIndex = 1;
            this.PosterNameLabel.Text = "Bellatrix Lestrange";
            // 
            // LikeCountLabel
            // 
            this.LikeCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LikeCountLabel.AutoSize = true;
            this.LikeCountLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikeCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.LikeCountLabel.Location = new System.Drawing.Point(43, 113);
            this.LikeCountLabel.Name = "LikeCountLabel";
            this.LikeCountLabel.Size = new System.Drawing.Size(16, 12);
            this.LikeCountLabel.TabIndex = 3;
            this.LikeCountLabel.Text = "12";
            // 
            // PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.PostPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.MaximumSize = new System.Drawing.Size(483, 480);
            this.Name = "PostCard";
            this.Size = new System.Drawing.Size(483, 150);
            this.PostPanel.ResumeLayout(false);
            this.PostPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel PostPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox PostPictureBox;
        private System.Windows.Forms.Label PosterNameLabel;
        private System.Windows.Forms.Label PostDateTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LikeButton;
        private Bunifu.UI.WinForms.BunifuTextBox CommentPostTextBox;
        private System.Windows.Forms.Label PostBodyLabel;
        private System.Windows.Forms.Label LikeCountLabel;
    }
}
