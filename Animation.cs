using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ReadOn.AnimationUtils;
namespace ReadOn
{
    public partial class Animation : UserControl
    {
        public Animation()
        {
            InitializeComponent();
        }
        private readonly String[] captions = { "Reading is pleasure", "simplified statistics", "Get your data anywhere"};
        private readonly String[] descriptions = { "make reading a favorite activity with us", "get the statistics you need about your reading period", "all your data is stored in the cloud" };
        private readonly Bitmap[] images = { Properties.Resources.reading, Properties.Resources.analysis, Properties.Resources.cloud_sync };

        protected override void OnLoad(EventArgs e)
        {
            slider.Start();
            base.OnLoad(e);
        }

        private void slider_Tick(object sender, EventArgs e)
        {
            animate(captions, descriptions, images, captionText, descriptionText, picBox, animator);
            centralizeLables(captionText, descriptionText);
        }
    }
}
