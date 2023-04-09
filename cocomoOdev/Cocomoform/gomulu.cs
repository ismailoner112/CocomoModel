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
    public partial class Gomulu : Form
    {
        public Gomulu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            


        }
        private void button7_Click(object sender, EventArgs e)
        {
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.Show();
            this.Hide();
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            double a = 3.6;
            double b = 1.20;


            double s;

            s = Convert.ToInt32(txt5.Text);
            double ustAll1 = Math.Pow(s, b);
            result5.Text = (a * ustAll1).ToString();

            txt6.Text = result5.Text;

        }

        private void result5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            double c = 2.5;
            double d = 0.38;

            double k;



            k = Convert.ToDouble(txt6.Text);
            double ustAll3 = Math.Pow(k, d);
            result6.Text = (c * ustAll3).ToString();
        }
    }
}
