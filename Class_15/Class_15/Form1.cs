using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        int num2;
        double result;
        string option;
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           textBox1.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
