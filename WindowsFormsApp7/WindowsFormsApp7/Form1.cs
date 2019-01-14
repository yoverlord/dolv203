using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y;

            if (x <= 3)
            {
                y = (x * x) + 3 * x + 9;
            }
            else
            {
                y = 1 / ((x * x * x) + 6);
            }
            label2.Text = "F(x) = " + Convert.ToString(y);
        }
    }
}
