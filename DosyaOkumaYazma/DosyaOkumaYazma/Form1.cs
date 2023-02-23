using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaOkumaYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\aks4\\Desktop\\!AMP 11A 331 Yekta\\a.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string satir = sr.ReadLine();
            richTextBox1.Text += satir;
            while (satir !=null)
            {
                satir = sr.ReadLine();
                richTextBox1.Text += "\n" + satir;
            }
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\aks4\\Desktop\\!AMP 11A 331 Yekta\\a.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(richTextBox1.Text);
            sw.Close();
            fs.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
        }
    }
}
