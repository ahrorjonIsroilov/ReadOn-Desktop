using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadOn
{
    public class AnimationUtils
    {
        public static void centralizeLables(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Left = label.Parent.Width/2 - label.Width/2;
            }
        }
    }
}
