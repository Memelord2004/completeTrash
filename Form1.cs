using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            string a = i.ToString();
            label1.Text = a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            string a = i.ToString();
            label1.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            string a = i.ToString();
            label1.Text = a;
        }
    }
}
