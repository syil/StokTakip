using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.UI.Helpers
{
    public class ImageHelper
    {
        public static Bitmap GetSolidImage(Color fillColor, Size imageSize)
        {
            Bitmap bmp = new Bitmap(imageSize.Width, imageSize.Height);

            for (int x = 0; x < imageSize.Width; x++)
            {
                for (int y = 0; y < imageSize.Height; y++)
                {
                    bmp.SetPixel(x, y, fillColor);
                }
            }

            return bmp;
        }
    }
}
