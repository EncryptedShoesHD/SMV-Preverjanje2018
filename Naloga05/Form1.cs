using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
                label1.Text = "";
            }
        }

        private void buttonZbriši_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Remove(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
                label1.Text = "";
            }
            else label1.Text = "Elementa ni v ListBoxu.";
        }

        private void formShown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
