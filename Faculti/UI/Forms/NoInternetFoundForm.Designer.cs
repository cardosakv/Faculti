
namespace Faculti
{
    partial class NoInternetFoundForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoInternetFoundForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.NoInternetFormEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.MinimizeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.RetryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // NoInternetFormEllipse
            // 
            this.NoInternetFormEllipse.ElipseRadius = 20;
            this.NoInternetFormEllipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "NO INTERNET FOUND";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 101);
            this.label2.TabIndex = 3;
            this.label2.Text = "We weren\'t able to connect to the internet that is required to run the applicatio" +
    "n. Please check your internet settings and try again.";
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveImage = null;
            this.CloseButton.AllowAnimations = true;
            this.CloseButton.AllowBuffering = false;
            this.CloseButton.AllowToggling = false;
            this.CloseButton.AllowZooming = false;
            this.CloseButton.AllowZoomingOnFocus = false;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.ErrorImage")));
            this.CloseButton.FadeWhenInactive = true;
            this.CloseButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CloseButton.Image = global::Faculti.Properties.Resources.close_button;
            this.CloseButton.ImageActive = null;
            this.CloseButton.ImageLocation = null;
            this.CloseButton.ImageMargin = 0;
            this.CloseButton.ImageSize = new System.Drawing.Size(24, 24);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(289, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = false;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.ToolTipText = "";
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.ActiveImage = null;
            this.MinimizeButton.AllowAnimations = true;
            this.MinimizeButton.AllowBuffering = false;
            this.MinimizeButton.AllowToggling = false;
            this.MinimizeButton.AllowZooming = false;
            this.MinimizeButton.AllowZoomingOnFocus = false;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.ErrorImage")));
            this.MinimizeButton.FadeWhenInactive = true;
            this.MinimizeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.MinimizeButton.Image = global::Faculti.Properties.Resources.minimize_button;
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.ImageLocation = null;
            this.MinimizeButton.ImageMargin = 0;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(24, 24);
            this.MinimizeButton.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.MinimizeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.InitialImage")));
            this.MinimizeButton.Location = new System.Drawing.Point(254, 6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0;
            this.MinimizeButton.ShowActiveImage = true;
            this.MinimizeButton.ShowCursorChanges = true;
            this.MinimizeButton.ShowImageBorders = false;
            this.MinimizeButton.ShowSizeMarkers = false;
            this.MinimizeButton.Size = new System.Drawing.Size(24, 24);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.ToolTipText = "";
            this.MinimizeButton.WaitOnLoad = false;
            this.MinimizeButton.Zoom = 0;
            this.MinimizeButton.ZoomSpeed = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.AllowAnimations = true;
            this.RetryButton.AllowMouseEffects = true;
            this.RetryButton.AllowToggling = false;
            this.RetryButton.AnimationSpeed = 200;
            this.RetryButton.AutoGenerateColors = false;
            this.RetryButton.AutoRoundBorders = false;
            this.RetryButton.AutoSizeLeftIcon = true;
            this.RetryButton.AutoSizeRightIcon = true;
            this.RetryButton.BackColor = System.Drawing.Color.Transparent;
            this.RetryButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RetryButton.BackgroundImage")));
            this.RetryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.RetryButton.ButtonText = "Retry";
            this.RetryButton.ButtonTextMarginLeft = 0;
            this.RetryButton.ColorContrastOnClick = 80;
            this.RetryButton.ColorContrastOnHover = 80;
            this.RetryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.RetryButton.CustomizableEdges = borderEdges2;
            this.RetryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RetryButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RetryButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RetryButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RetryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.RetryButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RetryButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RetryButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.RetryButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.RetryButton.IconMarginLeft = 11;
            this.RetryButton.IconPadding = 10;
            this.RetryButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RetryButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.RetryButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.RetryButton.IconSize = 25;
            this.RetryButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryButton.IdleBorderRadius = 8;
            this.RetryButton.IdleBorderThickness = 1;
            this.RetryButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryButton.IdleIconLeftImage = null;
            this.RetryButton.IdleIconRightImage = null;
            this.RetryButton.IndicateFocus = false;
            this.RetryButton.Location = new System.Drawing.Point(30, 269);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RetryButton.OnDisabledState.BorderRadius = 8;
            this.RetryButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.RetryButton.OnDisabledState.BorderThickness = 1;
            this.RetryButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RetryButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RetryButton.OnDisabledState.IconLeftImage = null;
            this.RetryButton.OnDisabledState.IconRightImage = null;
            this.RetryButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.RetryButton.onHoverState.BorderRadius = 8;
            this.RetryButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.RetryButton.onHoverState.BorderThickness = 1;
            this.RetryButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.RetryButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RetryButton.onHoverState.IconLeftImage = null;
            this.RetryButton.onHoverState.IconRightImage = null;
            this.RetryButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryButton.OnIdleState.BorderRadius = 8;
            this.RetryButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.RetryButton.OnIdleState.BorderThickness = 1;
            this.RetryButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RetryButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RetryButton.OnIdleState.IconLeftImage = null;
            this.RetryButton.OnIdleState.IconRightImage = null;
            this.RetryButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.RetryButton.OnPressedState.BorderRadius = 8;
            this.RetryButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.RetryButton.OnPressedState.BorderThickness = 1;
            this.RetryButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(64)))));
            this.RetryButton.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RetryButton.OnPressedState.IconLeftImage = null;
            this.RetryButton.OnPressedState.IconRightImage = null;
            this.RetryButton.Size = new System.Drawing.Size(123, 39);
            this.RetryButton.TabIndex = 5;
            this.RetryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RetryButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.RetryButton.TextMarginLeft = 0;
            this.RetryButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.RetryButton.UseDefaultRadiusAndThickness = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AllowAnimations = true;
            this.ExitButton.AllowMouseEffects = true;
            this.ExitButton.AllowToggling = false;
            this.ExitButton.AnimationSpeed = 200;
            this.ExitButton.AutoGenerateColors = false;
            this.ExitButton.AutoRoundBorders = false;
            this.ExitButton.AutoSizeLeftIcon = true;
            this.ExitButton.AutoSizeRightIcon = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackColor1 = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ExitButton.ButtonText = "Exit";
            this.ExitButton.ButtonTextMarginLeft = 0;
            this.ExitButton.ColorContrastOnClick = 80;
            this.ExitButton.ColorContrastOnHover = 80;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ExitButton.CustomizableEdges = borderEdges1;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.ExitButton.DisabledFillColor = System.Drawing.Color.Transparent;
            this.ExitButton.DisabledForecolor = System.Drawing.Color.White;
            this.ExitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.ExitButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ExitButton.IconMarginLeft = 11;
            this.ExitButton.IconPadding = 10;
            this.ExitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ExitButton.IconSize = 25;
            this.ExitButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.ExitButton.IdleBorderRadius = 8;
            this.ExitButton.IdleBorderThickness = 1;
            this.ExitButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.ExitButton.IdleIconLeftImage = null;
            this.ExitButton.IdleIconRightImage = null;
            this.ExitButton.IndicateFocus = false;
            this.ExitButton.Location = new System.Drawing.Point(171, 269);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.ExitButton.OnDisabledState.BorderRadius = 8;
            this.ExitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ExitButton.OnDisabledState.BorderThickness = 1;
            this.ExitButton.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.ExitButton.OnDisabledState.IconLeftImage = null;
            this.ExitButton.OnDisabledState.IconRightImage = null;
            this.ExitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.ExitButton.onHoverState.BorderRadius = 8;
            this.ExitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ExitButton.onHoverState.BorderThickness = 1;
            this.ExitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.ExitButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ExitButton.onHoverState.IconLeftImage = null;
            this.ExitButton.onHoverState.IconRightImage = null;
            this.ExitButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(83)))));
            this.ExitButton.OnIdleState.BorderRadius = 8;
            this.ExitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ExitButton.OnIdleState.BorderThickness = 1;
            this.ExitButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ExitButton.OnIdleState.IconLeftImage = null;
            this.ExitButton.OnIdleState.IconRightImage = null;
            this.ExitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.ExitButton.OnPressedState.BorderRadius = 8;
            this.ExitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ExitButton.OnPressedState.BorderThickness = 1;
            this.ExitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.ExitButton.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ExitButton.OnPressedState.IconLeftImage = null;
            this.ExitButton.OnPressedState.IconRightImage = null;
            this.ExitButton.Size = new System.Drawing.Size(123, 39);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.TextMarginLeft = 0;
            this.ExitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ExitButton.UseDefaultRadiusAndThickness = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NoInternetFoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(323, 340);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoInternetFoundForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculti - No Internet Found";
            this.Shown += new System.EventHandler(this.NoInternetFoundForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse NoInternetFormEllipse;
        private Bunifu.UI.WinForms.BunifuImageButton MinimizeButton;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RetryButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 ExitButton;
        private System.Windows.Forms.Timer FadeInTimer;
    }
}