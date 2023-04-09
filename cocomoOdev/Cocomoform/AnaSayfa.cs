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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayrik ayrik = new Ayrik();
            ayrik.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yarigomulu yarıgomulu = new Yarigomulu();
            yarıgomulu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gomulu gomulu = new Gomulu();
            gomulu.Show();
            this.Hide();
        }
    }
}
