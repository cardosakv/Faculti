
namespace Faculti
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.ForgotPasswordEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IncorrectEmailForgotTooltip = new System.Windows.Forms.Label();
            this.FindAccountButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.EmailForgotTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BackButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ForgotPasswordEllipse
            // 
            this.ForgotPasswordEllipse.ElipseRadius = 20;
            this.ForgotPasswordEllipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(122, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Forgot Password?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.label11.Location = new System.Drawing.Point(72, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Please enter your email to find your account.";
            // 
            // IncorrectEmailForgotTooltip
            // 
            this.IncorrectEmailForgotTooltip.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.IncorrectEmailForgotTooltip.AutoSize = true;
            this.IncorrectEmailForgotTooltip.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncorrectEmailForgotTooltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectEmailForgotTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.IncorrectEmailForgotTooltip.Location = new System.Drawing.Point(139, 247);
            this.IncorrectEmailForgotTooltip.Name = "IncorrectEmailForgotTooltip";
            this.IncorrectEmailForgotTooltip.Size = new System.Drawing.Size(126, 15);
            this.IncorrectEmailForgotTooltip.TabIndex = 40;
            this.IncorrectEmailForgotTooltip.Text = "Incorrect email format";
            this.IncorrectEmailForgotTooltip.Visible = false;
            this.IncorrectEmailForgotTooltip.Click += new System.EventHandler(this.IncorrectEmailForgotTooltip_Click);
            // 
            // FindAccountButton
            // 
            this.FindAccountButton.AllowAnimations = true;
            this.FindAccountButton.AllowMouseEffects = true;
            this.FindAccountButton.AllowToggling = false;
            this.FindAccountButton.AnimationSpeed = 200;
            this.FindAccountButton.AutoGenerateColors = false;
            this.FindAccountButton.AutoRoundBorders = false;
            this.FindAccountButton.AutoSizeLeftIcon = true;
            this.FindAccountButton.AutoSizeRightIcon = true;
            this.FindAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.FindAccountButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindAccountButton.BackgroundImage")));
            this.FindAccountButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FindAccountButton.ButtonText = "Find Account";
            this.FindAccountButton.ButtonTextMarginLeft = 0;
            this.FindAccountButton.ColorContrastOnClick = 45;
            this.FindAccountButton.ColorContrastOnHover = 45;
            this.FindAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.FindAccountButton.CustomizableEdges = borderEdges1;
            this.FindAccountButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindAccountButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FindAccountButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FindAccountButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FindAccountButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.FindAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAccountButton.ForeColor = System.Drawing.Color.White;
            this.FindAccountButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindAccountButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FindAccountButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FindAccountButton.IconMarginLeft = 11;
            this.FindAccountButton.IconPadding = 10;
            this.FindAccountButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FindAccountButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FindAccountButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FindAccountButton.IconSize = 25;
            this.FindAccountButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.IdleBorderRadius = 10;
            this.FindAccountButton.IdleBorderThickness = 1;
            this.FindAccountButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.IdleIconLeftImage = null;
            this.FindAccountButton.IdleIconRightImage = null;
            this.FindAccountButton.IndicateFocus = false;
            this.FindAccountButton.Location = new System.Drawing.Point(55, 276);
            this.FindAccountButton.Name = "FindAccountButton";
            this.FindAccountButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FindAccountButton.OnDisabledState.BorderRadius = 10;
            this.FindAccountButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FindAccountButton.OnDisabledState.BorderThickness = 1;
            this.FindAccountButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FindAccountButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FindAccountButton.OnDisabledState.IconLeftImage = null;
            this.FindAccountButton.OnDisabledState.IconRightImage = null;
            this.FindAccountButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.FindAccountButton.onHoverState.BorderRadius = 10;
            this.FindAccountButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FindAccountButton.onHoverState.BorderThickness = 1;
            this.FindAccountButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.FindAccountButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FindAccountButton.onHoverState.IconLeftImage = null;
            this.FindAccountButton.onHoverState.IconRightImage = null;
            this.FindAccountButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.OnIdleState.BorderRadius = 10;
            this.FindAccountButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FindAccountButton.OnIdleState.BorderThickness = 1;
            this.FindAccountButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.FindAccountButton.OnIdleState.IconLeftImage = null;
            this.FindAccountButton.OnIdleState.IconRightImage = null;
            this.FindAccountButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.OnPressedState.BorderRadius = 10;
            this.FindAccountButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FindAccountButton.OnPressedState.BorderThickness = 1;
            this.FindAccountButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.FindAccountButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FindAccountButton.OnPressedState.IconLeftImage = null;
            this.FindAccountButton.OnPressedState.IconRightImage = null;
            this.FindAccountButton.Size = new System.Drawing.Size(308, 39);
            this.FindAccountButton.TabIndex = 39;
            this.FindAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FindAccountButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindAccountButton.TextMarginLeft = 0;
            this.FindAccountButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.FindAccountButton.UseDefaultRadiusAndThickness = true;
            this.FindAccountButton.Click += new System.EventHandler(this.FindAccountButton_Click);
            // 
            // EmailForgotTextBox
            // 
            this.EmailForgotTextBox.AcceptsReturn = false;
            this.EmailForgotTextBox.AcceptsTab = false;
            this.EmailForgotTextBox.AnimationSpeed = 200;
            this.EmailForgotTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailForgotTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailForgotTextBox.AutoSizeHeight = true;
            this.EmailForgotTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailForgotTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailForgotTextBox.BackgroundImage")));
            this.EmailForgotTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            this.EmailForgotTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EmailForgotTextBox.BorderColorHover = System.Drawing.Color.DarkGray;
            this.EmailForgotTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailForgotTextBox.BorderRadius = 10;
            this.EmailForgotTextBox.BorderThickness = 1;
            this.EmailForgotTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailForgotTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailForgotTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailForgotTextBox.DefaultText = "";
            this.EmailForgotTextBox.FillColor = System.Drawing.Color.White;
            this.EmailForgotTextBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailForgotTextBox.HideSelection = true;
            this.EmailForgotTextBox.IconLeft = null;
            this.EmailForgotTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailForgotTextBox.IconPadding = 10;
            this.EmailForgotTextBox.IconRight = null;
            this.EmailForgotTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailForgotTextBox.Lines = new string[0];
            this.EmailForgotTextBox.Location = new System.Drawing.Point(54, 205);
            this.EmailForgotTextBox.MaxLength = 32767;
            this.EmailForgotTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmailForgotTextBox.Modified = false;
            this.EmailForgotTextBox.Multiline = false;
            this.EmailForgotTextBox.Name = "EmailForgotTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(24)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailForgotTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.EmailForgotTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailForgotTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Gray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailForgotTextBox.OnIdleState = stateProperties4;
            this.EmailForgotTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.EmailForgotTextBox.PasswordChar = '\0';
            this.EmailForgotTextBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.EmailForgotTextBox.PlaceholderText = "juandelacruz@email.com";
            this.EmailForgotTextBox.ReadOnly = false;
            this.EmailForgotTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailForgotTextBox.SelectedText = "";
            this.EmailForgotTextBox.SelectionLength = 0;
            this.EmailForgotTextBox.SelectionStart = 0;
            this.EmailForgotTextBox.ShortcutsEnabled = true;
            this.EmailForgotTextBox.Size = new System.Drawing.Size(310, 36);
            this.EmailForgotTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.EmailForgotTextBox.TabIndex = 38;
            this.EmailForgotTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailForgotTextBox.TextMarginBottom = 0;
            this.EmailForgotTextBox.TextMarginLeft = 3;
            this.EmailForgotTextBox.TextMarginTop = 0;
            this.EmailForgotTextBox.TextPlaceholder = "juandelacruz@email.com";
            this.EmailForgotTextBox.UseSystemPasswordChar = false;
            this.EmailForgotTextBox.WordWrap = true;
            this.EmailForgotTextBox.TextChanged += new System.EventHandler(this.EmailForgotTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.ActiveImage = null;
            this.BackButton.AllowAnimations = true;
            this.BackButton.AllowBuffering = false;
            this.BackButton.AllowToggling = false;
            this.BackButton.AllowZooming = false;
            this.BackButton.AllowZoomingOnFocus = false;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BackButton.ErrorImage")));
            this.BackButton.FadeWhenInactive = true;
            this.BackButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BackButton.Image = global::Faculti.Properties.Resources.minimize_button;
            this.BackButton.ImageActive = null;
            this.BackButton.ImageLocation = null;
            this.BackButton.ImageMargin = 0;
            this.BackButton.ImageSize = new System.Drawing.Size(22, 24);
            this.BackButton.ImageZoomSize = new System.Drawing.Size(22, 24);
            this.BackButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("BackButton.InitialImage")));
            this.BackButton.Location = new System.Drawing.Point(21, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.Rotation = 90;
            this.BackButton.ShowActiveImage = true;
            this.BackButton.ShowCursorChanges = true;
            this.BackButton.ShowImageBorders = false;
            this.BackButton.ShowSizeMarkers = false;
            this.BackButton.Size = new System.Drawing.Size(22, 24);
            this.BackButton.TabIndex = 36;
            this.BackButton.ToolTipText = "";
            this.BackButton.WaitOnLoad = false;
            this.BackButton.Zoom = 0;
            this.BackButton.ZoomSpeed = 10;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(53, 185);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(44, 15);
            this.FirstNameLabel.TabIndex = 41;
            this.FirstNameLabel.Text = "Email";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.IncorrectEmailForgotTooltip);
            this.Controls.Add(this.FindAccountButton);
            this.Controls.Add(this.EmailForgotTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculti -Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ForgotPasswordEllipse;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton BackButton;
        private System.Windows.Forms.Label label11;
        private Bunifu.UI.WinForms.BunifuTextBox EmailForgotTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 FindAccountButton;
        private System.Windows.Forms.Label IncorrectEmailForgotTooltip;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}