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
    public partial class testInfoPage : UserControl
    {
        public testInfoPage()
        {
            InitializeComponent();
        }
        public string GetTestTitle()
        {
            return testTitleBox.Text;
        }

        public string GetOperatorName()
        {
            return operatorNameBox.Text;
        }

        public string GetNotes()
        {
            return notesBox.Text;
        }
    }
}
