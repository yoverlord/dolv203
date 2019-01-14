using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "еревести";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z;
            listBox1.Items.Add(String.Format("{0,5}{1,20}","x","y"));
            listBox1.Items.Add("---------------------------------------");
            for (double x = 1; x <= 2; x += 0.2)
            {
                z = Math.Sin(x);
                listBox1.Items.Add(String.Format("\r\n{0,-5:F1}{1,20:F2}", x, z));

            }
        }
        }
}
