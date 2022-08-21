using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ReadCat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            String appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(appData + Utils.sep + "ReadCat"))
            {
                Directory.CreateDirectory(appData + Utils.sep + "ReadCat");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!(Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1))
            {
                if (String.IsNullOrEmpty(Properties.Settings.Default.token))
                    Application.Run(new Authorization());
                else Application.Run(new MainForm());
            }
        }
    }
}
