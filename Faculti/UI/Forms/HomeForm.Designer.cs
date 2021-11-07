
using System.Drawing;

namespace Faculti
{
    partial class HomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.TeacherHomeFormEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalendarNotif = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ChatNotif = new System.Windows.Forms.Label();
            this.GradesNotif = new System.Windows.Forms.Label();
            this.FeedNotif = new System.Windows.Forms.Label();
            this.LogOutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.CalendarButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ChatButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.GradesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.NewsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.HomeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeWorker = new System.ComponentModel.BackgroundWorker();
            this.FirstTimeCheckWorker = new System.ComponentModel.BackgroundWorker();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.NotifPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.NotifFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NothingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PageLabel = new System.Windows.Forms.Label();
            this.DateTimePanel = new System.Windows.Forms.Panel();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.DateTimePictureBox = new System.Windows.Forms.PictureBox();
            this.NotificationButton = new System.Windows.Forms.PictureBox();
            this.TopProfilePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MinimizeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Loader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label39 = new System.Windows.Forms.Label();
            this.NotifCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckNotifWorker = new System.ComponentModel.BackgroundWorker();
            this.ToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.NotifPanel.SuspendLayout();
            this.NotifFlowLayoutPanel.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.DateTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopProfilePictureBox)).BeginInit();
            this.Loader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherHomeFormEllipse
            // 
            this.TeacherHomeFormEllipse.ElipseRadius = 20;
            this.TeacherHomeFormEllipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalendarNotif);
            this.panel1.Controls.Add(this.LogoPictureBox);
            this.panel1.Controls.Add(this.ChatNotif);
            this.panel1.Controls.Add(this.GradesNotif);
            this.panel1.Controls.Add(this.FeedNotif);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.CalendarButton);
            this.panel1.Controls.Add(this.ChatButton);
            this.panel1.Controls.Add(this.GradesButton);
            this.panel1.Controls.Add(this.NewsButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 696);
            this.panel1.TabIndex = 0;
            this.ToolTip.SetToolTip(this.panel1, "");
            this.ToolTip.SetToolTipIcon(this.panel1, null);
            this.ToolTip.SetToolTipTitle(this.panel1, "");
            // 
            // CalendarNotif
            // 
            this.CalendarNotif.BackColor = System.Drawing.Color.Transparent;
            this.CalendarNotif.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.CalendarNotif.Location = new System.Drawing.Point(13, 366);
            this.CalendarNotif.Name = "CalendarNotif";
            this.CalendarNotif.Size = new System.Drawing.Size(25, 23);
            this.CalendarNotif.TabIndex = 23;
            this.CalendarNotif.Text = "•";
            this.CalendarNotif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.CalendarNotif, "");
            this.ToolTip.SetToolTipIcon(this.CalendarNotif, null);
            this.ToolTip.SetToolTipTitle(this.CalendarNotif, "");
            this.CalendarNotif.Visible = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Faculti.Properties.Resources.Asset_13;
            this.LogoPictureBox.Location = new System.Drawing.Point(34, 22);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(106, 37);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.LogoPictureBox, "");
            this.ToolTip.SetToolTipIcon(this.LogoPictureBox, null);
            this.ToolTip.SetToolTipTitle(this.LogoPictureBox, "");
            // 
            // ChatNotif
            // 
            this.ChatNotif.BackColor = System.Drawing.Color.Transparent;
            this.ChatNotif.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.ChatNotif.Location = new System.Drawing.Point(13, 306);
            this.ChatNotif.Name = "ChatNotif";
            this.ChatNotif.Size = new System.Drawing.Size(25, 23);
            this.ChatNotif.TabIndex = 22;
            this.ChatNotif.Text = "•";
            this.ChatNotif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.ChatNotif, "");
            this.ToolTip.SetToolTipIcon(this.ChatNotif, null);
            this.ToolTip.SetToolTipTitle(this.ChatNotif, "");
            this.ChatNotif.Visible = false;
            // 
            // GradesNotif
            // 
            this.GradesNotif.BackColor = System.Drawing.Color.Transparent;
            this.GradesNotif.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradesNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.GradesNotif.Location = new System.Drawing.Point(13, 247);
            this.GradesNotif.Name = "GradesNotif";
            this.GradesNotif.Size = new System.Drawing.Size(25, 23);
            this.GradesNotif.TabIndex = 21;
            this.GradesNotif.Text = "•";
            this.GradesNotif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.GradesNotif, "");
            this.ToolTip.SetToolTipIcon(this.GradesNotif, null);
            this.ToolTip.SetToolTipTitle(this.GradesNotif, "");
            this.GradesNotif.Visible = false;
            // 
            // FeedNotif
            // 
            this.FeedNotif.BackColor = System.Drawing.Color.Transparent;
            this.FeedNotif.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.FeedNotif.Location = new System.Drawing.Point(13, 187);
            this.FeedNotif.Name = "FeedNotif";
            this.FeedNotif.Size = new System.Drawing.Size(25, 23);
            this.FeedNotif.TabIndex = 20;
            this.FeedNotif.Text = "•";
            this.FeedNotif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.FeedNotif, "");
            this.ToolTip.SetToolTipIcon(this.FeedNotif, null);
            this.ToolTip.SetToolTipTitle(this.FeedNotif, "");
            this.FeedNotif.Visible = false;
            // 
            // LogOutButton
            // 
            this.LogOutButton.AllowAnimations = false;
            this.LogOutButton.AllowMouseEffects = true;
            this.LogOutButton.AllowToggling = false;
            this.LogOutButton.AnimationSpeed = 200;
            this.LogOutButton.AutoGenerateColors = false;
            this.LogOutButton.AutoRoundBorders = false;
            this.LogOutButton.AutoSizeLeftIcon = true;
            this.LogOutButton.AutoSizeRightIcon = true;
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.BackColor1 = System.Drawing.Color.White;
            this.LogOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton.BackgroundImage")));
            this.LogOutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogOutButton.ButtonText = "  🚪   Log Out";
            this.LogOutButton.ButtonTextMarginLeft = 0;
            this.LogOutButton.ColorContrastOnClick = 45;
            this.LogOutButton.ColorContrastOnHover = 45;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.LogOutButton.CustomizableEdges = borderEdges1;
            this.LogOutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogOutButton.DisabledBorderColor = System.Drawing.Color.White;
            this.LogOutButton.DisabledFillColor = System.Drawing.Color.White;
            this.LogOutButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.LogOutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.LogOutButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.LogOutButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogOutButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LogOutButton.IconMarginLeft = 11;
            this.LogOutButton.IconPadding = 10;
            this.LogOutButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogOutButton.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.LogOutButton.IconSize = 40;
            this.LogOutButton.IdleBorderColor = System.Drawing.Color.White;
            this.LogOutButton.IdleBorderRadius = 10;
            this.LogOutButton.IdleBorderThickness = 1;
            this.LogOutButton.IdleFillColor = System.Drawing.Color.White;
            this.LogOutButton.IdleIconLeftImage = null;
            this.LogOutButton.IdleIconRightImage = null;
            this.LogOutButton.IndicateFocus = false;
            this.LogOutButton.Location = new System.Drawing.Point(24, 630);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.OnDisabledState.BorderRadius = 10;
            this.LogOutButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogOutButton.OnDisabledState.BorderThickness = 1;
            this.LogOutButton.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.LogOutButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.LogOutButton.OnDisabledState.IconLeftImage = null;
            this.LogOutButton.OnDisabledState.IconRightImage = null;
            this.LogOutButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.onHoverState.BorderRadius = 10;
            this.LogOutButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogOutButton.onHoverState.BorderThickness = 1;
            this.LogOutButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.LogOutButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.LogOutButton.onHoverState.IconLeftImage = null;
            this.LogOutButton.onHoverState.IconRightImage = null;
            this.LogOutButton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.OnIdleState.BorderRadius = 10;
            this.LogOutButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogOutButton.OnIdleState.BorderThickness = 1;
            this.LogOutButton.OnIdleState.FillColor = System.Drawing.Color.White;
            this.LogOutButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.LogOutButton.OnIdleState.IconLeftImage = null;
            this.LogOutButton.OnIdleState.IconRightImage = null;
            this.LogOutButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.OnPressedState.BorderRadius = 10;
            this.LogOutButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogOutButton.OnPressedState.BorderThickness = 1;
            this.LogOutButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.LogOutButton.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(43)))), ((int)(((byte)(96)))));
            this.LogOutButton.OnPressedState.IconLeftImage = null;
            this.LogOutButton.OnPressedState.IconRightImage = null;
            this.LogOutButton.Size = new System.Drawing.Size(126, 39);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogOutButton.TextMarginLeft = 0;
            this.LogOutButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.LogOutButton, "");
            this.ToolTip.SetToolTipIcon(this.LogOutButton, null);
            this.ToolTip.SetToolTipTitle(this.LogOutButton, "");
            this.LogOutButton.UseDefaultRadiusAndThickness = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.AllowAnimations = false;
            this.CalendarButton.AllowMouseEffects = true;
            this.CalendarButton.AllowToggling = true;
            this.CalendarButton.AnimationSpeed = 200;
            this.CalendarButton.AutoGenerateColors = false;
            this.CalendarButton.AutoRoundBorders = false;
            this.CalendarButton.AutoSizeLeftIcon = true;
            this.CalendarButton.AutoSizeRightIcon = true;
            this.CalendarButton.BackColor = System.Drawing.Color.Transparent;
            this.CalendarButton.BackColor1 = System.Drawing.Color.White;
            this.CalendarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CalendarButton.BackgroundImage")));
            this.CalendarButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CalendarButton.ButtonText = "  📆   Calendar";
            this.CalendarButton.ButtonTextMarginLeft = 0;
            this.CalendarButton.ColorContrastOnClick = 45;
            this.CalendarButton.ColorContrastOnHover = 45;
            this.CalendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.CalendarButton.CustomizableEdges = borderEdges2;
            this.CalendarButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CalendarButton.DisabledBorderColor = System.Drawing.Color.White;
            this.CalendarButton.DisabledFillColor = System.Drawing.Color.White;
            this.CalendarButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.CalendarButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.CalendarButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.CalendarButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalendarButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CalendarButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CalendarButton.IconMarginLeft = 11;
            this.CalendarButton.IconPadding = 10;
            this.CalendarButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalendarButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CalendarButton.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.CalendarButton.IconSize = 40;
            this.CalendarButton.IdleBorderColor = System.Drawing.Color.White;
            this.CalendarButton.IdleBorderRadius = 10;
            this.CalendarButton.IdleBorderThickness = 1;
            this.CalendarButton.IdleFillColor = System.Drawing.Color.White;
            this.CalendarButton.IdleIconLeftImage = null;
            this.CalendarButton.IdleIconRightImage = null;
            this.CalendarButton.IndicateFocus = false;
            this.CalendarButton.Location = new System.Drawing.Point(24, 360);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.CalendarButton.OnDisabledState.BorderRadius = 10;
            this.CalendarButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CalendarButton.OnDisabledState.BorderThickness = 1;
            this.CalendarButton.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.CalendarButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.CalendarButton.OnDisabledState.IconLeftImage = null;
            this.CalendarButton.OnDisabledState.IconRightImage = null;
            this.CalendarButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.CalendarButton.onHoverState.BorderRadius = 10;
            this.CalendarButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CalendarButton.onHoverState.BorderThickness = 1;
            this.CalendarButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.CalendarButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CalendarButton.onHoverState.IconLeftImage = null;
            this.CalendarButton.onHoverState.IconRightImage = null;
            this.CalendarButton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.CalendarButton.OnIdleState.BorderRadius = 10;
            this.CalendarButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CalendarButton.OnIdleState.BorderThickness = 1;
            this.CalendarButton.OnIdleState.FillColor = System.Drawing.Color.White;
            this.CalendarButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.CalendarButton.OnIdleState.IconLeftImage = null;
            this.CalendarButton.OnIdleState.IconRightImage = null;
            this.CalendarButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CalendarButton.OnPressedState.BorderRadius = 10;
            this.CalendarButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CalendarButton.OnPressedState.BorderThickness = 1;
            this.CalendarButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CalendarButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CalendarButton.OnPressedState.IconLeftImage = null;
            this.CalendarButton.OnPressedState.IconRightImage = null;
            this.CalendarButton.Size = new System.Drawing.Size(126, 39);
            this.CalendarButton.TabIndex = 5;
            this.CalendarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalendarButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CalendarButton.TextMarginLeft = 0;
            this.CalendarButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.CalendarButton, "");
            this.ToolTip.SetToolTipIcon(this.CalendarButton, null);
            this.ToolTip.SetToolTipTitle(this.CalendarButton, "");
            this.CalendarButton.UseDefaultRadiusAndThickness = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            this.CalendarButton.MouseLeave += new System.EventHandler(this.CalendarButton_MouseLeave);
            this.CalendarButton.MouseHover += new System.EventHandler(this.CalendarButton_MouseHover);
            // 
            // ChatButton
            // 
            this.ChatButton.AllowAnimations = false;
            this.ChatButton.AllowMouseEffects = true;
            this.ChatButton.AllowToggling = true;
            this.ChatButton.AnimationSpeed = 200;
            this.ChatButton.AutoGenerateColors = false;
            this.ChatButton.AutoRoundBorders = false;
            this.ChatButton.AutoSizeLeftIcon = true;
            this.ChatButton.AutoSizeRightIcon = true;
            this.ChatButton.BackColor = System.Drawing.Color.Transparent;
            this.ChatButton.BackColor1 = System.Drawing.Color.White;
            this.ChatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChatButton.BackgroundImage")));
            this.ChatButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ChatButton.ButtonText = "  💬   Chat";
            this.ChatButton.ButtonTextMarginLeft = 0;
            this.ChatButton.ColorContrastOnClick = 45;
            this.ChatButton.ColorContrastOnHover = 45;
            this.ChatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.ChatButton.CustomizableEdges = borderEdges3;
            this.ChatButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChatButton.DisabledBorderColor = System.Drawing.Color.White;
            this.ChatButton.DisabledFillColor = System.Drawing.Color.White;
            this.ChatButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.ChatButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.ChatButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.ChatButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChatButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ChatButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ChatButton.IconMarginLeft = 11;
            this.ChatButton.IconPadding = 10;
            this.ChatButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChatButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ChatButton.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.ChatButton.IconSize = 40;
            this.ChatButton.IdleBorderColor = System.Drawing.Color.White;
            this.ChatButton.IdleBorderRadius = 10;
            this.ChatButton.IdleBorderThickness = 1;
            this.ChatButton.IdleFillColor = System.Drawing.Color.White;
            this.ChatButton.IdleIconLeftImage = null;
            this.ChatButton.IdleIconRightImage = null;
            this.ChatButton.IndicateFocus = false;
            this.ChatButton.Location = new System.Drawing.Point(24, 300);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.ChatButton.OnDisabledState.BorderRadius = 10;
            this.ChatButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ChatButton.OnDisabledState.BorderThickness = 1;
            this.ChatButton.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.ChatButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.ChatButton.OnDisabledState.IconLeftImage = null;
            this.ChatButton.OnDisabledState.IconRightImage = null;
            this.ChatButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.ChatButton.onHoverState.BorderRadius = 10;
            this.ChatButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ChatButton.onHoverState.BorderThickness = 1;
            this.ChatButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.ChatButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChatButton.onHoverState.IconLeftImage = null;
            this.ChatButton.onHoverState.IconRightImage = null;
            this.ChatButton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.ChatButton.OnIdleState.BorderRadius = 10;
            this.ChatButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ChatButton.OnIdleState.BorderThickness = 1;
            this.ChatButton.OnIdleState.FillColor = System.Drawing.Color.White;
            this.ChatButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.ChatButton.OnIdleState.IconLeftImage = null;
            this.ChatButton.OnIdleState.IconRightImage = null;
            this.ChatButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChatButton.OnPressedState.BorderRadius = 10;
            this.ChatButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ChatButton.OnPressedState.BorderThickness = 1;
            this.ChatButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChatButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ChatButton.OnPressedState.IconLeftImage = null;
            this.ChatButton.OnPressedState.IconRightImage = null;
            this.ChatButton.Size = new System.Drawing.Size(126, 39);
            this.ChatButton.TabIndex = 4;
            this.ChatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChatButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChatButton.TextMarginLeft = 0;
            this.ChatButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.ChatButton, "");
            this.ToolTip.SetToolTipIcon(this.ChatButton, null);
            this.ToolTip.SetToolTipTitle(this.ChatButton, "");
            this.ChatButton.UseDefaultRadiusAndThickness = true;
            this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
            this.ChatButton.MouseLeave += new System.EventHandler(this.ChatButton_MouseLeave);
            this.ChatButton.MouseHover += new System.EventHandler(this.ChatButton_MouseHover);
            // 
            // GradesButton
            // 
            this.GradesButton.AllowAnimations = false;
            this.GradesButton.AllowMouseEffects = true;
            this.GradesButton.AllowToggling = true;
            this.GradesButton.AnimationSpeed = 200;
            this.GradesButton.AutoGenerateColors = false;
            this.GradesButton.AutoRoundBorders = false;
            this.GradesButton.AutoSizeLeftIcon = true;
            this.GradesButton.AutoSizeRightIcon = true;
            this.GradesButton.BackColor = System.Drawing.Color.Transparent;
            this.GradesButton.BackColor1 = System.Drawing.Color.White;
            this.GradesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradesButton.BackgroundImage")));
            this.GradesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.GradesButton.ButtonText = "  ☑   Grades";
            this.GradesButton.ButtonTextMarginLeft = 0;
            this.GradesButton.ColorContrastOnClick = 45;
            this.GradesButton.ColorContrastOnHover = 45;
            this.GradesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.GradesButton.CustomizableEdges = borderEdges4;
            this.GradesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GradesButton.DisabledBorderColor = System.Drawing.Color.White;
            this.GradesButton.DisabledFillColor = System.Drawing.Color.White;
            this.GradesButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.GradesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.GradesButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.GradesButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GradesButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.GradesButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.GradesButton.IconMarginLeft = 11;
            this.GradesButton.IconPadding = 10;
            this.GradesButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GradesButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.GradesButton.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.GradesButton.IconSize = 40;
            this.GradesButton.IdleBorderColor = System.Drawing.Color.White;
            this.GradesButton.IdleBorderRadius = 10;
            this.GradesButton.IdleBorderThickness = 1;
            this.GradesButton.IdleFillColor = System.Drawing.Color.White;
            this.GradesButton.IdleIconLeftImage = null;
            this.GradesButton.IdleIconRightImage = null;
            this.GradesButton.IndicateFocus = false;
            this.GradesButton.Location = new System.Drawing.Point(24, 240);
            this.GradesButton.Name = "GradesButton";
            this.GradesButton.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.GradesButton.OnDisabledState.BorderRadius = 10;
            this.GradesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.GradesButton.OnDisabledState.BorderThickness = 1;
            this.GradesButton.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.GradesButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.GradesButton.OnDisabledState.IconLeftImage = null;
            this.GradesButton.OnDisabledState.IconRightImage = null;
            this.GradesButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.GradesButton.onHoverState.BorderRadius = 10;
            this.GradesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.GradesButton.onHoverState.BorderThickness = 1;
            this.GradesButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.GradesButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GradesButton.onHoverState.IconLeftImage = null;
            this.GradesButton.onHoverState.IconRightImage = null;
            this.GradesButton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.GradesButton.OnIdleState.BorderRadius = 10;
            this.GradesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.GradesButton.OnIdleState.BorderThickness = 1;
            this.GradesButton.OnIdleState.FillColor = System.Drawing.Color.White;
            this.GradesButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.GradesButton.OnIdleState.IconLeftImage = null;
            this.GradesButton.OnIdleState.IconRightImage = null;
            this.GradesButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GradesButton.OnPressedState.BorderRadius = 10;
            this.GradesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.GradesButton.OnPressedState.BorderThickness = 1;
            this.GradesButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GradesButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.GradesButton.OnPressedState.IconLeftImage = null;
            this.GradesButton.OnPressedState.IconRightImage = null;
            this.GradesButton.Size = new System.Drawing.Size(126, 39);
            this.GradesButton.TabIndex = 3;
            this.GradesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GradesButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.GradesButton.TextMarginLeft = 0;
            this.GradesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.GradesButton, "");
            this.ToolTip.SetToolTipIcon(this.GradesButton, null);
            this.ToolTip.SetToolTipTitle(this.GradesButton, "");
            this.GradesButton.UseDefaultRadiusAndThickness = true;
            this.GradesButton.Click += new System.EventHandler(this.GradesButton_Click);
            this.GradesButton.MouseLeave += new System.EventHandler(this.GradesButton_MouseLeave);
            this.GradesButton.MouseHover += new System.EventHandler(this.GradesButton_MouseHover);
            // 
            // NewsButton
            // 
            this.NewsButton.AllowAnimations = false;
            this.NewsButton.AllowMouseEffects = true;
            this.NewsButton.AllowToggling = true;
            this.NewsButton.AnimationSpeed = 200;
            this.NewsButton.AutoGenerateColors = false;
            this.NewsButton.AutoRoundBorders = false;
            this.NewsButton.AutoSizeLeftIcon = true;
            this.NewsButton.AutoSizeRightIcon = true;
            this.NewsButton.BackColor = System.Drawing.Color.Transparent;
            this.NewsButton.BackColor1 = System.Drawing.Color.White;
            this.NewsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewsButton.BackgroundImage")));
            this.NewsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.NewsButton.ButtonText = "  📄   Feed";
            this.NewsButton.ButtonTextMarginLeft = 0;
            this.NewsButton.ColorContrastOnClick = 45;
            this.NewsButton.ColorContrastOnHover = 45;
            this.NewsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.NewsButton.CustomizableEdges = borderEdges5;
            this.NewsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NewsButton.DisabledBorderColor = System.Drawing.Color.White;
            this.NewsButton.DisabledFillColor = System.Drawing.Color.White;
            this.NewsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.NewsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.NewsButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.NewsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.NewsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.NewsButton.IconMarginLeft = 11;
            this.NewsButton.IconPadding = 10;
            this.NewsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewsButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.NewsButton.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.NewsButton.IconSize = 40;
            this.NewsButton.IdleBorderColor = System.Drawing.Color.White;
            this.NewsButton.IdleBorderRadius = 10;
            this.NewsButton.IdleBorderThickness = 1;
            this.NewsButton.IdleFillColor = System.Drawing.Color.White;
            this.NewsButton.IdleIconLeftImage = null;
            this.NewsButton.IdleIconRightImage = null;
            this.NewsButton.IndicateFocus = false;
            this.NewsButton.Location = new System.Drawing.Point(24, 180);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.NewsButton.OnDisabledState.BorderRadius = 10;
            this.NewsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.NewsButton.OnDisabledState.BorderThickness = 1;
            this.NewsButton.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.NewsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.NewsButton.OnDisabledState.IconLeftImage = null;
            this.NewsButton.OnDisabledState.IconRightImage = null;
            this.NewsButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.NewsButton.onHoverState.BorderRadius = 10;
            this.NewsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.NewsButton.onHoverState.BorderThickness = 1;
            this.NewsButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.NewsButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewsButton.onHoverState.IconLeftImage = null;
            this.NewsButton.onHoverState.IconRightImage = null;
            this.NewsButton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.NewsButton.OnIdleState.BorderRadius = 10;
            this.NewsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.NewsButton.OnIdleState.BorderThickness = 1;
            this.NewsButton.OnIdleState.FillColor = System.Drawing.Color.White;
            this.NewsButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.NewsButton.OnIdleState.IconLeftImage = null;
            this.NewsButton.OnIdleState.IconRightImage = null;
            this.NewsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewsButton.OnPressedState.BorderRadius = 10;
            this.NewsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.NewsButton.OnPressedState.BorderThickness = 1;
            this.NewsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewsButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.NewsButton.OnPressedState.IconLeftImage = null;
            this.NewsButton.OnPressedState.IconRightImage = null;
            this.NewsButton.Size = new System.Drawing.Size(126, 39);
            this.NewsButton.TabIndex = 2;
            this.NewsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewsButton.TextMarginLeft = 0;
            this.NewsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.NewsButton, "");
            this.ToolTip.SetToolTipIcon(this.NewsButton, null);
            this.ToolTip.SetToolTipTitle(this.NewsButton, "");
            this.NewsButton.UseDefaultRadiusAndThickness = true;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            this.NewsButton.MouseLeave += new System.EventHandler(this.NewsButton_MouseLeave);
            this.NewsButton.MouseHover += new System.EventHandler(this.NewsButton_MouseHover);
            // 
            // HomeButton
            // 
            this.HomeButton.AllowAnimations = false;
            this.HomeButton.AllowMouseEffects = true;
            this.HomeButton.AllowToggling = true;
            this.HomeButton.AnimationSpeed = 1;
            this.HomeButton.AutoGenerateColors = false;
            this.HomeButton.AutoRoundBorders = false;
            this.HomeButton.AutoSizeLeftIcon = true;
            this.HomeButton.AutoSizeRightIcon = true;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackColor1 = System.Drawing.Color.White;
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.HomeButton.ButtonText = "  🏚️   Home";
            this.HomeButton.ButtonTextMarginLeft = 0;
            this.HomeButton.ColorContrastOnClick = 0;
            this.HomeButton.ColorContrastOnHover = 0;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.HomeButton.CustomizableEdges = borderEdges6;
            this.HomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeButton.DisabledBorderColor = System.Drawing.Color.White;
            this.HomeButton.DisabledFillColor = System.Drawing.Color.White;
            this.HomeButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.HomeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.HomeButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.HomeButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.HomeButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.HomeButton.IconMarginLeft = 11;
            this.HomeButton.IconPadding = 10;
            this.HomeButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.HomeButton.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.HomeButton.IconSize = 40;
            this.HomeButton.IdleBorderColor = System.Drawing.Color.White;
            this.HomeButton.IdleBorderRadius = 10;
            this.HomeButton.IdleBorderThickness = 1;
            this.HomeButton.IdleFillColor = System.Drawing.Color.White;
            this.HomeButton.IdleIconLeftImage = null;
            this.HomeButton.IdleIconRightImage = null;
            this.HomeButton.IndicateFocus = false;
            this.HomeButton.Location = new System.Drawing.Point(24, 119);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.HomeButton.OnDisabledState.BorderRadius = 10;
            this.HomeButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.HomeButton.OnDisabledState.BorderThickness = 1;
            this.HomeButton.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.HomeButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.HomeButton.OnDisabledState.IconLeftImage = null;
            this.HomeButton.OnDisabledState.IconRightImage = null;
            this.HomeButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.HomeButton.onHoverState.BorderRadius = 10;
            this.HomeButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.HomeButton.onHoverState.BorderThickness = 1;
            this.HomeButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.HomeButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HomeButton.onHoverState.IconLeftImage = null;
            this.HomeButton.onHoverState.IconRightImage = null;
            this.HomeButton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.HomeButton.OnIdleState.BorderRadius = 10;
            this.HomeButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.HomeButton.OnIdleState.BorderThickness = 1;
            this.HomeButton.OnIdleState.FillColor = System.Drawing.Color.White;
            this.HomeButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.HomeButton.OnIdleState.IconLeftImage = null;
            this.HomeButton.OnIdleState.IconRightImage = null;
            this.HomeButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HomeButton.OnPressedState.BorderRadius = 10;
            this.HomeButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.HomeButton.OnPressedState.BorderThickness = 1;
            this.HomeButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HomeButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.HomeButton.OnPressedState.IconLeftImage = null;
            this.HomeButton.OnPressedState.IconRightImage = null;
            this.HomeButton.Size = new System.Drawing.Size(126, 39);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.HomeButton.TextMarginLeft = 0;
            this.HomeButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.HomeButton, "");
            this.ToolTip.SetToolTipIcon(this.HomeButton, null);
            this.ToolTip.SetToolTipTitle(this.HomeButton, "");
            this.HomeButton.UseDefaultRadiusAndThickness = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.HomeButton.MouseLeave += new System.EventHandler(this.HomeButton_MouseLeave);
            this.HomeButton.MouseHover += new System.EventHandler(this.HomeButton_MouseHover);
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Enabled = true;
            this.DateTimeTimer.Interval = 3000;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // HomeWorker
            // 
            this.HomeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HomeWorker_DoWork);
            this.HomeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.HomeWorker_RunWorkerCompleted);
            // 
            // FirstTimeCheckWorker
            // 
            this.FirstTimeCheckWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FirstTimeCheckWorker_DoWork);
            this.FirstTimeCheckWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FirstTimeCheckWorker_RunWorkerCompleted);
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderRadius = 3;
            this.MainPanel.BorderThickness = 1;
            this.MainPanel.Controls.Add(this.NotifPanel);
            this.MainPanel.Controls.Add(this.bunifuShadowPanel1);
            this.MainPanel.Controls.Add(this.Loader);
            this.MainPanel.Location = new System.Drawing.Point(175, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShowBorders = true;
            this.MainPanel.Size = new System.Drawing.Size(862, 696);
            this.MainPanel.TabIndex = 1;
            this.ToolTip.SetToolTip(this.MainPanel, "");
            this.ToolTip.SetToolTipIcon(this.MainPanel, null);
            this.ToolTip.SetToolTipTitle(this.MainPanel, "");
            // 
            // NotifPanel
            // 
            this.NotifPanel.AutoSize = true;
            this.NotifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.NotifPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.NotifPanel.BorderRadius = 10;
            this.NotifPanel.BorderThickness = 0;
            this.NotifPanel.Controls.Add(this.bunifuVScrollBar1);
            this.NotifPanel.Controls.Add(this.label1);
            this.NotifPanel.Controls.Add(this.NotifFlowLayoutPanel);
            this.NotifPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.NotifPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.NotifPanel.Location = new System.Drawing.Point(508, 52);
            this.NotifPanel.MaximumSize = new System.Drawing.Size(305, 333);
            this.NotifPanel.MinimumSize = new System.Drawing.Size(295, 100);
            this.NotifPanel.Name = "NotifPanel";
            this.NotifPanel.PanelColor = System.Drawing.Color.White;
            this.NotifPanel.PanelColor2 = System.Drawing.Color.White;
            this.NotifPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.NotifPanel.ShadowDept = 2;
            this.NotifPanel.ShadowDepth = 1;
            this.NotifPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.NotifPanel.ShadowTopLeftVisible = false;
            this.NotifPanel.Size = new System.Drawing.Size(305, 104);
            this.NotifPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.NotifPanel.TabIndex = 61;
            this.ToolTip.SetToolTip(this.NotifPanel, "");
            this.ToolTip.SetToolTipIcon(this.NotifPanel, null);
            this.ToolTip.SetToolTipTitle(this.NotifPanel, "");
            this.NotifPanel.Visible = false;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.NotifFlowLayoutPanel;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.BorderRadius = 8;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(278, -159);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(10, 19);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 61;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.ThumbLength = 18;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.ToolTip.SetToolTip(this.bunifuVScrollBar1, "");
            this.ToolTip.SetToolTipIcon(this.bunifuVScrollBar1, null);
            this.ToolTip.SetToolTipTitle(this.bunifuVScrollBar1, "");
            this.bunifuVScrollBar1.Value = 0;
            // 
            // NotifFlowLayoutPanel
            // 
            this.NotifFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NotifFlowLayoutPanel.AutoSize = true;
            this.NotifFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.NotifFlowLayoutPanel.Controls.Add(this.NothingLabel);
            this.NotifFlowLayoutPanel.Location = new System.Drawing.Point(21, 47);
            this.NotifFlowLayoutPanel.MaximumSize = new System.Drawing.Size(268, 265);
            this.NotifFlowLayoutPanel.MinimumSize = new System.Drawing.Size(268, 40);
            this.NotifFlowLayoutPanel.Name = "NotifFlowLayoutPanel";
            this.NotifFlowLayoutPanel.Size = new System.Drawing.Size(268, 40);
            this.NotifFlowLayoutPanel.TabIndex = 0;
            this.ToolTip.SetToolTip(this.NotifFlowLayoutPanel, "");
            this.ToolTip.SetToolTipIcon(this.NotifFlowLayoutPanel, null);
            this.ToolTip.SetToolTipTitle(this.NotifFlowLayoutPanel, "");
            // 
            // NothingLabel
            // 
            this.NothingLabel.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NothingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.NothingLabel.Location = new System.Drawing.Point(3, 0);
            this.NothingLabel.Name = "NothingLabel";
            this.NothingLabel.Size = new System.Drawing.Size(264, 30);
            this.NothingLabel.TabIndex = 2;
            this.NothingLabel.Text = "Nothing to show here.";
            this.NothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip.SetToolTip(this.NothingLabel, "");
            this.ToolTip.SetToolTipIcon(this.NothingLabel, null);
            this.ToolTip.SetToolTipTitle(this.NothingLabel, "");
            this.NothingLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notifications";
            this.ToolTip.SetToolTip(this.label1, "");
            this.ToolTip.SetToolTipIcon(this.label1, null);
            this.ToolTip.SetToolTipTitle(this.label1, "");
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.CloseButton);
            this.bunifuShadowPanel1.Controls.Add(this.PageLabel);
            this.bunifuShadowPanel1.Controls.Add(this.DateTimePanel);
            this.bunifuShadowPanel1.Controls.Add(this.NotificationButton);
            this.bunifuShadowPanel1.Controls.Add(this.TopProfilePictureBox);
            this.bunifuShadowPanel1.Controls.Add(this.MinimizeButton);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(-26, 4);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Dropped;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(955, 58);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 31;
            this.ToolTip.SetToolTip(this.bunifuShadowPanel1, "");
            this.ToolTip.SetToolTipIcon(this.bunifuShadowPanel1, null);
            this.ToolTip.SetToolTipTitle(this.bunifuShadowPanel1, "");
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveImage = null;
            this.CloseButton.AllowAnimations = true;
            this.CloseButton.AllowBuffering = false;
            this.CloseButton.AllowToggling = false;
            this.CloseButton.AllowZooming = false;
            this.CloseButton.AllowZoomingOnFocus = false;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.ErrorImage")));
            this.CloseButton.FadeWhenInactive = true;
            this.CloseButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CloseButton.Image = global::Faculti.Properties.Resources.close_button;
            this.CloseButton.ImageActive = null;
            this.CloseButton.ImageLocation = null;
            this.CloseButton.ImageMargin = 0;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(846, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = false;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 45;
            this.ToolTip.SetToolTip(this.CloseButton, "");
            this.ToolTip.SetToolTipIcon(this.CloseButton, null);
            this.CloseButton.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.CloseButton, "");
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.PageLabel.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.PageLabel.Location = new System.Drawing.Point(43, 8);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(72, 30);
            this.PageLabel.TabIndex = 44;
            this.PageLabel.Text = "Home";
            this.ToolTip.SetToolTip(this.PageLabel, "");
            this.ToolTip.SetToolTipIcon(this.PageLabel, null);
            this.ToolTip.SetToolTipTitle(this.PageLabel, "");
            // 
            // DateTimePanel
            // 
            this.DateTimePanel.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePanel.Controls.Add(this.DateTimeLabel);
            this.DateTimePanel.Controls.Add(this.DateTimePictureBox);
            this.DateTimePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimePanel.Location = new System.Drawing.Point(355, 7);
            this.DateTimePanel.Name = "DateTimePanel";
            this.DateTimePanel.Size = new System.Drawing.Size(203, 31);
            this.DateTimePanel.TabIndex = 42;
            this.ToolTip.SetToolTip(this.DateTimePanel, "");
            this.ToolTip.SetToolTipIcon(this.DateTimePanel, null);
            this.ToolTip.SetToolTipTitle(this.DateTimePanel, "");
            this.DateTimePanel.MouseLeave += new System.EventHandler(this.DateTimePanel_MouseLeave);
            this.DateTimePanel.MouseHover += new System.EventHandler(this.DateTimePanel_MouseHover);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimeLabel.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.DateTimeLabel.Location = new System.Drawing.Point(38, 9);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(143, 13);
            this.DateTimeLabel.TabIndex = 9;
            this.DateTimeLabel.Text = "Wed • Oct 4 • 11:30AM";
            this.ToolTip.SetToolTip(this.DateTimeLabel, "");
            this.ToolTip.SetToolTipIcon(this.DateTimeLabel, null);
            this.ToolTip.SetToolTipTitle(this.DateTimeLabel, "");
            this.DateTimeLabel.MouseLeave += new System.EventHandler(this.DateTimePanel_MouseLeave);
            this.DateTimeLabel.MouseHover += new System.EventHandler(this.DateTimePanel_MouseHover);
            // 
            // DateTimePictureBox
            // 
            this.DateTimePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DateTimePictureBox.Image")));
            this.DateTimePictureBox.Location = new System.Drawing.Point(5, 1);
            this.DateTimePictureBox.Name = "DateTimePictureBox";
            this.DateTimePictureBox.Size = new System.Drawing.Size(33, 30);
            this.DateTimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DateTimePictureBox.TabIndex = 8;
            this.DateTimePictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.DateTimePictureBox, "");
            this.ToolTip.SetToolTipIcon(this.DateTimePictureBox, null);
            this.ToolTip.SetToolTipTitle(this.DateTimePictureBox, "");
            this.DateTimePictureBox.MouseLeave += new System.EventHandler(this.DateTimePanel_MouseLeave);
            this.DateTimePictureBox.MouseHover += new System.EventHandler(this.DateTimePanel_MouseHover);
            // 
            // NotificationButton
            // 
            this.NotificationButton.BackColor = System.Drawing.Color.Transparent;
            this.NotificationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotificationButton.Image = global::Faculti.Properties.Resources.notif_idle;
            this.NotificationButton.Location = new System.Drawing.Point(704, 8);
            this.NotificationButton.Name = "NotificationButton";
            this.NotificationButton.Size = new System.Drawing.Size(33, 30);
            this.NotificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotificationButton.TabIndex = 41;
            this.NotificationButton.TabStop = false;
            this.ToolTip.SetToolTip(this.NotificationButton, "");
            this.ToolTip.SetToolTipIcon(this.NotificationButton, null);
            this.ToolTip.SetToolTipTitle(this.NotificationButton, "");
            this.NotificationButton.Click += new System.EventHandler(this.NotificationButton_Click);
            this.NotificationButton.MouseLeave += new System.EventHandler(this.NotificationButton_MouseLeave);
            this.NotificationButton.MouseHover += new System.EventHandler(this.NotificationButton_MouseHover);
            // 
            // TopProfilePictureBox
            // 
            this.TopProfilePictureBox.AllowFocused = false;
            this.TopProfilePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopProfilePictureBox.AutoSizeHeight = false;
            this.TopProfilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TopProfilePictureBox.BorderRadius = 17;
            this.TopProfilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopProfilePictureBox.Image = global::Faculti.Properties.Resources.default_profile;
            this.TopProfilePictureBox.IsCircle = false;
            this.TopProfilePictureBox.Location = new System.Drawing.Point(751, 6);
            this.TopProfilePictureBox.Name = "TopProfilePictureBox";
            this.TopProfilePictureBox.Size = new System.Drawing.Size(35, 35);
            this.TopProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TopProfilePictureBox.TabIndex = 40;
            this.TopProfilePictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.TopProfilePictureBox, "Change Picture");
            this.ToolTip.SetToolTipIcon(this.TopProfilePictureBox, null);
            this.ToolTip.SetToolTipTitle(this.TopProfilePictureBox, "");
            this.TopProfilePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.TopProfilePictureBox.Click += new System.EventHandler(this.TopProfilePictureBox_Click);
            this.TopProfilePictureBox.MouseLeave += new System.EventHandler(this.TopProfilePictureBox_MouseLeave);
            this.TopProfilePictureBox.MouseHover += new System.EventHandler(this.TopProfilePictureBox_MouseHover);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.ActiveImage = null;
            this.MinimizeButton.AllowAnimations = true;
            this.MinimizeButton.AllowBuffering = false;
            this.MinimizeButton.AllowToggling = false;
            this.MinimizeButton.AllowZooming = false;
            this.MinimizeButton.AllowZoomingOnFocus = false;
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.ErrorImage")));
            this.MinimizeButton.FadeWhenInactive = true;
            this.MinimizeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.MinimizeButton.Image = global::Faculti.Properties.Resources.minimize_button;
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.ImageLocation = null;
            this.MinimizeButton.ImageMargin = 0;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MinimizeButton.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.MinimizeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.InitialImage")));
            this.MinimizeButton.Location = new System.Drawing.Point(807, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0;
            this.MinimizeButton.ShowActiveImage = true;
            this.MinimizeButton.ShowCursorChanges = true;
            this.MinimizeButton.ShowImageBorders = false;
            this.MinimizeButton.ShowSizeMarkers = false;
            this.MinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeButton.TabIndex = 38;
            this.ToolTip.SetToolTip(this.MinimizeButton, "");
            this.ToolTip.SetToolTipIcon(this.MinimizeButton, null);
            this.MinimizeButton.ToolTipText = "";
            this.ToolTip.SetToolTipTitle(this.MinimizeButton, "");
            this.MinimizeButton.WaitOnLoad = false;
            this.MinimizeButton.Zoom = 0;
            this.MinimizeButton.ZoomSpeed = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Loader
            // 
            this.Loader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Loader.Controls.Add(this.pictureBox1);
            this.Loader.Controls.Add(this.label39);
            this.Loader.Location = new System.Drawing.Point(7, 68);
            this.Loader.Name = "Loader";
            this.Loader.Size = new System.Drawing.Size(853, 629);
            this.Loader.TabIndex = 32;
            this.ToolTip.SetToolTip(this.Loader, "");
            this.ToolTip.SetToolTipIcon(this.Loader, null);
            this.ToolTip.SetToolTipTitle(this.Loader, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox1, "");
            this.ToolTip.SetToolTipIcon(this.pictureBox1, null);
            this.ToolTip.SetToolTipTitle(this.pictureBox1, "");
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.label39.Location = new System.Drawing.Point(386, 331);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(80, 15);
            this.label39.TabIndex = 12;
            this.label39.Text = "Please wait";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip.SetToolTip(this.label39, "");
            this.ToolTip.SetToolTipIcon(this.label39, null);
            this.ToolTip.SetToolTipTitle(this.label39, "");
            // 
            // NotifCheckTimer
            // 
            this.NotifCheckTimer.Interval = 5000;
            this.NotifCheckTimer.Tick += new System.EventHandler(this.NotifCheckTimer_Tick);
            // 
            // CheckNotifWorker
            // 
            this.CheckNotifWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckNotifWorker_DoWork);
            this.CheckNotifWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CheckNotifWorker_RunWorkerCompleted);
            // 
            // ToolTip
            // 
            this.ToolTip.Active = true;
            this.ToolTip.AlignTextWithTitle = false;
            this.ToolTip.AllowAutoClose = false;
            this.ToolTip.AllowFading = true;
            this.ToolTip.AutoCloseDuration = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.White;
            this.ToolTip.BorderColor = System.Drawing.Color.White;
            this.ToolTip.ClickToShowDisplayControl = false;
            this.ToolTip.ConvertNewlinesToBreakTags = true;
            this.ToolTip.DisplayControl = null;
            this.ToolTip.EntryAnimationSpeed = 350;
            this.ToolTip.ExitAnimationSpeed = 200;
            this.ToolTip.GenerateAutoCloseDuration = false;
            this.ToolTip.IconMargin = 6;
            this.ToolTip.InitialDelay = 0;
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Opacity = 1D;
            this.ToolTip.OverrideToolTipTitles = false;
            this.ToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ShowBorders = false;
            this.ToolTip.ShowIcons = true;
            this.ToolTip.ShowShadows = true;
            this.ToolTip.Tag = null;
            this.ToolTip.TextFont = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ToolTip.TextMargin = 2;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.ToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ToolTip.ToolTipTitle = null;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculti";
            this.Load += new System.EventHandler(this.ParentHomeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.NotifPanel.ResumeLayout(false);
            this.NotifPanel.PerformLayout();
            this.NotifFlowLayoutPanel.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.DateTimePanel.ResumeLayout(false);
            this.DateTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopProfilePictureBox)).EndInit();
            this.Loader.ResumeLayout(false);
            this.Loader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse TeacherHomeFormEllipse;
        private Bunifu.UI.WinForms.BunifuPanel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LogOutButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 CalendarButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 ChatButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 GradesButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 NewsButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 HomeButton;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Label CalendarNotif;
        private System.Windows.Forms.Label ChatNotif;
        private System.Windows.Forms.Label GradesNotif;
        private System.Windows.Forms.Label FeedNotif;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Panel DateTimePanel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.PictureBox DateTimePictureBox;
        private System.Windows.Forms.PictureBox NotificationButton;
        private Bunifu.UI.WinForms.BunifuPictureBox TopProfilePictureBox;
        private Bunifu.UI.WinForms.BunifuImageButton MinimizeButton;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private System.Windows.Forms.Panel Loader;
        private System.Windows.Forms.Label label39;
        private System.ComponentModel.BackgroundWorker HomeWorker;
        private System.ComponentModel.BackgroundWorker FirstTimeCheckWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuShadowPanel NotifPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel NotifFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.Timer NotifCheckTimer;
        private System.ComponentModel.BackgroundWorker CheckNotifWorker;
        private System.Windows.Forms.Label NothingLabel;
        private Bunifu.UI.WinForms.BunifuToolTip ToolTip;
    }
}