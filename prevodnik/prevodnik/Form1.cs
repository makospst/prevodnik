using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prevodnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //binární > decimální
            if (checkBox1.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                int zaklad = Convert.ToInt32(cislo.ToString(), 2);
                textBox2.Text = Convert.ToString(zaklad);
            }
            //binární > hexadecimální
            else if (checkBox2.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                int zaklad = Convert.ToInt32(cislo.ToString(), 2);
                string zakladd = Convert.ToString(zaklad, 16);
                textBox2.Text = zakladd;
            }
            //decimální > binární
            else if (checkBox3.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                string zaklad = Convert.ToString(cislo, 2);
                textBox2.Text = zaklad;
            }
            //decimální > hexadecimální
            else if (checkBox4.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                string zaklad = Convert.ToString(cislo, 16);
                textBox2.Text = zaklad;
            }
            //hexadecimální > binární
            else if (checkBox5.Checked)
            {

            }
            //hexadecimální > decimální
            else if (checkBox6.Checked)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

