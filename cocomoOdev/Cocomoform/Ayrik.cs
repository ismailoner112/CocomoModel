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
    public partial class Ayrik : Form
    {
        public Ayrik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)                      // ayrık olarak bi form uygulması actık windows form uygulaması forma ekledıgımız her buttona bastıgımza da kendısı ayrık cs olarak bıze sınıf acmısatı zaten acıyor yanı 
        {                                                                           //daha sonra verılen degerler a b c d k ve s verılmıs yanı double olarak yazdık 
            double a = 2.4;                                                         //s= convert kodunda txt1 in textınde genıs bır yer ayırıyoruz verılen degerler double oldugu ıcıın ınt cevırıyoruz 
            double b = 1.05;                                                        //sonrakı satırda ust alma işlemini yapıyoz yaptırıyoruz ust alma işlemini result 1 in text ıne yazıyor deger int oldugu ıcın strınge cevırıyoruz
                                                                                    // 32. satırdakı kodda formulde k bulunduktan sonra zaman formulunde gene kullanılıyor bunu yazdırdık yanı 
            double s;                                                               //tekrar kullanılması ıcın text2 nın textıne result1 ın snucunu yanı bulunan k yı yazdırıyoruz formuldekı k ama 

            s = Convert.ToInt32(txt1.Text);                                         // olum yaptım ama nasıl acıklayacıgımı bılmıyom buraya kadar geldım okıudum ama anlasılır durmuyor onu anladım 

            double ustAll1 = Math.Pow(s, b);
            result1.Text = (a * ustAll1).ToString();

            txt2.Text = result1.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = 2.5;
            double d = 0.38;

            double k;

            

            k = Convert.ToDouble(txt2.Text);
            double ustAll1 = Math.Pow(k, d);
            result2.Text = (c * ustAll1).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa form1 = new AnaSayfa();
            form1.Show();
            this.Hide();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void Ayrik_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
