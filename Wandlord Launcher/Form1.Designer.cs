
namespace Wandlord_Launcher
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.topBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnWebSite = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.Controls.Add(this.btnMinimize);
            this.topBar.Controls.Add(this.btnClose);
            resources.ApplyResources(this.topBar, "topBar");
            this.topBar.Name = "topBar";
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.Name = "version";
            // 
            // btnWebSite
            // 
            this.btnWebSite.BackColor = System.Drawing.Color.Transparent;
            this.btnWebSite.Image = global::Wandlord_Launcher.Properties.Resources.website;
            resources.ApplyResources(this.btnWebSite, "btnWebSite");
            this.btnWebSite.Name = "btnWebSite";
            this.btnWebSite.TabStop = false;
            this.btnWebSite.Tag = "website";
            this.btnWebSite.Click += new System.EventHandler(this.openWebSite_Click);
            this.btnWebSite.MouseEnter += new System.EventHandler(this.changeImage);
            this.btnWebSite.MouseLeave += new System.EventHandler(this.changeImage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "account";
            this.pictureBox1.Click += new System.EventHandler(this.Account_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.changeImage);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.changeImage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Wandlord_Launcher.Properties.Resources.patchNotes;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "patchNotes";
            this.pictureBox2.Click += new System.EventHandler(this.PatchNotes_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.changeImage);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.changeImage);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlay.Image = global::Wandlord_Launcher.Properties.Resources.download;
            resources.ApplyResources(this.pictureBoxPlay, "pictureBoxPlay");
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Tag = "download";
            this.pictureBoxPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.pictureBoxPlay.MouseEnter += new System.EventHandler(this.changeImage);
            this.pictureBoxPlay.MouseLeave += new System.EventHandler(this.changeImage);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wandlord_Launcher.Properties.Resources.BGLAUNCHER;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWebSite);
            this.Controls.Add(this.version);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnWebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.PictureBox btnWebSite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
    }
}

