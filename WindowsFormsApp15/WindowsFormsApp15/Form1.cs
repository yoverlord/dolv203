using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Сажать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text),po=0,ot=0,z=0;
            for (int i = 1; i <= n; i++)
            {
                int a = rd.Next(-5000, 5000);
                listBox1.Items.Add(a);
                if (a == 0) z++;
                if (a < 0) ot++;
                if (a > 0) po++;
            }
            label2.Text = "Положительных чисел   " + po.ToString() + "  Отрицательные числа  " + ot.ToString() + "  Zero  " + z.ToString();
        }
    }
}
