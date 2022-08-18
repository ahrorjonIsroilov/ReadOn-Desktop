using System;
using System.IO;
using System.Threading;

namespace ReadCat
{
    public class IOUtils
    {
        private readonly char sep = Path.DirectorySeparatorChar;
        private readonly String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "ReadCat";

        public void copyFilesToAppData(params String[] fileNames)
        {
            _ = ThreadPool.QueueUserWorkItem(copy, fileNames);
        }

        private void copy(Object obj)
        {
            String[] fileNames = (String[])obj;
            try
            {
                foreach (var file in fileNames)
                {
                    //MessageBox.Show(file.GetType().Name);
                    File.Copy(file, path + sep + file);
                }
            }
            catch { }
        }
    }
}
