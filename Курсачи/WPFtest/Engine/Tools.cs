using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace WPFtest.Engine
{
    public class Tools
    {
        public static BitmapImage ConvertIMG(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }
}
