using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersise1Loops
{
    public partial class Form1 : Form
    {
        int Number1;
        int Number2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToInt16(textBox1.Text);
            Number2 = Convert.ToInt16(textBox2.Text);
            label1.Text = "";

            while (Number1 <= Number2)
            {
                label1.Text += "" + Number1 + " ";
                Number1++;
            }
        }
    }
}
