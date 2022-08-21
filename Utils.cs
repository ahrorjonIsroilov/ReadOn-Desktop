using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ReadCat
{
    public class Utils
    {
        public static readonly char sep = Path.DirectorySeparatorChar;
        public static readonly String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "ReadCat";
        public static readonly PrivateFontCollection pfc = new PrivateFontCollection();

        public static void copyFilesToAppData(params String[] fileNames)
        {
            _ = ThreadPool.QueueUserWorkItem(copy, fileNames);
        }

        public static void panelCentralization(params Guna2Panel[] p)
        {
            _ = ThreadPool.QueueUserWorkItem(centralizePanel, p);
        }

        public static void formCentralization(params Form[] p)
        {
            _ = ThreadPool.QueueUserWorkItem(centralizeForm, p);
        }

        public static void userControlCentralization(params UserControl[] uc)
        {
            ThreadPool.QueueUserWorkItem(centralizeUserControl, uc);
        }

        public static void clearTextBoxes(params Guna2TextBox[] tb)
        {
            ThreadPool.QueueUserWorkItem(privateClearTextBoxes, tb);
        }

        public static bool validEmail(String email)
        {
            Regex r = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            Match m = r.Match(email);
            return m.Success;
        }
        public static bool validUsername(String username)
        {
            return usernameNotStartDigit(username)
                && usernameMoreThanEight(username)
                && usernameContainsOnlyNumbersAndLettersAndUnderline(username);
        }

        private static bool usernameContainsOnlyNumbersAndLettersAndUnderline(String username)
        {
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c)) return false;
            }
            return true;
        }

        private static bool usernameNotStartDigit(String username)
        {
            return !Char.IsDigit(username[0]);
        }

        private static bool usernameMoreThanEight(String username)
        {
            return username.Length > 3;
        }

        public static bool validPassword(String password)
        {
            return passwordLenghtTrue(password)
                && passwordContainsAnyDigit(password);
        }

        public static bool passwordLenghtTrue(String password)
        {
            return password.Length > 8;
        }
        public static bool passwordContainsAnyDigit(String password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        private static void centralizePanel(Object obj)
        {
            Guna2Panel[] pnls = (Guna2Panel[])obj;
            foreach (Guna2Panel pn in pnls)
                foreach (Control c in pn.Controls)
                    c.Invoke((MethodInvoker)delegate
                    {
                        c.Left = c.Parent.Width / 2 - c.Width / 2;
                    });
        }

        public static void controlLabels(String password, Label passwordVerifierText1, Label passwordVerifierText2)
        {
            passwordVerifierText1.Invoke((MethodInvoker)delegate
            {
                if (Utils.passwordContainsAnyDigit(password))
                {
                    passwordVerifierText1.Text = "✓ must be at least one number";
                    passwordVerifierText1.ForeColor = Color.FromArgb(95, 200, 193);
                }
                else
                {
                    passwordVerifierText1.Text = "must be at least one number";
                    passwordVerifierText1.ForeColor = Color.Tomato;
                }
            });
            passwordVerifierText2.Invoke((MethodInvoker)delegate
            {
                if (Utils.passwordLenghtTrue(password))
                {
                    passwordVerifierText2.Text = "✓ at least 8 characters";
                    passwordVerifierText2.ForeColor = Color.FromArgb(95, 200, 193);
                }
                else
                {
                    passwordVerifierText2.Text = "at least 8 characters";
                    passwordVerifierText2.ForeColor = Color.Tomato;
                }
            });
        }

        private static void paintLabel(Color c, String text, Label label)
        {
            label.ForeColor = c;
            label.Text = text;
        }

        private static void centralizeForm(Object obj)
        {
            Form[] frms = (Form[])obj;
            foreach (Form f in frms)
                foreach (Control c in f.Controls)
                    c.Invoke((MethodInvoker)delegate
                    {
                        c.Left = c.Parent.Width / 2 - c.Width / 2;
                    });
        }

        private static void centralizeUserControl(Object obj)
        {
            UserControl[] frms = (UserControl[])obj;
            foreach (UserControl uc in frms)
                foreach (Control c in uc.Controls)
                    c.Invoke((MethodInvoker)delegate
                    {
                        c.Left = c.Parent.Width / 2 - c.Width / 2;
                    });
        }

        private static void privateClearTextBoxes(Object o)
        {
            Guna2TextBox[] txbs = (Guna2TextBox[])o;
            foreach (Guna2TextBox txb in txbs)
            {
                txb.Invoke((MethodInvoker)delegate { txb.Clear(); });
            }
        }

        private static void copy(Object obj)
        {
            String[] fileNames = (String[])obj;
            try
            {
                foreach (var file in fileNames)
                {
                    File.Copy(file, path + sep + file);
                }
            }
            catch { }
        }
    }
}
