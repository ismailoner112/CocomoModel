using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocomoform
{
    public partial class Yarigomulu : Form
    {
        public Yarigomulu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = 3.0;
            double b = 1.12;


            double s;

            s = Convert.ToInt32(txt3.Text);
            double ustAll1 = Math.Pow(s, b);
            result3.Text = (a * ustAll1).ToString();

            txt4.Text = result3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double c = 2.5;
            double d = 0.35;

            double k;



            k = Convert.ToDouble(txt3.Text);
            double ustAll2 = Math.Pow(k, d);
            result4.Text = ( c* ustAll2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.Show();
            this.Hide();
        }

        private void result3_TextChanged(object sender, EventArgs e)
        {

        }

        private void result4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
