using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RotaryAxisAnalyzer
{
    public partial class GeneralSetting : UserControl
    {
        private OpenFileDialog importDataDialog;
        public GeneralSetting()
        {
            InitializeComponent();
            importDataDialog = new OpenFileDialog();
        }
        private void browseButton_Click(object sender, EventArgs e)
        {
            //define path to open as default
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string configFolderName = "RRAConfig";
            string saveSettingFolderName = "SaveSettingRRA";

            string configFolderPath = Path.Combine(documentsPath, configFolderName);
            string saveSettingFolderPath = Path.Combine(configFolderPath, saveSettingFolderName);

            importDataDialog.FileName = "";
            importDataDialog.Filter = "CSV Files|*.csv";
            importDataDialog.InitialDirectory = saveSettingFolderPath;
            importDataDialog.ShowDialog();
        }
    }
}
