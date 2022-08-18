using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ReadCat
{
    public partial class Animation : UserControl
    {
        public Animation()
        {
            InitializeComponent();
        }
        private int order = 1;
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private readonly String[] captions = { "Reading is pleasure", "simplified statistics", "Get your data anywhere" };
        private readonly String[] descriptions = { "make reading a favorite activity with us", "get the statistics you need about your reading period", "all your data is stored in the cloud" };
        private readonly Bitmap[] images = { Properties.Resources.reading, Properties.Resources.analysis, Properties.Resources.cloud_sync };

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                pfc.AddFontFile("comfortaa");
            }
            catch { }
            slider.Start();
            loadFonts();
            base.OnLoad(e);
        }

        private void loadFonts()
        {
            try
            {

                foreach (Control c in this.Controls)
                {
                    c.Font = new Font(pfc.Families[0], c.Font.Size, FontStyle.Bold);
                }
            }
            catch { }
        }

        private void slider_Tick(object sender, EventArgs e)
        {
            animate();
        }
        private void animate()
        {
            if (order > 2) order = 0;
            if (order < 3)
            {
                animator.HideSync(picBox);
                picBox.Image = images[order];
                descriptionText.Text = descriptions[order];
                captionText.Text = captions[order];
                centralizeLables(descriptionText, captionText);
                animator.ShowSync(picBox);
                order++;
            }
        }

        private void centralizeLables(params Label[] labels)
        {
            try
            {
                foreach (Label label in labels)
                {
                    label.Left = label.Parent.Width / 2 - label.Width / 2;
                }
            }
            catch (Exception) { }
        }
    }
}
