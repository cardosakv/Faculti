
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatPanel));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.ChatHeadFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.ChatMessagesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.CommentPostTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuShadowPanel1.SuspendLayout();
            this.ChatMessagesFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatHeadFlowLayoutPanel
            // 
            this.ChatHeadFlowLayoutPanel.Location = new System.Drawing.Point(14, 31);
            this.ChatHeadFlowLayoutPanel.Name = "ChatHeadFlowLayoutPanel";
            this.ChatHeadFlowLayoutPanel.Size = new System.Drawing.Size(379, 570);
            this.ChatHeadFlowLayoutPanel.TabIndex = 0;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.bunifuShadowPanel1.BorderRadius = 15;
            this.bunifuShadowPanel1.BorderThickness = 0;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuVScrollBar1);
            this.bunifuShadowPanel1.Controls.Add(this.ChatMessagesFlowLayoutPanel);
            this.bunifuShadowPanel1.Controls.Add(this.label11);
            this.bunifuShadowPanel1.Controls.Add(this.CommentPostTextBox);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(249, 11);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 3;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(584, 601);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(531, 539);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 38);
            this.label11.TabIndex = 0;
            this.label11.Text = "➤";
            // 
            // ChatMessagesFlowLayoutPanel
            // 
            this.ChatMessagesFlowLayoutPanel.Controls.Add(this.label12);
            this.ChatMessagesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatMessagesFlowLayoutPanel.Location = new System.Drawing.Point(22, 20);
            this.ChatMessagesFlowLayoutPanel.Name = "ChatMessagesFlowLayoutPanel";
            this.ChatMessagesFlowLayoutPanel.Size = new System.Drawing.Size(646, 495);
            this.ChatMessagesFlowLayoutPanel.TabIndex = 56;
            this.ChatMessagesFlowLayoutPanel.WrapContents = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(538, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "---------------------------------------------  Beginning  -----------------------" +
    "----------------------";
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
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.ChatMessagesFlowLayoutPanel;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.White;
            this.bunifuVScrollBar1.BorderRadius = 10;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(568, 20);
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
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(11, 495);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 57;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.bunifuVScrollBar1.ThumbLength = 48;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
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
            this.CommentPostTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.CommentPostTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.CommentPostTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.CommentPostTextBox.BorderRadius = 15;
            this.CommentPostTextBox.BorderThickness = 1;
            this.CommentPostTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CommentPostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentPostTextBox.DefaultFont = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentPostTextBox.DefaultText = "";
            this.CommentPostTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.CommentPostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.CommentPostTextBox.HideSelection = true;
            this.CommentPostTextBox.IconLeft = null;
            this.CommentPostTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentPostTextBox.IconPadding = 10;
            this.CommentPostTextBox.IconRight = null;
            this.CommentPostTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentPostTextBox.Lines = new string[0];
            this.CommentPostTextBox.Location = new System.Drawing.Point(22, 539);
            this.CommentPostTextBox.MaxLength = 32767;
            this.CommentPostTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.CommentPostTextBox.Modified = false;
            this.CommentPostTextBox.Multiline = true;
            this.CommentPostTextBox.Name = "CommentPostTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CommentPostTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CommentPostTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CommentPostTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CommentPostTextBox.OnIdleState = stateProperties4;
            this.CommentPostTextBox.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.CommentPostTextBox.PasswordChar = '\0';
            this.CommentPostTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.CommentPostTextBox.PlaceholderText = "Type a new message";
            this.CommentPostTextBox.ReadOnly = false;
            this.CommentPostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CommentPostTextBox.SelectedText = "";
            this.CommentPostTextBox.SelectionLength = 0;
            this.CommentPostTextBox.SelectionStart = 0;
            this.CommentPostTextBox.ShortcutsEnabled = true;
            this.CommentPostTextBox.Size = new System.Drawing.Size(505, 40);
            this.CommentPostTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CommentPostTextBox.TabIndex = 55;
            this.CommentPostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CommentPostTextBox.TextMarginBottom = 0;
            this.CommentPostTextBox.TextMarginLeft = 0;
            this.CommentPostTextBox.TextMarginTop = 7;
            this.CommentPostTextBox.TextPlaceholder = "Type a new message";
            this.CommentPostTextBox.UseSystemPasswordChar = false;
            this.CommentPostTextBox.WordWrap = true;
            // 
            // ChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.ChatHeadFlowLayoutPanel);
            this.Name = "ChatPanel";
            this.Size = new System.Drawing.Size(848, 640);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ChatMessagesFlowLayoutPanel.ResumeLayout(false);
            this.ChatMessagesFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ChatHeadFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel ChatMessagesFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.Label label12;
        private Bunifu.UI.WinForms.BunifuTextBox CommentPostTextBox;
    }
}
