using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RotaryAxisAnalyzer
{
    
    public partial class Settings : Form
    {
        private GeneralSetting generalST;
        private AutosetSetting autoST;

        public Settings()
        {
            InitializeComponent();
            this.TopMost = true;

            GeneralSetting generalST = new GeneralSetting();
            settingPanel.Controls.Clear();
            generalST.Dock = DockStyle.Fill;
            settingPanel.Controls.Add(generalST);
            //Btn Design

            asBtn.FlatStyle = FlatStyle.Flat;
            asBtn.FlatAppearance.BorderSize = 0;

            gsBtn.FlatStyle = FlatStyle.Flat;
            gsBtn.FlatAppearance.BorderSize = 0;

            

        }


        private void asBtn_Click(object sender, EventArgs e)
        {
            asBtn.BackColor = Color.FromArgb(49, 49, 49);
            asBtn.ForeColor = Color.FromArgb(217, 217, 217);
            gsBtn.BackColor = Color.FromArgb(217, 217, 217);
            gsBtn.ForeColor = Color.FromArgb(49, 49, 49);

            if (autoST == null)
            {
                autoST = new AutosetSetting();
            }
            settingPanel.Controls.Clear();
            autoST.Dock = DockStyle.Fill;
            settingPanel.Controls.Add(autoST);
        }

        private void gsBtn_Click_1(object sender, EventArgs e)
        {
            gsBtn.BackColor = Color.FromArgb(49, 49, 49);
            gsBtn.ForeColor = Color.FromArgb(217, 217, 217);
            asBtn.BackColor = Color.FromArgb(217, 217, 217);
            asBtn.ForeColor = Color.FromArgb(49, 49, 49);

            if (generalST == null)
            {
                generalST = new GeneralSetting();
            }

            settingPanel.Controls.Clear();
            generalST.Dock = DockStyle.Fill;
            settingPanel.Controls.Add(generalST);
        }

        private void settingPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
