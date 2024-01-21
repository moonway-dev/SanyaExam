using ExamApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class MainWindow : Form
    {
        private KeyboardHook keyboardHook;
        private SettingsData settingsData = new SettingsData();
        public MainWindow()
        {
            InitializeComponent();
            keyboardHook = new KeyboardHook();
            keyboardHook.KeyStateChanged += OnKeyStateChanged;
        }

        private void OnKeyStateChanged(Keys key, bool keyDown)
        {
            FileSaver(settingsData.GetKeysFile(), $"Кнопка {(keyDown ? "нажата" : "отпущена")}: {key}");
        }

        private void FileSaver(string fileName, string lineToAdd)
        {
            if (!File.Exists(fileName))
            {
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(lineToAdd);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(lineToAdd);
                }
            }
        }

        private void ListProcessesToFile(string filePath)
        {
            try
            {
                Process[] processes = Process.GetProcesses();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var process in processes)
                    {
                        writer.WriteLine($"{process.ProcessName}, {process.Id}");
                    }
                }
            }
            catch
            { }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(keyboardHook.CheckState())
            {
                keyboardHook.Stop();
                startBtn.Text = "СТАРТ";
            }
            else
            {
                if(settingsData.CheckHideToTrayState())
                {
                    notifyIcon.Visible = true;
                    this.ShowInTaskbar = false;
                    this.Hide();
                }

                settingsData.GenerateNewGuids();

                ListProcessesToFile(settingsData.GetProcessesFile());

                keyboardHook.Start();
                startBtn.Text = "СТОП";
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(settingsData);
            settings.Show();
        }

        private void OnTrayClick(object sender, EventArgs e)
        {
            if (keyboardHook.CheckState())
            {
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
                this.Show();
                keyboardHook.Stop();
                startBtn.Text = "СТАРТ";
            }
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics(settingsData);
            analytics.Show();
        }
    }
}
