using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxlaDiziDoldurma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        string[] dizi1 = new string[5];

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac < 5)
            { 
            dizi1[sayac] = textBox1.Text;
            textBox1.Clear();
            sayac++;
            }
            else
            {
                MessageBox.Show("DİZİ DOLU", "UYARI");
                textBox1.Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi1.Length; i++)
            {

                listBox1.Items.Add(dizi1[i]);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 0;
            textBox1.Enabled = true;
            listBox1.Items.Clear();
        }
    }
}
