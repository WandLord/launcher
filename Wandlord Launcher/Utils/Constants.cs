using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Wandlord_Launcher.Utils
{
    class Constants
    {
        public static readonly Color BTN_TEXT_COLOR_TOPBAR = Color.FromArgb(253, 192, 55);
        public static readonly Color BTN_BG_COLOR = Color.FromArgb(253, 192, 55); 
        public static readonly Color BTN_TEXT_COLOR = Color.FromArgb(54, 3, 30);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
    }
}
