using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                listBox1.Items.Add(((TextBox)sender).Text);
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            textBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
