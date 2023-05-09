using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Ile_Button_Rengi_Degistrme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPortNo.DataSource = SerialPort.GetPortNames();
            buttonBaglantıKes.Enabled = false;
        }

        private void buttonBaglantıKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                buttonBaglan.Enabled = true;
                buttonBaglantıKes.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPortNo.Text;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                buttonBaglan.Enabled = false;
                buttonBaglantıKes.Enabled = true;
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string gelen = serialPort1.ReadExisting();
                if (gelen == "yak")
                {
                    button1.BackColor = Color.Red;
                }
                else if (gelen == "sondur")
                {
                    button1.BackColor = Color.DarkGray;
                }
                
            }
        }
    }
}
