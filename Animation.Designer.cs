namespace ReadOn
{
    partial class Animation
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animation));
            this.slider = new System.Windows.Forms.Timer(this.components);
            this.captionText = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.animator = new Guna.UI2.WinForms.Guna2Transition();
            this.picBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slider
            // 
            this.slider.Enabled = true;
            this.slider.Interval = 5000;
            this.slider.Tick += new System.EventHandler(this.slider_Tick);
            // 
            // captionText
            // 
            this.captionText.AutoSize = true;
            this.animator.SetDecoration(this.captionText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.captionText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.captionText.Location = new System.Drawing.Point(125, 22);
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(151, 21);
            this.captionText.TabIndex = 1;
            this.captionText.Text = "Reading is pleasure";
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.animator.SetDecoration(this.descriptionText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.descriptionText.Location = new System.Drawing.Point(83, 45);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(234, 17);
            this.descriptionText.TabIndex = 2;
            this.descriptionText.Text = "make reading a favorite activity with us";
            // 
            // animator
            // 
            this.animator.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation1;
            this.animator.MaxAnimationTime = 1000;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.BackgroundImage = global::ReadOn.Properties.Resources.background;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.animator.SetDecoration(this.picBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picBox.Image = global::ReadOn.Properties.Resources.reading;
            this.picBox.ImageRotate = 0F;
            this.picBox.Location = new System.Drawing.Point(0, 65);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(400, 215);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.captionText);
            this.Controls.Add(this.picBox);
            this.animator.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "Animation";
            this.Size = new System.Drawing.Size(400, 280);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBox;
        private System.Windows.Forms.Timer slider;
        private System.Windows.Forms.Label captionText;
        private System.Windows.Forms.Label descriptionText;
        private Guna.UI2.WinForms.Guna2Transition animator;
    }
}
