using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] fiyatBoyut = { 15, 12, 8 };
            int[] fiyatHamur = { 9, 7, 6 };
            int[] fiyatKenar = { 14, 8, 5 };
            int[] fiyatIcecek = { 10, 9, 10,7,5,7,7,9 };
            int toplam = 0;

            if (comboBoxBoyut.SelectedItem == null || comboBoxKenar.SelectedItem == null || comboBoxHamur.SelectedItem == null || comboBoxIcecek.SelectedItem == null)
            {
                MessageBox.Show("LÜTFEN BÜTÜN SEÇENEKLERİ DOLDURUN");
            }
            else
            {
                listBox1.Items.Add(comboBoxBoyut.SelectedItem);
                listBox1.Items.Add(comboBoxHamur.SelectedItem);
                listBox1.Items.Add(comboBoxKenar.SelectedItem);
                listBox1.Items.Add(comboBoxIcecek.SelectedItem);
            }
            toplam = fiyatBoyut[comboBoxBoyut.SelectedIndex] + fiyatHamur[comboBoxHamur.SelectedIndex] + fiyatKenar[comboBoxKenar.SelectedIndex] + fiyatIcecek[comboBoxIcecek.SelectedIndex];
            textBox1.Text = toplam.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
