using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sonuc = sayi1 * sayi2;
            }
            else if(comboBox1.SelectedIndex == 3) /*else if (comboBox1.SelectedItem == "/")*/
            {
                sonuc = sayi1 / sayi2;
            }
            textBox3.Text = sonuc.ToString();
        }
    } 
}
