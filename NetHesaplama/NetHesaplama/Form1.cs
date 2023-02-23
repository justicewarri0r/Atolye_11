using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double F1, F2, K1, K2, B1, B2, FN, KN, BN = 0;
            F1 = Convert.ToDouble(textBox1.Text);
            F2 = Convert.ToDouble(textBox4.Text);
            K1 = Convert.ToDouble(textBox2.Text);
            K2 = Convert.ToDouble(textBox5.Text);
            B1 = Convert.ToDouble(textBox3.Text);
            B2 = Convert.ToDouble(textBox6.Text);
            FN = F1 - (F2 / 3);
            KN = K1 - (K2 / 3);
            BN = B1 - (B2 / 3);
            textBox7.Text = ($"{FN}");
            textBox8.Text = ($"{KN}");
            textBox9.Text = ($"{BN}");
            Double TP = +(FN * 3) + (BN * 3) + (KN * 3);
            if (TP >= 300)
            {
                MessageBox.Show("KAZANDINIZ",$"Puanınız : {TP}");
            }
            else
            {
                MessageBox.Show("KAYBETTİNİZ",$"Puanınız : {TP}");
            }

        }
    }
}
