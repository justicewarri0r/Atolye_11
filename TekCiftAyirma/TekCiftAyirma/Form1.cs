using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekCiftAyirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[10];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rnd.Next(1, 99);
                listBox1.Items.Add(sayilar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
                if(sayilar[i] % 2 != 0)
                {
                    listBox3.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
