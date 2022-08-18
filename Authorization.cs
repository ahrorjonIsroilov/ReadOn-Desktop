using System;
using System.Windows.Forms;

namespace ReadCat
{
    public partial class Authorization : Form
    {
        private IOUtils ioUtils = new IOUtils();

        public Authorization()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                ioUtils.copyFilesToAppData("comfortaa");
            }
            catch (Exception ex) { MessageBox.Show("ko'chirilmadi\n" + ex.Message); }
            base.OnLoad(e);
        }
    }
}
