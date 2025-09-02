using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = name.Text;
            string pass = secert.Text;
            if (user == "manahil" && pass == "123")
            {
                MessageBox.Show("welcome"+user,"Success");
            }
            else
            {
                MessageBox.Show("invalid"+user,"Error");
            }
        }
    }
}
