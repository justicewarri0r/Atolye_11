using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._12._22Tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bas = 0;
        int bit = 0;
        int art = 0;
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            bas = Convert.ToInt32(textBox1.Text);
            bit = Convert.ToInt32(textBox2.Text);
            art = Convert.ToInt32(textBox3.Text);
            string metin = textBox4.Text;
            for (int i = bas; i <= bit; i = i + art)
            {
                listBox1.Items.Add(metin);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
