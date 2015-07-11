using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.UI.Helpers
{
    public class IconHelper : IDisposable
    {
        private Dictionary<string, Icon> cachedIcons;

        public IconHelper()
        {
            cachedIcons = new Dictionary<string, Icon>();
        }

        public Icon GetSolidIcon(Color fillColor, Size iconSize)
        {
            string iconName = GenerateNameForIcon(fillColor, iconSize);

            if (cachedIcons.ContainsKey(iconName))
            {
                return cachedIcons[iconName];
            }
            else
            {
                using (Bitmap bmp = ImageHelper.GetSolidImage(fillColor, iconSize))
                {
                    var icon = Icon.FromHandle(bmp.GetHicon());
                    cachedIcons.Add(iconName, icon);

                    return icon; 
                }
            }
        }

        private string GenerateNameForIcon(Color fillColor, Size iconSize)
        {
            return string.Format("{0}{1}", fillColor, iconSize);
        }

        public void Dispose()
        {
            cachedIcons.Clear();
        }
    }
}
