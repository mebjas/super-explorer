using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE
{
    class util
    {
        public static System.Windows.Media.Imaging.BitmapImage GetBitmapFromFile(string path)
        {
            System.Windows.Media.Imaging.BitmapImage img = new System.Windows.Media.Imaging.BitmapImage();
            img.BeginInit();
            // Every path can be represented by an URI
            img.UriSource = new System.Uri(path, System.UriKind.RelativeOrAbsolute);
            img.EndInit();

            return img;
        }
    }
}
