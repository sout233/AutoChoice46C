using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZipExtractor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Updater
{
    public partial class Form1 : Form
    {
        private const string DOWNLOAD_URL = "https://list.sout.eu.org/api/raw/?path=/AC_lastest.7z";
        private string binPath = Path.Combine(Application.StartupPath, "bin");

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DownloadAndExtractUpdateAsync();

            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(Application.StartupPath, "bin", "AutoChoice46C.exe");
            startInfo.WorkingDirectory = Path.Combine(Application.StartupPath, "bin");

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            Application.Exit();
        }
        private async Task DownloadAndExtractUpdateAsync()
        {
            string downloadPath = Path.Combine(Application.StartupPath, "update.7z");
            string extractPath = Application.StartupPath;

            try
            {
                if (File.Exists(downloadPath))
                {
                    File.Delete(downloadPath);
                }

                using (WebClient client = new WebClient())
                {
                    client.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                    await client.DownloadFileTaskAsync(new Uri(DOWNLOAD_URL), downloadPath);
                    client.DownloadProgressChanged -= WebClient_DownloadProgressChanged;
                }


                if (Directory.Exists(binPath))
                {
                    string[] files = Directory.GetFiles(binPath);

                    foreach (string filePath in files)
                    {
                        File.Delete(filePath);
                    }

                    Console.WriteLine("所有文件删除成功。");
                }

                if (Directory.Exists(binPath))
                {
                    Directory.Delete(binPath, true);
                }

                using (ArchiveFile archiveFile = new ArchiveFile(downloadPath))
                {
                    archiveFile.Extract(extractPath);
                }

                File.Delete(downloadPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新过程中发生错误：{ex.Message}");
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            label1.Text = $"一眼更新，鉴定为：{e.ProgressPercentage}%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
