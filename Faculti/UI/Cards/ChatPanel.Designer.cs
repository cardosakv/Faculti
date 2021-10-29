
namespace Faculti.UI.Cards
{
    partial class ChatPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatPanel));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.ChatHeadFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MessageError = new System.Windows.Forms.Panel();
            this.RetryMessageButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChatContainer = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.NoMessageSelectedPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.MessageLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label39 = new System.Windows.Forms.Label();
            this.MessageTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ContactActiveStatusLabel = new System.Windows.Forms.Label();
            this.ContactName = new System.Windows.Forms.Label();
            this.AttachFileButton = new System.Windows.Forms.Label();
            this.ChatMessagesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BeginningBorder = new System.Windows.Forms.Label();
            this.EmptyPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Label();
            this.SearchPeopleTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.GetContactsWorker = new System.ComponentModel.BackgroundWorker();
            this.GetMessagesWorker = new System.ComponentModel.BackgroundWorker();
            this.SendMessageWorker = new System.ComponentModel.BackgroundWorker();
            this.UpdateMessagesWorker = new System.ComponentModel.BackgroundWorker();
            this.HiddenLabel = new System.Windows.Forms.Label();
            this.ConstantUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.ConstantUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SendImageWorker = new System.ComponentModel.BackgroundWorker();
            this.MessageError.SuspendLayout();
            this.ChatContainer.SuspendLayout();
            this.NoMessageSelectedPanel.SuspendLayout();
            this.MessageLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChatMessagesFlowLayoutPanel.SuspendLayout();
            this.EmptyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatHeadFlowLayoutPanel
            // 
            this.ChatHeadFlowLayoutPanel.AutoScroll = true;
            this.ChatHeadFlowLayoutPanel.Location = new System.Drawing.Point(14, 75);
            this.ChatHeadFlowLayoutPanel.Name = "ChatHeadFlowLayoutPanel";
            this.ChatHeadFlowLayoutPanel.Size = new System.Drawing.Size(379, 529);
            this.ChatHeadFlowLayoutPanel.TabIndex = 0;
            // 
            // MessageError
            // 
            this.MessageError.Controls.Add(this.RetryMessageButton);
            this.MessageError.Controls.Add(this.label3);
            this.MessageError.Controls.Add(this.label2);
            this.MessageError.Location = new System.Drawing.Point(0, 0);
            this.MessageError.Name = "MessageError";
            this.MessageError.Size = new System.Drawing.Size(567, 480);
            this.MessageError.TabIndex = 63;
            this.MessageError.Visible = false;
            // 
            // RetryMessageButton
            // 
            this.RetryMessageButton.AutoSize = true;
            this.RetryMessageButton.BackColor = System.Drawing.Color.White;
            this.RetryMessageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RetryMessageButton.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryMessageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryMessageButton.Location = new System.Drawing.Point(262, 266);
            this.RetryMessageButton.MaximumSize = new System.Drawing.Size(442, 400);
            this.RetryMessageButton.Name = "RetryMessageButton";
            this.RetryMessageButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RetryMessageButton.Size = new System.Drawing.Size(42, 15);
            this.RetryMessageButton.TabIndex = 60;
            this.RetryMessageButton.Text = "Retry";
            this.RetryMessageButton.Click += new System.EventHandler(this.RetryMessageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gotham", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(255, 193);
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
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(207, 247);
            this.label2.MaximumSize = new System.Drawing.Size(442, 400);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Connection Timed Out";
            // 
            // ChatContainer
            // 
            this.ChatContainer.BackColor = System.Drawing.Color.Transparent;
            this.ChatContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ChatContainer.BorderRadius = 15;
            this.ChatContainer.BorderThickness = 0;
            this.ChatContainer.Controls.Add(this.NoMessageSelectedPanel);
            this.ChatContainer.Controls.Add(this.bunifuSeparator1);
            this.ChatContainer.Controls.Add(this.MessageLoader);
            this.ChatContainer.Controls.Add(this.MessageTextBox);
            this.ChatContainer.Controls.Add(this.ContactActiveStatusLabel);
            this.ChatContainer.Controls.Add(this.ContactName);
            this.ChatContainer.Controls.Add(this.AttachFileButton);
            this.ChatContainer.Controls.Add(this.ChatMessagesFlowLayoutPanel);
            this.ChatContainer.Controls.Add(this.SendButton);
            this.ChatContainer.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.ChatContainer.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.ChatContainer.Location = new System.Drawing.Point(249, 18);
            this.ChatContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ChatContainer.Name = "ChatContainer";
            this.ChatContainer.PanelColor = System.Drawing.Color.White;
            this.ChatContainer.PanelColor2 = System.Drawing.Color.White;
            this.ChatContainer.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.ChatContainer.ShadowDept = 2;
            this.ChatContainer.ShadowDepth = 3;
            this.ChatContainer.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.ChatContainer.ShadowTopLeftVisible = false;
            this.ChatContainer.Size = new System.Drawing.Size(584, 601);
            this.ChatContainer.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.ChatContainer.TabIndex = 31;
            this.ChatContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ChatContainer_ControlAdded);
            // 
            // NoMessageSelectedPanel
            // 
            this.NoMessageSelectedPanel.BackColor = System.Drawing.Color.White;
            this.NoMessageSelectedPanel.Controls.Add(this.label6);
            this.NoMessageSelectedPanel.Controls.Add(this.label7);
            this.NoMessageSelectedPanel.Controls.Add(this.label8);
            this.NoMessageSelectedPanel.Location = new System.Drawing.Point(12, 12);
            this.NoMessageSelectedPanel.Name = "NoMessageSelectedPanel";
            this.NoMessageSelectedPanel.Size = new System.Drawing.Size(567, 574);
            this.NoMessageSelectedPanel.TabIndex = 64;
            this.NoMessageSelectedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NoMessageSelectedPanel_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label6.Location = new System.Drawing.Point(181, 269);
            this.label6.MaximumSize = new System.Drawing.Size(442, 400);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(204, 32);
            this.label6.TabIndex = 60;
            this.label6.Text = "Choose one from your existing messages, or start a new one.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Gotham", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(256, 182);
            this.label7.MaximumSize = new System.Drawing.Size(442, 400);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(59, 41);
            this.label7.TabIndex = 59;
            this.label7.Text = "📌";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(150, 218);
            this.label8.MaximumSize = new System.Drawing.Size(442, 400);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(266, 70);
            this.label8.TabIndex = 58;
            this.label8.Text = "You don\'t have a selected message";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 52);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(538, 14);
            this.bunifuSeparator1.TabIndex = 61;
            // 
            // MessageLoader
            // 
            this.MessageLoader.BackColor = System.Drawing.Color.White;
            this.MessageLoader.Controls.Add(this.MessageError);
            this.MessageLoader.Controls.Add(this.pictureBox1);
            this.MessageLoader.Controls.Add(this.label39);
            this.MessageLoader.Location = new System.Drawing.Point(9, 64);
            this.MessageLoader.Name = "MessageLoader";
            this.MessageLoader.Size = new System.Drawing.Size(567, 466);
            this.MessageLoader.TabIndex = 62;
            this.MessageLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.MessageLoader_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(177)))), ((int)(((byte)(198)))));
            this.label39.Location = new System.Drawing.Point(222, 247);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(131, 15);
            this.label39.TabIndex = 61;
            this.label39.Text = "Getting messages...";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.AcceptsReturn = false;
            this.MessageTextBox.AcceptsTab = true;
            this.MessageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MessageTextBox.AnimationSpeed = 200;
            this.MessageTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MessageTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MessageTextBox.AutoSizeHeight = true;
            this.MessageTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MessageTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MessageTextBox.BackgroundImage")));
            this.MessageTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.MessageTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.MessageTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.MessageTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.MessageTextBox.BorderRadius = 15;
            this.MessageTextBox.BorderThickness = 1;
            this.MessageTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.DefaultFont = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.DefaultText = "";
            this.MessageTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.MessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.MessageTextBox.HideSelection = true;
            this.MessageTextBox.IconLeft = null;
            this.MessageTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.IconPadding = 10;
            this.MessageTextBox.IconRight = null;
            this.MessageTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.Lines = new string[0];
            this.MessageTextBox.Location = new System.Drawing.Point(57, 537);
            this.MessageTextBox.MaxLength = 32767;
            this.MessageTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.MessageTextBox.Modified = false;
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MessageTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MessageTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MessageTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MessageTextBox.OnIdleState = stateProperties4;
            this.MessageTextBox.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.MessageTextBox.PasswordChar = '\0';
            this.MessageTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.MessageTextBox.PlaceholderText = "Type a new message";
            this.MessageTextBox.ReadOnly = false;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MessageTextBox.SelectedText = "";
            this.MessageTextBox.SelectionLength = 0;
            this.MessageTextBox.SelectionStart = 0;
            this.MessageTextBox.ShortcutsEnabled = true;
            this.MessageTextBox.Size = new System.Drawing.Size(471, 40);
            this.MessageTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.MessageTextBox.TabIndex = 55;
            this.MessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessageTextBox.TextMarginBottom = 0;
            this.MessageTextBox.TextMarginLeft = 0;
            this.MessageTextBox.TextMarginTop = 7;
            this.MessageTextBox.TextPlaceholder = "Type a new message";
            this.MessageTextBox.UseSystemPasswordChar = false;
            this.MessageTextBox.WordWrap = true;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // ContactActiveStatusLabel
            // 
            this.ContactActiveStatusLabel.AutoEllipsis = true;
            this.ContactActiveStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContactActiveStatusLabel.Font = new System.Drawing.Font("Gotham", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactActiveStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.ContactActiveStatusLabel.Location = new System.Drawing.Point(209, 36);
            this.ContactActiveStatusLabel.Name = "ContactActiveStatusLabel";
            this.ContactActiveStatusLabel.Size = new System.Drawing.Size(166, 12);
            this.ContactActiveStatusLabel.TabIndex = 60;
            this.ContactActiveStatusLabel.Text = "Active Status";
            this.ContactActiveStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactName
            // 
            this.ContactName.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ContactName.Location = new System.Drawing.Point(81, 14);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(423, 23);
            this.ContactName.TabIndex = 59;
            this.ContactName.Text = "Rheanne Ray Eduyan";
            this.ContactName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttachFileButton
            // 
            this.AttachFileButton.AutoSize = true;
            this.AttachFileButton.BackColor = System.Drawing.Color.Transparent;
            this.AttachFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttachFileButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            this.AttachFileButton.Location = new System.Drawing.Point(21, 543);
            this.AttachFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.AttachFileButton.Name = "AttachFileButton";
            this.AttachFileButton.Size = new System.Drawing.Size(33, 26);
            this.AttachFileButton.TabIndex = 58;
            this.AttachFileButton.Text = "🎴";
            this.AttachFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AttachFileButton.Click += new System.EventHandler(this.AttachFileButton_Click);
            this.AttachFileButton.MouseLeave += new System.EventHandler(this.AttachFileButton_MouseLeave);
            this.AttachFileButton.MouseHover += new System.EventHandler(this.AttachFileButton_MouseHover);
            // 
            // ChatMessagesFlowLayoutPanel
            // 
            this.ChatMessagesFlowLayoutPanel.AutoScroll = true;
            this.ChatMessagesFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChatMessagesFlowLayoutPanel.Controls.Add(this.BeginningBorder);
            this.ChatMessagesFlowLayoutPanel.Controls.Add(this.EmptyPanel);
            this.ChatMessagesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatMessagesFlowLayoutPanel.Location = new System.Drawing.Point(21, 64);
            this.ChatMessagesFlowLayoutPanel.Name = "ChatMessagesFlowLayoutPanel";
            this.ChatMessagesFlowLayoutPanel.Size = new System.Drawing.Size(647, 450);
            this.ChatMessagesFlowLayoutPanel.TabIndex = 56;
            this.ChatMessagesFlowLayoutPanel.WrapContents = false;
            // 
            // BeginningBorder
            // 
            this.BeginningBorder.AutoSize = true;
            this.BeginningBorder.BackColor = System.Drawing.Color.Transparent;
            this.BeginningBorder.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginningBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.BeginningBorder.Location = new System.Drawing.Point(3, 0);
            this.BeginningBorder.Name = "BeginningBorder";
            this.BeginningBorder.Size = new System.Drawing.Size(538, 15);
            this.BeginningBorder.TabIndex = 4;
            this.BeginningBorder.Text = "---------------------------------------------  Beginning  -----------------------" +
    "----------------------";
            // 
            // EmptyPanel
            // 
            this.EmptyPanel.BackColor = System.Drawing.Color.White;
            this.EmptyPanel.Controls.Add(this.label4);
            this.EmptyPanel.Controls.Add(this.label5);
            this.EmptyPanel.Location = new System.Drawing.Point(3, 18);
            this.EmptyPanel.Name = "EmptyPanel";
            this.EmptyPanel.Size = new System.Drawing.Size(538, 432);
            this.EmptyPanel.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(241, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 38);
            this.label4.TabIndex = 59;
            this.label4.Text = "🗑";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(222, 223);
            this.label5.MaximumSize = new System.Drawing.Size(442, 400);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "No Messages ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.AutoSize = true;
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SendButton.Location = new System.Drawing.Point(529, 536);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(44, 38);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "➤";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SearchPeopleTextBox
            // 
            this.SearchPeopleTextBox.AcceptsReturn = false;
            this.SearchPeopleTextBox.AcceptsTab = false;
            this.SearchPeopleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SearchPeopleTextBox.AnimationSpeed = 200;
            this.SearchPeopleTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchPeopleTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchPeopleTextBox.AutoSizeHeight = true;
            this.SearchPeopleTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchPeopleTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPeopleTextBox.BackgroundImage")));
            this.SearchPeopleTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.SearchPeopleTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.SearchPeopleTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.SearchPeopleTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.SearchPeopleTextBox.BorderRadius = 35;
            this.SearchPeopleTextBox.BorderThickness = 1;
            this.SearchPeopleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchPeopleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchPeopleTextBox.DefaultFont = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPeopleTextBox.DefaultText = "";
            this.SearchPeopleTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.SearchPeopleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.SearchPeopleTextBox.HideSelection = true;
            this.SearchPeopleTextBox.IconLeft = null;
            this.SearchPeopleTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchPeopleTextBox.IconPadding = 10;
            this.SearchPeopleTextBox.IconRight = null;
            this.SearchPeopleTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchPeopleTextBox.Lines = new string[0];
            this.SearchPeopleTextBox.Location = new System.Drawing.Point(18, 21);
            this.SearchPeopleTextBox.MaxLength = 32767;
            this.SearchPeopleTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchPeopleTextBox.Modified = false;
            this.SearchPeopleTextBox.Multiline = false;
            this.SearchPeopleTextBox.Name = "SearchPeopleTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchPeopleTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchPeopleTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            stateProperties7.FillColor = System.Drawing.Color.White;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchPeopleTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchPeopleTextBox.OnIdleState = stateProperties8;
            this.SearchPeopleTextBox.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.SearchPeopleTextBox.PasswordChar = '\0';
            this.SearchPeopleTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.SearchPeopleTextBox.PlaceholderText = "🔍  Search for people";
            this.SearchPeopleTextBox.ReadOnly = false;
            this.SearchPeopleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchPeopleTextBox.SelectedText = "";
            this.SearchPeopleTextBox.SelectionLength = 0;
            this.SearchPeopleTextBox.SelectionStart = 0;
            this.SearchPeopleTextBox.ShortcutsEnabled = true;
            this.SearchPeopleTextBox.Size = new System.Drawing.Size(224, 40);
            this.SearchPeopleTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SearchPeopleTextBox.TabIndex = 56;
            this.SearchPeopleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchPeopleTextBox.TextMarginBottom = 0;
            this.SearchPeopleTextBox.TextMarginLeft = 5;
            this.SearchPeopleTextBox.TextMarginTop = 0;
            this.SearchPeopleTextBox.TextPlaceholder = "🔍  Search for people";
            this.SearchPeopleTextBox.UseSystemPasswordChar = false;
            this.SearchPeopleTextBox.WordWrap = true;
            this.SearchPeopleTextBox.TextChanged += new System.EventHandler(this.SearchChatTextBox_TextChanged);
            // 
            // GetContactsWorker
            // 
            this.GetContactsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetContactsWorker_DoWork);
            this.GetContactsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetContactsWorker_RunWorkerCompleted);
            // 
            // GetMessagesWorker
            // 
            this.GetMessagesWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetMessagesWorker_DoWork);
            this.GetMessagesWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetMessagesWorker_RunWorkerCompleted);
            // 
            // SendMessageWorker
            // 
            this.SendMessageWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SendMessageWorker_DoWork);
            this.SendMessageWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SendMessageWorker_RunWorkerCompleted);
            // 
            // HiddenLabel
            // 
            this.HiddenLabel.AutoSize = true;
            this.HiddenLabel.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiddenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.HiddenLabel.Location = new System.Drawing.Point(43, 607);
            this.HiddenLabel.MaximumSize = new System.Drawing.Size(467, 200);
            this.HiddenLabel.MinimumSize = new System.Drawing.Size(467, 33);
            this.HiddenLabel.Name = "HiddenLabel";
            this.HiddenLabel.Padding = new System.Windows.Forms.Padding(3, 9, 14, 9);
            this.HiddenLabel.Size = new System.Drawing.Size(467, 33);
            this.HiddenLabel.TabIndex = 61;
            this.HiddenLabel.Text = "label1";
            // 
            // ConstantUpdateWorker
            // 
            this.ConstantUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConstantUpdateWorker_DoWork);
            this.ConstantUpdateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ConstantUpdateWorker_RunWorkerCompleted);
            // 
            // ConstantUpdateTimer
            // 
            this.ConstantUpdateTimer.Interval = 2000;
            this.ConstantUpdateTimer.Tick += new System.EventHandler(this.ConstantUpdateTimer_Tick);
            // 
            // SendImageWorker
            // 
            this.SendImageWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SendImageWorker_DoWork);
            this.SendImageWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SendImageWorker_RunWorkerCompleted);
            // 
            // ChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.ChatContainer);
            this.Controls.Add(this.SearchPeopleTextBox);
            this.Controls.Add(this.ChatHeadFlowLayoutPanel);
            this.Controls.Add(this.HiddenLabel);
            this.Name = "ChatPanel";
            this.Size = new System.Drawing.Size(848, 640);
            this.MessageError.ResumeLayout(false);
            this.MessageError.PerformLayout();
            this.ChatContainer.ResumeLayout(false);
            this.ChatContainer.PerformLayout();
            this.NoMessageSelectedPanel.ResumeLayout(false);
            this.NoMessageSelectedPanel.PerformLayout();
            this.MessageLoader.ResumeLayout(false);
            this.MessageLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChatMessagesFlowLayoutPanel.ResumeLayout(false);
            this.ChatMessagesFlowLayoutPanel.PerformLayout();
            this.EmptyPanel.ResumeLayout(false);
            this.EmptyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ChatHeadFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuShadowPanel ChatContainer;
        private System.Windows.Forms.Label SendButton;
        private System.Windows.Forms.FlowLayoutPanel ChatMessagesFlowLayoutPanel;
        private System.Windows.Forms.Label BeginningBorder;
        private Bunifu.UI.WinForms.BunifuTextBox MessageTextBox;
        private System.Windows.Forms.Label AttachFileButton;
        private Bunifu.UI.WinForms.BunifuTextBox SearchPeopleTextBox;
        private System.ComponentModel.BackgroundWorker GetContactsWorker;
        private System.ComponentModel.BackgroundWorker GetMessagesWorker;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.Label ContactActiveStatusLabel;
        private System.ComponentModel.BackgroundWorker SendMessageWorker;
        private System.ComponentModel.BackgroundWorker UpdateMessagesWorker;
        private System.Windows.Forms.Label HiddenLabel;
        private System.ComponentModel.BackgroundWorker ConstantUpdateWorker;
        private System.Windows.Forms.Timer ConstantUpdateTimer;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel MessageError;
        private System.Windows.Forms.Label RetryMessageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MessageLoader;
        private System.Windows.Forms.Panel EmptyPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel NoMessageSelectedPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker SendImageWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label39;
    }
}
