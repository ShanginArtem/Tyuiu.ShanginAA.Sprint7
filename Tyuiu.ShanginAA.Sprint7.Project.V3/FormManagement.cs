using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShanginAA.Sprint7.Project.V3
{
    public partial class FormManagement : Form
    {
        public FormManagement()
        {
            InitializeComponent();
            textBoxManagement_SAA.Multiline = true;        
            textBoxManagement_SAA.ScrollBars = ScrollBars.Vertical;  
            textBoxManagement_SAA.WordWrap = true;         

        }

        private void textBoxManagement_SAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
