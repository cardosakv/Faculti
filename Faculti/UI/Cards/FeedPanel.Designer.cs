
namespace Faculti.UI.Cards
{
    partial class FeedPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.DisplayPostWorker = new System.ComponentModel.BackgroundWorker();
            this.FeedLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuShadowPanel6 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PostPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.PostButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.WritePostTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedError = new System.Windows.Forms.Panel();
            this.FeedLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PostBodyLabel = new System.Windows.Forms.Label();
            this.RetryFeedButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.AnnouncementsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AnnounceWorker = new System.ComponentModel.BackgroundWorker();
            this.InsertPostWorker = new System.ComponentModel.BackgroundWorker();
            this.AnnounceTimer = new System.Windows.Forms.Timer(this.components);
            this.NewPostUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.FeedLayoutPanel.SuspendLayout();
            this.bunifuShadowPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.FeedError.SuspendLayout();
            this.FeedLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPostWorker
            // 
            this.DisplayPostWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DisplayPostWorker_DoWork);
            this.DisplayPostWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DisplayPostWorker_RunWorkerCompleted);
            // 
            // FeedLayoutPanel
            // 
            this.FeedLayoutPanel.AutoScroll = true;
            this.FeedLayoutPanel.Controls.Add(this.bunifuShadowPanel6);
            this.FeedLayoutPanel.Controls.Add(this.bunifuShadowPanel2);
            this.FeedLayoutPanel.Controls.Add(this.bunifuPanel1);
            this.FeedLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FeedLayoutPanel.Location = new System.Drawing.Point(13, 1);
            this.FeedLayoutPanel.Name = "FeedLayoutPanel";
            this.FeedLayoutPanel.Size = new System.Drawing.Size(969, 626);
            this.FeedLayoutPanel.TabIndex = 46;
            this.FeedLayoutPanel.WrapContents = false;
            // 
            // bunifuShadowPanel6
            // 
            this.bunifuShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuShadowPanel6.BorderRadius = 15;
            this.bunifuShadowPanel6.BorderThickness = 1;
            this.bunifuShadowPanel6.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel6.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel6.Location = new System.Drawing.Point(3, 3);
            this.bunifuShadowPanel6.Name = "bunifuShadowPanel6";
            this.bunifuShadowPanel6.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuShadowPanel6.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuShadowPanel6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuShadowPanel6.ShadowDept = 2;
            this.bunifuShadowPanel6.ShadowDepth = 3;
            this.bunifuShadowPanel6.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel6.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel6.Size = new System.Drawing.Size(480, 6);
            this.bunifuShadowPanel6.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel6.TabIndex = 50;
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.bunifuShadowPanel2.BorderRadius = 15;
            this.bunifuShadowPanel2.BorderThickness = 0;
            this.bunifuShadowPanel2.Controls.Add(this.panel2);
            this.bunifuShadowPanel2.Controls.Add(this.PostButton);
            this.bunifuShadowPanel2.Controls.Add(this.WritePostTextBox);
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(3, 15);
            this.bunifuShadowPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 3;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(480, 151);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PostPictureBox);
            this.panel2.Location = new System.Drawing.Point(14, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 38);
            this.panel2.TabIndex = 58;
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
            // PostButton
            // 
            this.PostButton.AllowAnimations = true;
            this.PostButton.AllowMouseEffects = true;
            this.PostButton.AllowToggling = false;
            this.PostButton.AnimationSpeed = 200;
            this.PostButton.AutoGenerateColors = false;
            this.PostButton.AutoRoundBorders = false;
            this.PostButton.AutoSizeLeftIcon = true;
            this.PostButton.AutoSizeRightIcon = true;
            this.PostButton.BackColor = System.Drawing.Color.Transparent;
            this.PostButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PostButton.BackgroundImage")));
            this.PostButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.PostButton.ButtonText = "Post Now";
            this.PostButton.ButtonTextMarginLeft = 0;
            this.PostButton.ColorContrastOnClick = 45;
            this.PostButton.ColorContrastOnHover = 45;
            this.PostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.PostButton.CustomizableEdges = borderEdges2;
            this.PostButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PostButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PostButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PostButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PostButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.PostButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.ForeColor = System.Drawing.Color.White;
            this.PostButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PostButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.PostButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.PostButton.IconMarginLeft = 11;
            this.PostButton.IconPadding = 10;
            this.PostButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PostButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.PostButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.PostButton.IconSize = 25;
            this.PostButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.IdleBorderRadius = 15;
            this.PostButton.IdleBorderThickness = 1;
            this.PostButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.IdleIconLeftImage = null;
            this.PostButton.IdleIconRightImage = null;
            this.PostButton.IndicateFocus = false;
            this.PostButton.Location = new System.Drawing.Point(60, 106);
            this.PostButton.Name = "PostButton";
            this.PostButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PostButton.OnDisabledState.BorderRadius = 15;
            this.PostButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.PostButton.OnDisabledState.BorderThickness = 1;
            this.PostButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PostButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PostButton.OnDisabledState.IconLeftImage = null;
            this.PostButton.OnDisabledState.IconRightImage = null;
            this.PostButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.PostButton.onHoverState.BorderRadius = 15;
            this.PostButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.PostButton.onHoverState.BorderThickness = 1;
            this.PostButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.PostButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.PostButton.onHoverState.IconLeftImage = null;
            this.PostButton.onHoverState.IconRightImage = null;
            this.PostButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.OnIdleState.BorderRadius = 15;
            this.PostButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.PostButton.OnIdleState.BorderThickness = 1;
            this.PostButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.PostButton.OnIdleState.IconLeftImage = null;
            this.PostButton.OnIdleState.IconRightImage = null;
            this.PostButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.OnPressedState.BorderRadius = 15;
            this.PostButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.PostButton.OnPressedState.BorderThickness = 1;
            this.PostButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.PostButton.OnPressedState.IconLeftImage = null;
            this.PostButton.OnPressedState.IconRightImage = null;
            this.PostButton.Size = new System.Drawing.Size(405, 30);
            this.PostButton.TabIndex = 54;
            this.PostButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PostButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostButton.TextMarginLeft = 0;
            this.PostButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.PostButton.UseDefaultRadiusAndThickness = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // WritePostTextBox
            // 
            this.WritePostTextBox.AcceptsReturn = false;
            this.WritePostTextBox.AcceptsTab = false;
            this.WritePostTextBox.AnimationSpeed = 200;
            this.WritePostTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.WritePostTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.WritePostTextBox.AutoSizeHeight = true;
            this.WritePostTextBox.BackColor = System.Drawing.Color.Transparent;
            this.WritePostTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WritePostTextBox.BackgroundImage")));
            this.WritePostTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.WritePostTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.WritePostTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.WritePostTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.WritePostTextBox.BorderRadius = 15;
            this.WritePostTextBox.BorderThickness = 1;
            this.WritePostTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.WritePostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WritePostTextBox.DefaultFont = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritePostTextBox.DefaultText = "";
            this.WritePostTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.WritePostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.WritePostTextBox.HideSelection = true;
            this.WritePostTextBox.IconLeft = null;
            this.WritePostTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.WritePostTextBox.IconPadding = 10;
            this.WritePostTextBox.IconRight = null;
            this.WritePostTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.WritePostTextBox.Lines = new string[0];
            this.WritePostTextBox.Location = new System.Drawing.Point(60, 17);
            this.WritePostTextBox.MaxLength = 32767;
            this.WritePostTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.WritePostTextBox.Modified = false;
            this.WritePostTextBox.Multiline = true;
            this.WritePostTextBox.Name = "WritePostTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.WritePostTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.WritePostTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.WritePostTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.WritePostTextBox.OnIdleState = stateProperties8;
            this.WritePostTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.WritePostTextBox.PasswordChar = '\0';
            this.WritePostTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.WritePostTextBox.PlaceholderText = "Write something...";
            this.WritePostTextBox.ReadOnly = false;
            this.WritePostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WritePostTextBox.SelectedText = "";
            this.WritePostTextBox.SelectionLength = 0;
            this.WritePostTextBox.SelectionStart = 0;
            this.WritePostTextBox.ShortcutsEnabled = true;
            this.WritePostTextBox.Size = new System.Drawing.Size(405, 80);
            this.WritePostTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.WritePostTextBox.TabIndex = 53;
            this.WritePostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WritePostTextBox.TextMarginBottom = 0;
            this.WritePostTextBox.TextMarginLeft = 3;
            this.WritePostTextBox.TextMarginTop = 5;
            this.WritePostTextBox.TextPlaceholder = "Write something...";
            this.WritePostTextBox.UseSystemPasswordChar = false;
            this.WritePostTextBox.WordWrap = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.bunifuPanel1.BorderRadius = 15;
            this.bunifuPanel1.BorderThickness = 3;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 179);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(480, 26);
            this.bunifuPanel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(23, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "---------------------------  Latest Posts ---------------------------";
            // 
            // FeedError
            // 
            this.FeedError.Controls.Add(this.FeedLoader);
            this.FeedError.Controls.Add(this.RetryFeedButton);
            this.FeedError.Controls.Add(this.label3);
            this.FeedError.Controls.Add(this.label2);
            this.FeedError.Location = new System.Drawing.Point(0, 212);
            this.FeedError.Name = "FeedError";
            this.FeedError.Size = new System.Drawing.Size(495, 600);
            this.FeedError.TabIndex = 55;
            this.FeedError.Visible = false;
            // 
            // FeedLoader
            // 
            this.FeedLoader.Controls.Add(this.pictureBox1);
            this.FeedLoader.Controls.Add(this.PostBodyLabel);
            this.FeedLoader.Location = new System.Drawing.Point(1, 0);
            this.FeedLoader.Name = "FeedLoader";
            this.FeedLoader.Size = new System.Drawing.Size(495, 600);
            this.FeedLoader.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // PostBodyLabel
            // 
            this.PostBodyLabel.AutoSize = true;
            this.PostBodyLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostBodyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.PostBodyLabel.Location = new System.Drawing.Point(205, 111);
            this.PostBodyLabel.MaximumSize = new System.Drawing.Size(442, 400);
            this.PostBodyLabel.Name = "PostBodyLabel";
            this.PostBodyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostBodyLabel.Size = new System.Drawing.Size(102, 15);
            this.PostBodyLabel.TabIndex = 58;
            this.PostBodyLabel.Text = "Getting posts...";
            // 
            // RetryFeedButton
            // 
            this.RetryFeedButton.AutoSize = true;
            this.RetryFeedButton.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryFeedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryFeedButton.Location = new System.Drawing.Point(235, 129);
            this.RetryFeedButton.MaximumSize = new System.Drawing.Size(442, 400);
            this.RetryFeedButton.Name = "RetryFeedButton";
            this.RetryFeedButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RetryFeedButton.Size = new System.Drawing.Size(42, 15);
            this.RetryFeedButton.TabIndex = 60;
            this.RetryFeedButton.Text = "Retry";
            this.RetryFeedButton.Click += new System.EventHandler(this.RetryFeedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(227, 58);
            this.label3.MaximumSize = new System.Drawing.Size(442, 400);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(59, 41);
            this.label3.TabIndex = 59;
            this.label3.Text = "❌";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(180, 111);
            this.label2.MaximumSize = new System.Drawing.Size(442, 400);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Connection Timed Out";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.bunifuPanel2.BorderRadius = 15;
            this.bunifuPanel2.BorderThickness = 3;
            this.bunifuPanel2.Controls.Add(this.label17);
            this.bunifuPanel2.Location = new System.Drawing.Point(520, 17);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(312, 39);
            this.bunifuPanel2.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.label17.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.label17.Location = new System.Drawing.Point(49, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 23);
            this.label17.TabIndex = 3;
            this.label17.Text = "📢 School Announcements";
            // 
            // AnnouncementsFlowLayoutPanel
            // 
            this.AnnouncementsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AnnouncementsFlowLayoutPanel.Location = new System.Drawing.Point(520, 67);
            this.AnnouncementsFlowLayoutPanel.Name = "AnnouncementsFlowLayoutPanel";
            this.AnnouncementsFlowLayoutPanel.Size = new System.Drawing.Size(407, 547);
            this.AnnouncementsFlowLayoutPanel.TabIndex = 45;
            this.AnnouncementsFlowLayoutPanel.WrapContents = false;
            // 
            // AnnounceWorker
            // 
            this.AnnounceWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AnnounceWorker_DoWork);
            this.AnnounceWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AnnounceWorker_RunWorkerCompleted);
            // 
            // InsertPostWorker
            // 
            this.InsertPostWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InsertPostWorker_DoWork);
            this.InsertPostWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.InsertPostWorker_RunWorkerCompleted);
            // 
            // AnnounceTimer
            // 
            this.AnnounceTimer.Enabled = true;
            this.AnnounceTimer.Interval = 15000;
            this.AnnounceTimer.Tick += new System.EventHandler(this.AnnounceTimer_Tick);
            // 
            // NewPostUpdateTimer
            // 
            this.NewPostUpdateTimer.Enabled = true;
            this.NewPostUpdateTimer.Interval = 2000;
            this.NewPostUpdateTimer.Tick += new System.EventHandler(this.NewPostUpdateTimer_Tick);
            // 
            // FeedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.AnnouncementsFlowLayoutPanel);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.FeedError);
            this.Controls.Add(this.FeedLayoutPanel);
            this.Name = "FeedPanel";
            this.Size = new System.Drawing.Size(848, 640);
            this.FeedLayoutPanel.ResumeLayout(false);
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.FeedError.ResumeLayout(false);
            this.FeedError.PerformLayout();
            this.FeedLoader.ResumeLayout(false);
            this.FeedLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker DisplayPostWorker;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FlowLayoutPanel FeedLayoutPanel;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel6;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 PostButton;
        private Bunifu.UI.WinForms.BunifuTextBox WritePostTextBox;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel AnnouncementsFlowLayoutPanel;
        private System.ComponentModel.BackgroundWorker AnnounceWorker;
        private System.ComponentModel.BackgroundWorker InsertPostWorker;
        private System.Windows.Forms.Panel FeedError;
        private System.Windows.Forms.Label RetryFeedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PostBodyLabel;
        private System.Windows.Forms.Panel FeedLoader;
        private System.Windows.Forms.Timer AnnounceTimer;
        private System.Windows.Forms.Timer NewPostUpdateTimer;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPictureBox PostPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
