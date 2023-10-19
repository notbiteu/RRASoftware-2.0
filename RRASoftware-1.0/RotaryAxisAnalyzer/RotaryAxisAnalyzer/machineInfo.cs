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
    public partial class machineInfo : UserControl
    {
        public machineInfo()
        {
            InitializeComponent();
        }
        public string GetMachName()
        {
            return machNameBox.Text;
        }

        public string GetSNumMach()
        {
            return SNumMachBox.Text;
        }

        public string GetAxis()
        {
            return axisBox.Text;
        }

        public string GetMachManuf()
        {
            return machManufBox.Text;
        }

        public string GetCustName()
        {
            return custNameBox.Text;
        }

        public string GetCompName()
        {
            return compNameBox.Text;
        }
        public string GetMachAddress()
        {
            return machAddressBox.Text;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
