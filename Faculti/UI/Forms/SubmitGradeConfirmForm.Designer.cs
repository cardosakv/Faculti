namespace Faculti.UI.Forms
{
    partial class SubmitGradeConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitGradeConfirmForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.CancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ConfirmButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitGradesWorker = new System.ComponentModel.BackgroundWorker();
            this.Ellipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CircleProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.ProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.AllowAnimations = true;
            this.CancelButton.AllowMouseEffects = true;
            this.CancelButton.AllowToggling = false;
            this.CancelButton.AnimationSpeed = 200;
            this.CancelButton.AutoGenerateColors = false;
            this.CancelButton.AutoRoundBorders = false;
            this.CancelButton.AutoSizeLeftIcon = true;
            this.CancelButton.AutoSizeRightIcon = true;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackColor1 = System.Drawing.Color.Transparent;
            this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
            this.CancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CancelButton.ButtonText = "No";
            this.CancelButton.ButtonTextMarginLeft = 0;
            this.CancelButton.ColorContrastOnClick = 45;
            this.CancelButton.ColorContrastOnHover = 45;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.CancelButton.CustomizableEdges = borderEdges3;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CancelButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CancelButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.CancelButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CancelButton.IconMarginLeft = 11;
            this.CancelButton.IconPadding = 10;
            this.CancelButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CancelButton.IconSize = 25;
            this.CancelButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.IdleBorderRadius = 10;
            this.CancelButton.IdleBorderThickness = 1;
            this.CancelButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.CancelButton.IdleIconLeftImage = null;
            this.CancelButton.IdleIconRightImage = null;
            this.CancelButton.IndicateFocus = false;
            this.CancelButton.Location = new System.Drawing.Point(180, 130);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CancelButton.OnDisabledState.BorderRadius = 10;
            this.CancelButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CancelButton.OnDisabledState.BorderThickness = 1;
            this.CancelButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CancelButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CancelButton.OnDisabledState.IconLeftImage = null;
            this.CancelButton.OnDisabledState.IconRightImage = null;
            this.CancelButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.onHoverState.BorderRadius = 10;
            this.CancelButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CancelButton.onHoverState.BorderThickness = 1;
            this.CancelButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CancelButton.onHoverState.IconLeftImage = null;
            this.CancelButton.onHoverState.IconRightImage = null;
            this.CancelButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.OnIdleState.BorderRadius = 10;
            this.CancelButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CancelButton.OnIdleState.BorderThickness = 1;
            this.CancelButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.CancelButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.OnIdleState.IconLeftImage = null;
            this.CancelButton.OnIdleState.IconRightImage = null;
            this.CancelButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.OnPressedState.BorderRadius = 10;
            this.CancelButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.CancelButton.OnPressedState.BorderThickness = 1;
            this.CancelButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CancelButton.OnPressedState.IconLeftImage = null;
            this.CancelButton.OnPressedState.IconRightImage = null;
            this.CancelButton.Size = new System.Drawing.Size(131, 39);
            this.CancelButton.TabIndex = 47;
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.TextMarginLeft = 0;
            this.CancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CancelButton.UseDefaultRadiusAndThickness = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AllowAnimations = true;
            this.ConfirmButton.AllowMouseEffects = true;
            this.ConfirmButton.AllowToggling = false;
            this.ConfirmButton.AnimationSpeed = 200;
            this.ConfirmButton.AutoGenerateColors = false;
            this.ConfirmButton.AutoRoundBorders = false;
            this.ConfirmButton.AutoSizeLeftIcon = true;
            this.ConfirmButton.AutoSizeRightIcon = true;
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmButton.BackgroundImage")));
            this.ConfirmButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ConfirmButton.ButtonText = "Yes";
            this.ConfirmButton.ButtonTextMarginLeft = 0;
            this.ConfirmButton.ColorContrastOnClick = 45;
            this.ConfirmButton.ColorContrastOnHover = 45;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.ConfirmButton.CustomizableEdges = borderEdges4;
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConfirmButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ConfirmButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ConfirmButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ConfirmButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.ConfirmButton.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ConfirmButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ConfirmButton.IconMarginLeft = 11;
            this.ConfirmButton.IconPadding = 10;
            this.ConfirmButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ConfirmButton.IconSize = 25;
            this.ConfirmButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.IdleBorderRadius = 10;
            this.ConfirmButton.IdleBorderThickness = 1;
            this.ConfirmButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.IdleIconLeftImage = null;
            this.ConfirmButton.IdleIconRightImage = null;
            this.ConfirmButton.IndicateFocus = false;
            this.ConfirmButton.Location = new System.Drawing.Point(25, 130);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ConfirmButton.OnDisabledState.BorderRadius = 10;
            this.ConfirmButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ConfirmButton.OnDisabledState.BorderThickness = 1;
            this.ConfirmButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ConfirmButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ConfirmButton.OnDisabledState.IconLeftImage = null;
            this.ConfirmButton.OnDisabledState.IconRightImage = null;
            this.ConfirmButton.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.ConfirmButton.onHoverState.BorderRadius = 10;
            this.ConfirmButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ConfirmButton.onHoverState.BorderThickness = 1;
            this.ConfirmButton.onHoverState.FillColor = System.Drawing.Color.Empty;
            this.ConfirmButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.onHoverState.IconLeftImage = null;
            this.ConfirmButton.onHoverState.IconRightImage = null;
            this.ConfirmButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.OnIdleState.BorderRadius = 10;
            this.ConfirmButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ConfirmButton.OnIdleState.BorderThickness = 1;
            this.ConfirmButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ConfirmButton.OnIdleState.IconLeftImage = null;
            this.ConfirmButton.OnIdleState.IconRightImage = null;
            this.ConfirmButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.OnPressedState.BorderRadius = 10;
            this.ConfirmButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ConfirmButton.OnPressedState.BorderThickness = 1;
            this.ConfirmButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.OnPressedState.IconLeftImage = null;
            this.ConfirmButton.OnPressedState.IconRightImage = null;
            this.ConfirmButton.Size = new System.Drawing.Size(131, 39);
            this.ConfirmButton.TabIndex = 46;
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmButton.TextMarginLeft = 0;
            this.ConfirmButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ConfirmButton.UseDefaultRadiusAndThickness = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 84);
            this.label1.TabIndex = 45;
            this.label1.Text = "This process is irrevocable. Are you sure you want to submit the grades?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitGradesWorker
            // 
            this.SubmitGradesWorker.WorkerReportsProgress = true;
            this.SubmitGradesWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SubmitGrades_DoWork);
            this.SubmitGradesWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SubmitGrades_RunWorkerCompleted);
            // 
            // Ellipse
            // 
            this.Ellipse.ElipseRadius = 25;
            this.Ellipse.TargetControl = this;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.White;
            this.ProgressPanel.Controls.Add(this.label2);
            this.ProgressPanel.Controls.Add(this.bunifuLabel1);
            this.ProgressPanel.Controls.Add(this.CircleProgress);
            this.ProgressPanel.Location = new System.Drawing.Point(-3, -2);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(343, 205);
            this.ProgressPanel.TabIndex = 48;
            this.ProgressPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Submit Successful";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(152, 64);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(37, 37);
            this.bunifuLabel1.TabIndex = 48;
            this.bunifuLabel1.Text = "✔️";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CircleProgress
            // 
            this.CircleProgress.Animated = true;
            this.CircleProgress.AnimationInterval = 3;
            this.CircleProgress.AnimationSpeed = 1;
            this.CircleProgress.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgress.CircleMargin = 10;
            this.CircleProgress.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CircleProgress.IsPercentage = false;
            this.CircleProgress.LineProgressThickness = 5;
            this.CircleProgress.LineThickness = 5;
            this.CircleProgress.Location = new System.Drawing.Point(130, 43);
            this.CircleProgress.Name = "CircleProgress";
            this.CircleProgress.ProgressAnimationSpeed = 500;
            this.CircleProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.CircleProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CircleProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CircleProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.CircleProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CircleProgress.Size = new System.Drawing.Size(80, 80);
            this.CircleProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircleProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.CircleProgress.SubScriptText = "";
            this.CircleProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircleProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.CircleProgress.SuperScriptText = "";
            this.CircleProgress.TabIndex = 47;
            this.CircleProgress.Text = "99";
            this.CircleProgress.TextMargin = new System.Windows.Forms.Padding(1, 6, 0, 0);
            this.CircleProgress.Value = 99;
            this.CircleProgress.ValueByTransition = 99;
            this.CircleProgress.ValueMargin = new System.Windows.Forms.Padding(1, 6, 0, 0);
            this.CircleProgress.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs>(this.CircleProgress_ProgressChanged);
            // 
            // SubmitGradeConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 195);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubmitGradeConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubmitGradeProgressForm";
            this.Load += new System.EventHandler(this.SubmitGradeConfirmForm_Load);
            this.ProgressPanel.ResumeLayout(false);
            this.ProgressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 CancelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker SubmitGradesWorker;
        private Bunifu.Framework.UI.BunifuElipse Ellipse;
        private System.Windows.Forms.Panel ProgressPanel;
        private Bunifu.UI.WinForms.BunifuCircleProgress CircleProgress;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Label label2;
    }
}