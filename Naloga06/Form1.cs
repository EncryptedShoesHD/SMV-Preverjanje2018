using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void indexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            int stPonovitev = 0;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (selected.Equals(comboBox1.GetItemText(comboBox1.Items[i]))) stPonovitev++;
            }
            label1.Text = "Ta vnos se pojavi " + stPonovitev + "-krat.";
        }
    }
}
