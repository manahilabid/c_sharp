using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lass_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;
            //data.Text = $"Name:{username},Email{email}";
            this.Hide();

            Form2 f2 = new Form2();
            f2.Name = username;
            f2.email = email;
            f2.Show();
        }
    }
}
