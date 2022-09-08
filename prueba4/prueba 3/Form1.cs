using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            double numero = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                double n = numero + numero2;
                label3.Text = n.ToString();

            }
            if (checkBox2.Checked == true)
            {
                double n = numero - numero2;
                label3.Text = n.ToString();

            }
            if (checkBox3.Checked == true)
            {
                double n = numero * numero2;
                label3.Text = n.ToString();

            }
            if (checkBox4.Checked == true)
            {
                double n = numero / numero2;
                label3.Text = n.ToString();

            }
        }
    }
}
