using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);
            int kb = b / 1024;
            int b2 = b % 1024;
            MessageBox.Show("Размер файла равен " + Convert.ToString(kb) + " Килобайт " + Convert.ToString(b2) + " Байт ", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
