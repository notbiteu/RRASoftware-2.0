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
    public partial class AutosetSetting : UserControl
    {
        public AutosetSetting()
        {
            InitializeComponent();
        }

        private void DPRstepper_TextChanged(object sender, EventArgs e)
        {

        }

        //for input only 
        private void DPRstepper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaxRPMstepper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void APRstepper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mRPMstepper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaxRPMstepper_TextChanged(object sender, EventArgs e)
        {

        }

        private void APRstepper_TextChanged(object sender, EventArgs e)
        {

        }

        private void mRPMstepper_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(DPRstepper.Text, out double currentValue))
            {
                double newValue = currentValue + 00.10;

                DPRstepper.Text = newValue.ToString("00.00");
            }
        }

        private void decrementBtn1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(DPRstepper.Text, out double currentValue))
            {
                double newValue = currentValue - 00.10;

                DPRstepper.Text = newValue.ToString("00.00");
            }
        }

        private void incrementBtn2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(MaxRPMstepper.Text, out double currentValue))
            {
                double newValue = currentValue + 00.10;

                MaxRPMstepper.Text = newValue.ToString("00.00");
            }
        }

        private void decrementBtn2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(MaxRPMstepper.Text, out double currentValue))
            {
                double newValue = currentValue - 00.10;

                MaxRPMstepper.Text = newValue.ToString("00.00");
            }
        }

        private void incrementBtn3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(APRstepper.Text, out double currentValue))
            {
                double newValue = currentValue + 00.10;

                APRstepper.Text = newValue.ToString("00.00");
            }
        }

        private void decrementBtn3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(APRstepper.Text, out double currentValue))
            {
                double newValue = currentValue - 00.10;

                APRstepper.Text = newValue.ToString("00.00");
            }
        }

        private void incrementBtn4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(mRPMstepper.Text, out double currentValue))
            {
                double newValue = currentValue + 00.10;

                mRPMstepper.Text = newValue.ToString("00.00");
            }
        }

        private void decrementBtn4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(mRPMstepper.Text, out double currentValue))
            {
                double newValue = currentValue - 00.10;

                mRPMstepper.Text = newValue.ToString("00.00");
            }
        }
    }
}
