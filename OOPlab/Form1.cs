using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPlab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello World";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Label1.Text = "";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
