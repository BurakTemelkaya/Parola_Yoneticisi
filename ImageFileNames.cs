using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parola_Yoneticisi
{
    public static class ImageFileNames
    {
        public static Image GetShowPasswordImage()
        {
            return Image.FromFile(Application.StartupPath + @"\Icons\Show_Password.png");
        }

        public static Image GetDontShowPasswordImage()
        {
            return Image.FromFile(Application.StartupPath + @"\Icons\Dont't_Show_Password.png");
        }

        public static Image GetRefreshImage()
        {
            return Image.FromFile(Application.StartupPath + @"\Icons\refresh.png");
        }

        public static Image GetCloseImage()
        {
            return Image.FromFile(Application.StartupPath + @"\Icons\close.png");
        }
    }
}
