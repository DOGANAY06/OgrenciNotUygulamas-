using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_Egzersizleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text); //girilen değerleri double çevirdik 
            s2 = Convert.ToDouble(textBox2.Text);
            s3 = Convert.ToDouble(textBox3.Text);
            ort = (s1 + s2 + s3) / 3;

            if (ort>= 50) //50 den büyükse geçer
            {
                durum = "Gecti ";
            }
            else  //50den kücükse kalır 
            {
                durum = "Kaldı";
            }
            textBox4.Text = ort.ToString("0.00") + " / " + durum;
            textBox1.Text = ""; //textleri boşaltıyorum
            textBox2.Text = "";
            textBox3.Text = "";
            //ortalamyı stringe çevirdik sadece virgülden sonraki iki rakamı alarak yaptık
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
