namespace ReadCat
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
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
            this.captionText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.captionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.captionText.Location = new System.Drawing.Point(112, 16);
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(176, 25);
            this.captionText.TabIndex = 1;
            this.captionText.Text = "Reading is pleasure";
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.animator.SetDecoration(this.descriptionText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(66)))));
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation2;
            this.animator.MaxAnimationTime = 1000;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.AliceBlue;
            this.picBox.BackgroundImage = global::ReadCat.Properties.Resources.background;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.animator.SetDecoration(this.picBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picBox.Image = global::ReadCat.Properties.Resources.reading;
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
            this.BackColor = System.Drawing.Color.AliceBlue;
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
