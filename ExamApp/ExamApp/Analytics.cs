using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class Analytics : Form
    {
        public Analytics(SettingsData data)
        {
            InitializeComponent();

            StringToLabel(data.GetKeysFile(), keysLabel);
            StringToLabel(data.GetProcessesFile(), processesLabel);
        }

        public void StringToLabel(string file, Label label)
        {
            try
            {
                if (!File.Exists(file))
                    return;

                string[] lines = File.ReadAllLines(file);
                string concatenatedText = string.Join(Environment.NewLine, lines);
                label.Text = concatenatedText;
            }
            catch
            { }
        }
    }
}
