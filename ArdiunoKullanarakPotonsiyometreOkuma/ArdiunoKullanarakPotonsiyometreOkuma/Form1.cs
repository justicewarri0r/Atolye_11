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

namespace ArdiunoKullanarakPotonsiyometreOkuma
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
            buttonBaglantıyıKes.Enabled = false;
        }

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPortNo.Text;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                buttonBaglan.Enabled = false;
                buttonBaglantıyıKes.Enabled = true;
                timer1.Enabled = true;
                timer1.Enabled = true;
            }
        }

        private void buttonBaglantıyıKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                buttonBaglan.Enabled = true;
                buttonBaglantıyıKes.Enabled = false;
                timer1.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string gelen = serialPort1.ReadExisting();
                if (gelen.Length > 0)
                {
                    label1.Text = gelen;
                    progressBar1.Value = Convert.ToInt32(gelen);
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
