using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Wandlord_Launcher.Managers;
using Version = Wandlord_Launcher.Models.Version;


namespace Wandlord_Launcher.Utils
{
    class Constants
    {
        public static readonly Color BTN_TEXT_COLOR_TOPBAR = Color.FromArgb(253, 192, 55);
        public static readonly Color BTN_BG_COLOR = Color.FromArgb(253, 192, 55); 
        public static readonly Color BTN_TEXT_COLOR = Color.FromArgb(54, 3, 30);
        public static readonly string LOCAL_VERSION_PATH = @".version";
        public static readonly string LOCAL_ZIP_GAME_PATH = @"build.zip";
        public static readonly string LOCAL_EXECUTABLE_PATH = @"./wandlord/Wandlord.exe";
        public static readonly string LOCAL_GAME_PATH = @"./wandlord";
        public static readonly string REMOTE_VERSION_URL = "https://drive.google.com/uc?export=download&id=1QTIId7Y86jTO4S-FSgCCVKdQfivWXkYN";
        public static readonly string REMOTE_GAME_URL = "https://www.googleapis.com/drive/v3/files/1e-aRiX6E0uoV2r5CaEZBIbi4SAEmHhUM?alt=media&key=AIzaSyCwSDHuA-hXx8wLHByn3gAem9F-pvyJPrU";
        public static readonly Version DEFAULT_VERSION = new Version("0.0.0");
        public static readonly Manager VERSION_MANAGER = new Manager();
        public static Version LOCAL_VERSION;
        public static Version REMOTE_VERSION;
        public static Home HOME_FORM;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
    }
}
