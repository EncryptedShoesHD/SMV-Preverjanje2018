﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formShown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void buttonNaredi_Click(object sender, EventArgs e)
        {
            if(dodajOption.Checked)
            {
                if (textBox1.Text != "")
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }else if(brisiOption.Checked)
            {
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    comboBox1.Items.Remove(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else label1.Text = "Elementa ni v ComboBoxu.";
            }
        }
    }
}
