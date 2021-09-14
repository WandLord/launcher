using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Wandlord_Launcher.Utils;
using System.IO.Compression;
using Version = Wandlord_Launcher.Models.Version;

namespace Wandlord_Launcher.Managers
{
    class Manager
    {
        public string readRemoteVersion()
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString(Constants.REMOTE_VERSION_URL);
        }
        public void DownloadGame()
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFileAsync(new Uri(Constants.REMOTE_GAME_URL), Constants.LOCAL_ZIP_GAME_PATH, Constants.REMOTE_VERSION);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadGameCompletedCallback);
        }
        public void UpdateGame()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadGameCompletedCallback);
            webClient.DownloadFileAsync(new Uri(Constants.REMOTE_GAME_URL), Constants.LOCAL_ZIP_GAME_PATH, Constants.REMOTE_VERSION);
        }
        private void DownloadGameCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
          try
            {
                MessageBox.Show("Estoy dentro");
                Console.WriteLine(Constants.LOCAL_ZIP_GAME_PATH);
                string onlineVersion = ((Version)e.UserState).ToString();
                ZipFile.ExtractToDirectory(Constants.LOCAL_ZIP_GAME_PATH, Directory.GetCurrentDirectory());
                File.Delete(Constants.LOCAL_ZIP_GAME_PATH);
                File.WriteAllText(Constants.LOCAL_VERSION_PATH, onlineVersion);
                Constants.HOME_FORM.CheckStatusApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finishing download: {ex}");
            }
        }
    }
}
