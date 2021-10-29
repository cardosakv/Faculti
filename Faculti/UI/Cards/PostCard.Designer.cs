
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCard));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.PostPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.IsTeacherLabel = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LikeCountLabel = new System.Windows.Forms.Label();
            this.PostBodyLabel = new System.Windows.Forms.Label();
            this.CommentPostTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LikeButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PostPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.PostDateTimeLabel = new System.Windows.Forms.Label();
            this.PosterNameLabel = new System.Windows.Forms.Label();
            this.PostTimer = new System.Windows.Forms.Timer(this.components);
            this.GetCommentsWorker = new System.ComponentModel.BackgroundWorker();
            this.PostInfoWorker = new System.ComponentModel.BackgroundWorker();
            this.PostCommentWorker = new System.ComponentModel.BackgroundWorker();
            this.PostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPanel
            // 
            this.PostPanel.AutoSize = true;
            this.PostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.PostPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PostPanel.BorderRadius = 15;
            this.PostPanel.BorderThickness = 0;
            this.PostPanel.Controls.Add(this.IsTeacherLabel);
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
            this.PostPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.PostPanel.ShadowDept = 2;
            this.PostPanel.ShadowDepth = 3;
            this.PostPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.PostPanel.ShadowTopLeftVisible = false;
            this.PostPanel.Size = new System.Drawing.Size(480, 198);
            this.PostPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.PostPanel.TabIndex = 53;
            // 
            // IsTeacherLabel
            // 
            this.IsTeacherLabel.AcceptsReturn = false;
            this.IsTeacherLabel.AcceptsTab = false;
            this.IsTeacherLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IsTeacherLabel.AnimationSpeed = 200;
            this.IsTeacherLabel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.IsTeacherLabel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.IsTeacherLabel.AutoSizeHeight = true;
            this.IsTeacherLabel.BackColor = System.Drawing.Color.Transparent;
            this.IsTeacherLabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IsTeacherLabel.BackgroundImage")));
            this.IsTeacherLabel.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IsTeacherLabel.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IsTeacherLabel.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IsTeacherLabel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IsTeacherLabel.BorderRadius = 10;
            this.IsTeacherLabel.BorderThickness = 1;
            this.IsTeacherLabel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.IsTeacherLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IsTeacherLabel.DefaultFont = new System.Drawing.Font("Gotham", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsTeacherLabel.DefaultText = "Teacher";
            this.IsTeacherLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IsTeacherLabel.ForeColor = System.Drawing.Color.White;
            this.IsTeacherLabel.HideSelection = true;
            this.IsTeacherLabel.IconLeft = null;
            this.IsTeacherLabel.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.IsTeacherLabel.IconPadding = 10;
            this.IsTeacherLabel.IconRight = null;
            this.IsTeacherLabel.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.IsTeacherLabel.Lines = new string[] {
        "Teacher"};
            this.IsTeacherLabel.Location = new System.Drawing.Point(419, 16);
            this.IsTeacherLabel.MaxLength = 32767;
            this.IsTeacherLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.IsTeacherLabel.Modified = false;
            this.IsTeacherLabel.Multiline = false;
            this.IsTeacherLabel.Name = "IsTeacherLabel";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.IsTeacherLabel.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.IsTeacherLabel.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.IsTeacherLabel.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.IsTeacherLabel.OnIdleState = stateProperties4;
            this.IsTeacherLabel.Padding = new System.Windows.Forms.Padding(3);
            this.IsTeacherLabel.PasswordChar = '\0';
            this.IsTeacherLabel.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.IsTeacherLabel.PlaceholderText = "Write a reply";
            this.IsTeacherLabel.ReadOnly = false;
            this.IsTeacherLabel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IsTeacherLabel.SelectedText = "";
            this.IsTeacherLabel.SelectionLength = 0;
            this.IsTeacherLabel.SelectionStart = 7;
            this.IsTeacherLabel.ShortcutsEnabled = true;
            this.IsTeacherLabel.Size = new System.Drawing.Size(47, 18);
            this.IsTeacherLabel.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.IsTeacherLabel.TabIndex = 56;
            this.IsTeacherLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IsTeacherLabel.TextMarginBottom = 0;
            this.IsTeacherLabel.TextMarginLeft = -5;
            this.IsTeacherLabel.TextMarginTop = -1;
            this.IsTeacherLabel.TextPlaceholder = "Write a reply";
            this.IsTeacherLabel.UseSystemPasswordChar = false;
            this.IsTeacherLabel.Visible = false;
            this.IsTeacherLabel.WordWrap = true;
            // 
            // LikeCountLabel
            // 
            this.LikeCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LikeCountLabel.AutoSize = true;
            this.LikeCountLabel.BackColor = System.Drawing.Color.White;
            this.LikeCountLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikeCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.LikeCountLabel.Location = new System.Drawing.Point(43, 164);
            this.LikeCountLabel.Name = "LikeCountLabel";
            this.LikeCountLabel.Size = new System.Drawing.Size(16, 12);
            this.LikeCountLabel.TabIndex = 3;
            this.LikeCountLabel.Text = "12";
            // 
            // PostBodyLabel
            // 
            this.PostBodyLabel.AutoSize = true;
            this.PostBodyLabel.BackColor = System.Drawing.Color.White;
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
            this.CommentPostTextBox.Location = new System.Drawing.Point(65, 157);
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
            this.CommentPostTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommentPostTextBox_KeyDown);
            // 
            // LikeButton
            // 
            this.LikeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LikeButton.BackColor = System.Drawing.Color.White;
            this.LikeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikeButton.Image = global::Faculti.Properties.Resources.like_inactive;
            this.LikeButton.Location = new System.Drawing.Point(17, 157);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(25, 25);
            this.LikeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikeButton.TabIndex = 5;
            this.LikeButton.TabStop = false;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PostDateTimeLabel);
            this.panel1.Controls.Add(this.PosterNameLabel);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 38);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PostPictureBox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 38);
            this.panel2.TabIndex = 57;
            // 
            // PostPictureBox
            // 
            this.PostPictureBox.AllowFocused = false;
            this.PostPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostPictureBox.AutoSizeHeight = false;
            this.PostPictureBox.BorderRadius = 19;
            this.PostPictureBox.Image = global::Faculti.Properties.Resources.profile;
            this.PostPictureBox.IsCircle = false;
            this.PostPictureBox.Location = new System.Drawing.Point(0, -2);
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
            this.PostDateTimeLabel.BackColor = System.Drawing.Color.White;
            this.PostDateTimeLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.PostDateTimeLabel.Location = new System.Drawing.Point(49, 22);
            this.PostDateTimeLabel.Name = "PostDateTimeLabel";
            this.PostDateTimeLabel.Size = new System.Drawing.Size(94, 12);
            this.PostDateTimeLabel.TabIndex = 2;
            this.PostDateTimeLabel.Text = "Oct 10 • 7:34 PM";
            // 
            // PosterNameLabel
            // 
            this.PosterNameLabel.AutoSize = true;
            this.PosterNameLabel.BackColor = System.Drawing.Color.White;
            this.PosterNameLabel.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosterNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.PosterNameLabel.Location = new System.Drawing.Point(47, 0);
            this.PosterNameLabel.Name = "PosterNameLabel";
            this.PosterNameLabel.Size = new System.Drawing.Size(141, 21);
            this.PosterNameLabel.TabIndex = 1;
            this.PosterNameLabel.Text = "Bellatrix Lestrange";
            // 
            // PostTimer
            // 
            this.PostTimer.Enabled = true;
            this.PostTimer.Interval = 5000;
            this.PostTimer.Tick += new System.EventHandler(this.PostTimer_Tick);
            // 
            // GetCommentsWorker
            // 
            this.GetCommentsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CommentWorker_DoWork);
            this.GetCommentsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CommentWorker_RunWorkerCompleted);
            // 
            // PostInfoWorker
            // 
            this.PostInfoWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PostInfoWorker_DoWork);
            this.PostInfoWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PostInfoWorker_RunWorkerCompleted);
            // 
            // PostCommentWorker
            // 
            this.PostCommentWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PostCommentWorker_DoWork);
            this.PostCommentWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PostCommentWorker_RunWorkerCompleted);
            // 
            // PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.PostPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.MaximumSize = new System.Drawing.Size(483, 10000);
            this.Name = "PostCard";
            this.Size = new System.Drawing.Size(483, 201);
            this.PostPanel.ResumeLayout(false);
            this.PostPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Timer PostTimer;
        private System.ComponentModel.BackgroundWorker GetCommentsWorker;
        private System.ComponentModel.BackgroundWorker PostInfoWorker;
        private Bunifu.UI.WinForms.BunifuTextBox IsTeacherLabel;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker PostCommentWorker;
    }
}
