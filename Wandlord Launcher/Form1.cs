using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wandlord_Launcher.Utils;

namespace Wandlord_Launcher
{
    public partial class Home : Form
    {

        private int mov, movX, movY;


        public Home()
        {
            InitializeComponent();
            InitConfig();
        }

        private void InitConfig()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            btnClose.ForeColor = Constants.BTN_TEXT_COLOR_TOPBAR;
            btnMinimize.ForeColor = Constants.BTN_TEXT_COLOR_TOPBAR;
            this.BackColor = Color.White;
            topBar.BackColor = Color.FromArgb(0, Color.Black);
            version.BackColor = Color.FromArgb(0, Color.Black);
            version.ForeColor = Color.White;
            BtnConfig();

        }
        private void BtnConfig()
        {
            btnWebSite.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnWebSite.Width, btnWebSite.Height, 20, 20));
            btnWebSite.BackColor = Constants.BTN_BG_COLOR;
            btnWebSite.ForeColor = Constants.BTN_TEXT_COLOR;

            btnAccount.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnAccount.Width, btnAccount.Height, 20, 20));
            btnAccount.BackColor = Constants.BTN_BG_COLOR;
            btnAccount.ForeColor = Constants.BTN_TEXT_COLOR;

            btnPatchNotes.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnPatchNotes.Width, btnPatchNotes.Height, 20, 20));
            btnPatchNotes.BackColor = Constants.BTN_BG_COLOR;
            btnPatchNotes.ForeColor = Constants.BTN_TEXT_COLOR;

            btnPlay.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnPlay.Width, btnPlay.Height, 20, 20));
            btnPlay.BackColor = Constants.BTN_BG_COLOR;
            btnPlay.ForeColor = Constants.BTN_TEXT_COLOR;

            btnPathSelect.Region = Region.FromHrgn(Constants.CreateRoundRectRgn(0, 0, btnPathSelect.Width, btnPathSelect.Height, 20, 20));
            btnPathSelect.BackColor = Constants.BTN_BG_COLOR;
            btnPathSelect.ForeColor = Constants.BTN_TEXT_COLOR;
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
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

        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                textPath.Text = folderBrowser.SelectedPath;
                Environment.SpecialFolder root = folderBrowser.RootFolder;
            }
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
    }
}
