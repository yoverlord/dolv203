using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Вывести текс";
            button2.Text = "Стереть текст";
            
            button3.Text = "Сделать недоступной";
            button4.Text = "Сделать видемой";
            button5.Text = "Сделать невмдемой";
            
            button6.Text = "Сделать видемой";
     
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "лраимжзрохыам";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }
    }
}
