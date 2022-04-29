using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp7a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double k = 1;
            double s = 0;
            int a = Convert.ToInt32((textBox1.Text));

            for (int i = 0; i < a; i++)
            {


                if (i % 2 == 0)
                {
                    s = s + 4 / k;
                }
                else
                {


                    s = s - 4 / k;
                }

                k = k + 2;
            }

            label1.Text = "Approximate value of PI after " + a + "  Terms" + "\n" + "=" + s.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}