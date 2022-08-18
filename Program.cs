using System;
using System.IO;
using System.Windows.Forms;

namespace ReadCat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static readonly char seperator = Path.DirectorySeparatorChar;

        [STAThread]
        static void Main()
        {
            String appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(appData + seperator + "ReadCat"))
                Directory.CreateDirectory(appData + seperator + "ReadCat");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
