using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            button1.Text = "Кнопка 1";
            button2.Text = "Кнопка 2";
            button3.Text = "Кнопка 3";
            button4.Text = "Кнопка 4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 1";
            textBox1.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 2";
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Magenta;
        }
    }
}
