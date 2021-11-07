namespace Faculti.UI.Forms
{
    partial class ConfirmExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmExitForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.Ellipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ConfirmButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Circular Spotify Tx T Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(109)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 84);
            this.label1.TabIndex = 56;
            this.label1.Text = "Are you sure you want to exit?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ellipse
            // 
            this.Ellipse.ElipseRadius = 25;
            this.Ellipse.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Faculti.Properties.Resources.close_1_1s_200px__4_;
            this.pictureBox1.Location = new System.Drawing.Point(118, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.CancelButton.CustomizableEdges = borderEdges1;
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
            this.CancelButton.Location = new System.Drawing.Point(188, 164);
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
            this.CancelButton.TabIndex = 58;
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.TextMarginLeft = 0;
            this.CancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CancelButton.UseDefaultRadiusAndThickness = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ConfirmButton.CustomizableEdges = borderEdges2;
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
            this.ConfirmButton.Location = new System.Drawing.Point(43, 164);
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
            this.ConfirmButton.TabIndex = 57;
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmButton.TextMarginLeft = 0;
            this.ConfirmButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ConfirmButton.UseDefaultRadiusAndThickness = true;
            // 
            // ConfirmExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 241);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmExitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Exit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse Ellipse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 CancelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 ConfirmButton;
    }
}