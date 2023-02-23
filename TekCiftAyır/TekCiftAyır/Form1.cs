using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekCiftAyır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                if (sayi % 2 == 0)
                {
                    Çift.Items.Add(textBox1.Text);
                }
                else
                {
                    Tek.Items.Add(textBox1.Text);
                }
            }
        }
    }
}
