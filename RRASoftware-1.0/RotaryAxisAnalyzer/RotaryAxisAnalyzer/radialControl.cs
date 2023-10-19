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
    public partial class radialControl : UserControl
    {
        public radialControl()
        {
            InitializeComponent();
            synBox.Multiline = true;
            synBox.ReadOnly = true;

            asyBox.Multiline = true;
            asyBox.ReadOnly = true;

            totalBox.Multiline = true;
            totalBox.ReadOnly = true;

            tirxBox.Multiline = true;
            tirxBox.ReadOnly = true;

            tiryBox.Multiline = true;
            tiryBox.ReadOnly = true;

            rpmBox.Multiline = true;
            rpmBox.ReadOnly = true;


        }



    }
}
