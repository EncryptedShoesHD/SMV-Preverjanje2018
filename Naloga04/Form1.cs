using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void itemSelected(object sender, EventArgs e)
        {
            label1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
