using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoChoice46C
{
    public partial class Form1 : Form
    {
        string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.FullName;
        private const string FirstRunKey = "FirstRun";
        private const string ConfigFilePath = "config.json";


        public Form1()
        {
            InitializeComponent();
        }

        private List<string> names;


        private async Task LoadNamesAsync(bool forceNameData=false)
        {
            if (File.Exists("rem.dat"))
            {
                names = new List<string>();

                using (StreamReader reader = new StreamReader("rem.dat"))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        names.Add(line);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(parentDirectory))
            {
                ReadNameDat();
            }

            if (forceNameData)
            {
                ReadNameDat();
            }
        }

        private async void ReadNameDat()
        {
            string[] files = Directory.GetFiles(parentDirectory, "name.dat", SearchOption.AllDirectories);

            if (files.Length > 0)
            {
                string fileName = files[0];
                names = new List<string>();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        names.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("找不到名为'name.dat'的文件。请检查名单文件是否丢失。");
            }
        }

        private async Task<List<string>> DrawNamesAsync(int numDraws)
        {
            List<string> results = new List<string>();
            Random random = new Random();
            label2.ForeColor = Color.Black;

            for (int i = 0; i < numDraws; i++)
            {
                await Task.Delay(100);

                int index = random.Next(names.Count);
                string result = names[index];
                results.Add(result);

                label2.Text = result;
            }

            return results;
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            if (names.Count <= 0)
            {
                MessageBox.Show("全部抽取完，已重置");
                await LoadNamesAsync(true);
            }
            List<string> results = await DrawNamesAsync(10);

            label2.ForeColor = Color.LimeGreen;

            UpdateNameLable(results, SpecialNames.DecodeName(SpecialNames.mName), trackBar1.Value);

            if (mOneshotCB.Checked)
            {
                label2.Text = SpecialNames.DecodeName(SpecialNames.mName);
                mOneshotCB.Checked = false;
            }

            if (congModeCB.Checked)
            {
                Cong cong = new Cong();
                cong.name = label2.Text;
                cong.ShowDialog();
            }

            if (noRepeatCB.Checked)
            {
                this.names.Remove(label2.Text);
            }

            label1.Text = $"幸运大抽奖（剩余：{names.Count}）";


            startButton.Enabled = true;
        }

        void UpdateNameLable(List<string> results, string name, int probability)
        {
            Random random = new Random();

            int randomNumber = random.Next(100);

            if (randomNumber < probability)
            {
                label2.Text = name;
            }
            else
            {
                label2.Text = results[9];
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mLabel.Text = $"马哥概率：{trackBar1.Value}%";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //bool isAppRunning = false;
            ////设置一个名称为进程名的互斥体
            //Mutex mutex = new Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out isAppRunning);
            //if (!isAppRunning)
            //{
            //    ShowMessageBoxAndExitAsync();
            //}


            File.Copy($"{Directory.GetCurrentDirectory()}\\Updater.exe", $"{parentDirectory}\\Updater.exe",true);

            // 异步读取名字列表
            await LoadNamesAsync();

            string version = await GetVersion(versionLabel.Text);
            if (version != null)
            {
                linkLabel1.Text = $"发现新版本:{version}";
            }

            ShowWelcomeMessageBox();
        }

        private async void ShowMessageBoxAndExitAsync()
        {
            await Task.Delay(100);

            StartCountdown();

            MessageBox.Show("有一个程序已经在运行，请勿重复运行（");
        }

        private void ShowWelcomeMessageBox()
        {
            AppConfig config = AppConfig.Load(ConfigFilePath);

            // 检查是否是第一次运行
            bool isFirstRun = config.FirstRun;

            if (isFirstRun)
            {
                // 显示欢迎消息框
                UpdateInfo updateInfo = new UpdateInfo();
                updateInfo.ShowDialog();
                // 将第一次运行标志设置为 false
                config.FirstRun = false;
                config.Save(ConfigFilePath);
            }
        }



        private async void StartCountdown()
        {
            await Task.Delay(2000);

            Application.Exit();
        }

        static async Task DelayExit(int milliSencond)
        {
            await Task.Delay(milliSencond);
            Environment.Exit(0);
        }

        static async Task<string> GetVersion(string expectedVersion)
        {
            string url = "https://jvav.sout.eu.org/versions/AC.txt";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    if (response.Trim() != expectedVersion)
                    {
                        return response;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"检查更新时发生错误: {ex.Message}");
                }
            }
            return null;
        }


        

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                Password password = new Password();
                password.Owner = this;
                password.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "帮助")
            {
                HelpWindow helpWindow = new HelpWindow();
                helpWindow.ShowDialog();
            }
            else
            {
                PullUpdater();
            }
        }

        private void PullUpdater()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;

            if (!string.IsNullOrEmpty(parentDirectory))
            {
                string updaterPath = Path.Combine(parentDirectory, "Updater.exe");

                if (File.Exists(updaterPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = updaterPath;
                    startInfo.WorkingDirectory = parentDirectory;

                    Process process = new Process();
                    process.StartInfo = startInfo;
                    process.Start();

                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("找不到更新器。");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "rem.dat";

            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(fileStream);

            foreach (string item in names)
            {
                writer.WriteLine(item);
            }

            writer.Close();
            fileStream.Close();

            if (linkLabel1.Text != "帮助")
            {
                if (MessageBox.Show($"{linkLabel1.Text}是否更新？", "更新提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    PullUpdater();
                }
            }
        }
    }
}
