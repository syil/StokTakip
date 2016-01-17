using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip.UI.Helpers
{
    public static class WindowsApiHelper
    {
        private const uint EM_SETCUEBANNER = 0x1501;
        private const uint CB_SETCUEBANNER = 0x1703; // minimum supported client Windows Vista, minimum supported server Windows Server 2008

        [DllImport("uxtheme.dll")]
        private extern static int SetWindowTheme(IntPtr hWnd,
            [MarshalAs(UnmanagedType.LPWStr)] string pszSubAppName,
            [MarshalAs(UnmanagedType.LPWStr)] string pszSubIdList);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

        public static void SetListViewStyle(ListView listView)
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                return;

            SetWindowTheme(listView.Handle, "explorer", null);
        }

        public static void SetListBoxStyle(ListBox listbox)
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                return;

            SetWindowTheme(listbox.Handle, "explorer", null);
        }

        public static void CueBanner(TextBox textbox, bool showCueWhenFocus, string cueText)
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                return;

            uint BOOL = 0;
            if (showCueWhenFocus) 
                BOOL = 1;

            SendMessage(textbox.Handle, EM_SETCUEBANNER, (IntPtr)BOOL, cueText);
        }

        public static void CueBanner(ComboBox comboBox, bool showCueWhenFocus, string cueText)
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                return;

            uint BOOL = 0;
            if (showCueWhenFocus)
                BOOL = 1;

            SendMessage(comboBox.Handle, CB_SETCUEBANNER, (IntPtr)BOOL, cueText);
        }

        public static void DrawTopBorder(Panel panel, Color borderColor)
        {
            panel.Paint += (sender, e) =>
            {
                Pen pen = new Pen(borderColor);
                Point topLeftPoint = new Point(0, 0);
                Point topRightPoint = new Point(panel.Width, 0);

                e.Graphics.DrawLine(pen, topLeftPoint, topRightPoint);
            };
        }
    }
}
