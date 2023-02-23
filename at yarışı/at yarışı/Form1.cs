using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AT_YARIŞI
{
    public partial class Form1 : Form
    {
        int uzaklık1, uzaklık2, uzaklık3;
        Random rastgelesayi = new Random();
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            uzaklık1 = pictureBox1.Left;
            uzaklık2 = pictureBox2.Left;
            uzaklık3 = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }

            else
            {
                timer1.Stop();
            }
        }
        // <span id="more-1303"></span>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < pictureBox2.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label2.Text = "2. at yarışı önde götürüyor değerli seyirciler.";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                label2.Text = "3. at yarışı önde götürüyor değerli seyirciler";
            }
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label2.Text = "1. at yarışı önde götürüyor değerli seyirciler";
            }
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ücüncüatgenislik = pictureBox3.Width;
            int bitisuzaklıgı = label1.Left;
            //BURADAKİ DEĞERLERİ DEĞİŞTİREREK ATLARIN DAHA YAVAŞ YADA DAHA HIZLI GİTMESİNİ SAĞLAYABİLİRSİNİZ

            pictureBox1.Left += rastgelesayi.Next(2, 15);
            pictureBox2.Left += rastgelesayi.Next(2, 15);
            pictureBox3.Left += rastgelesayi.Next(2, 15);

            if (pictureBox1.Left + pictureBox2.Width > bitisuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("birinci at yarışı kazandı");

            }
            else if (pictureBox2.Left + pictureBox2.Width > bitisuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("ikinci at yarışı kazandı");

            }
            else if (pictureBox3.Left + pictureBox3.Width > bitisuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("üçüncü at yarışı kazandık");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = uzaklık1;
            pictureBox2.Left = uzaklık2;
            pictureBox3.Left = uzaklık3;
            label2.Text = null;
        }

    }

}