using System.Windows.Forms;

namespace ReadCat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.token = null;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
