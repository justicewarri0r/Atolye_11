using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String [] meyveler = { "Muz", "Elma", "Armut", "Mandalina" };
        int[] fiyatlar = { 20, 12, 14, 12 };
        int[] sayilar = { 1, 2, 3, 4, 5 };
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = meyveler;
            comboBox2.DataSource = sayilar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilifiyat = fiyatlar[comboBox1.SelectedIndex];
            int toplamfiyat = secilifiyat * Convert.ToInt32(comboBox2.SelectedItem);
            textBox1.Text = toplamfiyat.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
