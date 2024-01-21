using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class Settings : Form
    {
        SettingsData settingsData;
        public Settings(SettingsData data)
        {
            InitializeComponent();
            this.settingsData = data;
            trayCheck.Checked = settingsData.CheckHideToTrayState();
        }

        private void selectPathBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a Folder";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    settingsData.SetNewPath(selectedFolderPath);
                    Console.WriteLine(selectedFolderPath);
                }
            }
        }

        private void OnTrayCheckChange(object sender, EventArgs e)
        {
            settingsData.SetHideToTray(trayCheck.Checked);
        }
    }
}
