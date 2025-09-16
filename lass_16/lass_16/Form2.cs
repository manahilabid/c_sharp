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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Name;
        public string email;


        public string name
        {
            get { return Name; }
            set { name = value; }

        }
        public string Email
        {
            get { return email; }
            set { Email = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            display.Text = $"welcome{this.name}";
            displayemail.Text = Email;
        }
    }
}
