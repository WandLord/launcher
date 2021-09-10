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
                    btnPlay.Text = "Update";
                    status = StatusApp.Update;
                }
                else
                {
                    btnPlay.Text = "Play";
                    status = StatusApp.Play;
                }
            }
            else
            {
                btnPlay.Text = "Download";
                status = StatusApp.Download;
            }
            version.Text = Constants.LOCAL_VERSION.ToString();
            btnPlay.Enabled = true;
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
            BtnConfig();

        }
        private void BtnConfig()
        {
            btnWebSite.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnWebSite.Width, btnWebSite.Height, 20, 20));
            btnWebSite.BackColor = Constants.BTN_BG_COLOR;
            btnWebSite.ForeColor = Constants.BTN_TEXT_COLOR;
            btnWebSite.FlatAppearance.BorderSize = 5;

            btnAccount.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnAccount.Width, btnAccount.Height, 20, 20));
            btnAccount.BackColor = Constants.BTN_BG_COLOR;
            btnAccount.ForeColor = Constants.BTN_TEXT_COLOR;
            btnAccount.FlatAppearance.BorderSize = 5;

            btnPatchNotes.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnPatchNotes.Width, btnPatchNotes.Height, 20, 20));
            btnPatchNotes.BackColor = Constants.BTN_BG_COLOR;
            btnPatchNotes.ForeColor = Constants.BTN_TEXT_COLOR;
            btnPatchNotes.FlatAppearance.BorderSize = 5;

            btnPlay.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnPlay.Width, btnPlay.Height, 20, 20));
            btnPlay.BackColor = Constants.BTN_BG_COLOR;
            btnPlay.ForeColor = Constants.BTN_TEXT_COLOR;
            btnPlay.FlatAppearance.BorderSize = 5;
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
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
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