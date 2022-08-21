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
            this.slider = new System.Windows.Forms.Timer(this.components);
            this.picBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slider
            // 
            this.slider.Enabled = true;
            this.slider.Interval = 7000;
            this.slider.Tick += new System.EventHandler(this.slider_Tick);
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.FillColor = System.Drawing.Color.Empty;
            this.picBox.Image = global::ReadCat.Properties.Resources.feature1;
            this.picBox.ImageRotate = 0F;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(400, 560);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::ReadCat.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.picBox);
            this.DoubleBuffered = true;
            this.Name = "Animation";
            this.Size = new System.Drawing.Size(400, 560);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer slider;
        private Guna.UI2.WinForms.Guna2PictureBox picBox;
    }
}
