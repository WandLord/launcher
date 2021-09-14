using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Wandlord_Launcher.Models;
using Wandlord_Launcher.Utils;
using Version = Wandlord_Launcher.Models.Version;

namespace Wandlord_Launcher
{
    public partial class Home : Form
    {

        private int mov, movX, movY;
        private StatusApp status;

        public Home()
        {
            InitializeComponent();
            InitConfig();
            CheckStatusApp();
        }
        private Version checkRemoteVersion()
        {
            return new Version(Constants.VERSION_MANAGER.readRemoteVersion());
        }
        private Version checkLocalVersion()
        {
            if (File.Exists(Constants.LOCAL_VERSION_PATH)) 
            { 
                return new Version(File.ReadAllText(Constants.LOCAL_VERSION_PATH));
            }
            else
            {
                return new Version("0.0.0");
            }
        }
        public void CheckStatusApp()
        {

            Constants.LOCAL_VERSION = checkLocalVersion();
            Constants.REMOTE_VERSION = checkRemoteVersion();
            if (Constants.LOCAL_VERSION.IsDifferentThan(Constants.DEFAULT_VERSION))
            {
                if (Constants.LOCAL_VERSION.IsDifferentThan(Constants.REMOTE_VERSION))
                {
                    pictureBoxPlay.Tag = "update";
                    status = StatusApp.Update;
                }
                else
                {
                    pictureBoxPlay.Text = "play";
                    status = StatusApp.Play;
                }
            }
            else
            {
                pictureBoxPlay.Text = "download";
                status = StatusApp.Download;
            }
            version.Text = Constants.LOCAL_VERSION.ToString();
            pictureBoxPlay.Enabled = true;
        }
        private void InitConfig()
        {
            Constants.HOME_FORM = this;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            btnClose.ForeColor = Constants.BTN_TEXT_COLOR_TOPBAR;
            btnMinimize.ForeColor = Constants.BTN_TEXT_COLOR_TOPBAR;
            this.BackColor = Color.White;
            topBar.BackColor = Color.FromArgb(0, Color.Black);
            version.BackColor = Color.FromArgb(0, Color.Black);
            version.ForeColor = Constants.BTN_BG_COLOR;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void openWebSite_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.wandlord.com");
        }
        private void Account_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.wandlord.com");
        }
        private void PatchNotes_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.wandlord.com");
        }
        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void changeImage(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            string image = (pic.Tag.ToString().Contains("X"))? pic.Tag.ToString().Substring(0, pic.Tag.ToString().Length - 2) : pic.Tag.ToString() + "_X";
            pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(image, Properties.Resources.Culture);
            pic.Tag = image;
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            pictureBoxPlay.Enabled = false;
            switch (status)
            {
                case StatusApp.Play:
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = Path.GetFileName(Constants.LOCAL_EXECUTABLE_PATH);
                    startInfo.WorkingDirectory = Path.GetDirectoryName(Constants.LOCAL_EXECUTABLE_PATH);
                    Process.Start(startInfo);
                    Close();
                    break;
                case StatusApp.Download:
                    Constants.VERSION_MANAGER.DownloadGame();
                    break;
                case StatusApp.Update:
                    Constants.VERSION_MANAGER.UpdateGame();
                    break;
            }
        }
    }
}