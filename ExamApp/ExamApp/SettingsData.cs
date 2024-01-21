using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class SettingsData
    {
        private string keysFile { get; set; }
        private string processesFile { get; set; }

        private string path { get; set; }

        private bool hideToTray { get; set; }

        public SettingsData() {
            SetNewPath(AppDomain.CurrentDomain.BaseDirectory);
            SetHideToTray(false);
        }

        public string GetKeysFile()
        {
            return Path.Combine(path, keysFile);
        }

        public string GetProcessesFile()
        {
            return Path.Combine(path, processesFile);
        }

        public void SetNewPath(string newPath)
        {
            this.path = newPath;
        }

        public void GenerateNewGuids()
        {
            keysFile = $"keys_{Guid.NewGuid()}.txt";
            processesFile = $"processes_{Guid.NewGuid()}.txt";
        }

        public void SetHideToTray(bool isHide)
        {
            this.hideToTray = isHide;
        }

        public bool CheckHideToTrayState()
        {
            return this.hideToTray;
        }
    }
}
