
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
            this.btnWebSite = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnPatchNotes = new System.Windows.Forms.Button();
            this.btnPathSelect = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.topBar.SuspendLayout();
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
            this.btnWebSite.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnWebSite, "btnWebSite");
            this.btnWebSite.Name = "btnWebSite";
            this.btnWebSite.UseVisualStyleBackColor = true;
            this.btnWebSite.Click += new System.EventHandler(this.openWebSite_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnAccount, "btnAccount");
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.Account_Click);
            // 
            // btnPatchNotes
            // 
            this.btnPatchNotes.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnPatchNotes, "btnPatchNotes");
            this.btnPatchNotes.Name = "btnPatchNotes";
            this.btnPatchNotes.UseVisualStyleBackColor = true;
            this.btnPatchNotes.Click += new System.EventHandler(this.PatchNotes_Click);
            // 
            // btnPathSelect
            // 
            this.btnPathSelect.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnPathSelect, "btnPathSelect");
            this.btnPathSelect.Name = "btnPathSelect";
            this.btnPathSelect.UseVisualStyleBackColor = true;
            this.btnPathSelect.Click += new System.EventHandler(this.btnPathSelect_Click);
            // 
            // textPath
            // 
            resources.ApplyResources(this.textPath, "textPath");
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wandlord_Launcher.Properties.Resources.bg_launcher1;
            this.ControlBox = false;
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.btnPathSelect);
            this.Controls.Add(this.btnPatchNotes);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnWebSite);
            this.Controls.Add(this.version);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.topBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button btnWebSite;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnPatchNotes;
        private System.Windows.Forms.Button btnPathSelect;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

