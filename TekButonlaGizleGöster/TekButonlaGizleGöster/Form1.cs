using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekButonlaGizleGöster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (listBox1.Visible == true)
                {
                    listBox1.Visible = false;
                button1.Text=("Göster");
                }else
                {
                    listBox1.Visible = true;
                button1.Text = ("Gizle");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }
    }
}
