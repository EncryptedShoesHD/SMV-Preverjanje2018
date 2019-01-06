using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int stevilo;
                if (!int.TryParse(textBox1.Text, out stevilo))
                {
                    MessageBox.Show("To število ni mogoče pretvoriti.");
                    textBox1.Text = "";
                    startButton.Enabled = false;
                }
                else
                {
                    if (stevilo >= 1 && stevilo <= 100)
                    {
                        startButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Število ni v dovoljenem obsegu!");
                        textBox1.Text = "";
                        startButton.Enabled = false;
                    }
                }
            }else startButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = int.Parse(textBox1.Text);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pristevajOption.Checked)
            {
                if (progressBar1.Value != progressBar1.Maximum)
                {
                    if (progressBar1.Maximum > (progressBar1.Value + progressBar1.Step))
                    {
                        progressBar1.Value += progressBar1.Step;
                    }
                    else {
                        progressBar1.Value = progressBar1.Maximum;
                        startButton.Enabled = false;
                        timer1.Stop();
                    }
                }else
                {
                    startButton.Enabled = false;
                    timer1.Stop();
                }
            }
            else if (odstevajOption.Checked)
            {
                if (progressBar1.Value != progressBar1.Minimum)
                {
                    if (progressBar1.Minimum < (progressBar1.Value - progressBar1.Step))
                    {
                        progressBar1.Value -= progressBar1.Step;
                    }
                    else
                    {
                        progressBar1.Value = progressBar1.Minimum;
                        startButton.Enabled = false;
                        timer1.Stop();
                    }
                }else
                {
                    startButton.Enabled = false;
                    timer1.Stop();
                }
            }
        }
    }
}
