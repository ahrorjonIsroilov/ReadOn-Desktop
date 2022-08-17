using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ReadOn.AnimationUtils;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace ReadOn
{
    public partial class Animation : UserControl
    {
        public Animation()
        {
            InitializeComponent();
        }
        private int order = 1;
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private readonly String[] captions = { "Reading is pleasure", "simplified statistics", "Get your data anywhere"};
        private readonly String[] descriptions = { "make reading a favorite activity with us", "get the statistics you need about your reading period", "all your data is stored in the cloud" };
        private readonly Bitmap[] images = { Properties.Resources.reading, Properties.Resources.analysis, Properties.Resources.cloud_sync };

        protected override void OnLoad(EventArgs e)
        {
            pfc.AddFontFile("C:\\Users\\arond\\source\\repos\\ReadOn\\Resources\\Enso.ttf");
            slider.Start();
            loadFonts();
            base.OnLoad(e);
        }

        private void loadFonts()
        {
            foreach(Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size);
            }
        }

        private void slider_Tick(object sender, EventArgs e)
        {
            animate();
        }
        private void animate()
        {
            if (order >2) order = 0;
            if (order <3)
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
    }
}
