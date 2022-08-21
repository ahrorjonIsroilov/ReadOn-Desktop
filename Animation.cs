using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
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
        private readonly Bitmap[] images = { Properties.Resources.feature1, Properties.Resources.feature2, Properties.Resources.feature3 };

        protected override void OnLoad(EventArgs e)
        {
            slider.Start();
        }

        private void slider_Tick(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(animate);
        }
        private void animate(Object o)
        {
            if (order > 2) order = 0;
            if (order < 3)
            {
                picBox.Image = images[order];
                Task.Delay(300);
                order++;
            }
        }
    }
}
