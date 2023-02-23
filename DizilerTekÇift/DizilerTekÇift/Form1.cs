using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerTekÇift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] teksayılar = new int[5];
        int[] ciftsayılar = new int[5];
        int sayactek ;
        int sayaccift ;
        int girilen ;
        private void button1_Click(object sender, EventArgs e)
        {
            girilen=Convert.ToInt32(textBox1.Text);
            if (sayaccift<5)
            {
                if (girilen % 2 == 0)
                {
                    ciftsayılar[sayaccift] = girilen;
                    textBox1.Clear();
                    sayaccift++;
                }
            }
            if (sayactek < 5)
            {
                if (girilen % 2 != 0)
                {
                    teksayılar[sayactek] = girilen;
                    textBox1.Clear();
                    sayactek++;
                }
            }
            if (sayaccift >= 5)
            {
                MessageBox.Show("ÇİFT SAYILAR DİZİSİ DOLU LÜTFEN BAŞKA SAYI GİRMEYİNİZ!!!", "UYARI");
                

            }
            if (sayactek >= 5)
            {
                MessageBox.Show("TEK SAYILAR DİZİSİ DOLU LÜTFEN BAŞKA SAYI GİRMEYİNİZ!!!", "UYARI");


            }

        }

        private void buttonTek_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayactek; i++)
            {

                listBox1.Items.Add(teksayılar[i]);

            }
        }

        private void buttonCift_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayaccift; i++)
            {

                listBox1.Items.Add(ciftsayılar[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayactek = 0;
            sayaccift = 0;
            for (int i = 0; i < ciftsayılar.Length; i++)
            {

                ciftsayılar[i] = 0;

            }
            ciftsayılar[sayaccift] = girilen;
            for (int i = 0; i < teksayılar.Length; i++)
            {

                teksayılar[i] = 0;

            }
        }
    }
}
