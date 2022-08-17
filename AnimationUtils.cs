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
        private static int order = 1;
        public static void animate(String[] captions, String[] descriptions, Bitmap[] images,Label captiontext,Label descText,Guna2PictureBox picBox,Guna2Transition animator)
        {
            if (order <= 2)
            {
                animator.HideSync(picBox);
                picBox.Image = images[order];
                descText.Text = descriptions[order];
                captiontext.Text = captions[order];
                animator.ShowSync(picBox);
                order++;
            }
            else order = 0;
        }

        public static void centralizeLables(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Left = label.Parent.Width/2 - label.Width/2;
            }
        }
    }
}
