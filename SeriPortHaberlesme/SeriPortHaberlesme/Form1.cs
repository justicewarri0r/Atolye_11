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

namespace SeriPortHaberlesme
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
            buttonGonder.Enabled = false;
            buttonBaglantıKes.Enabled = false;
        }

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPortNo.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
            serialPort1.DataBits = Convert.ToInt32(comboBoxDatabits.Text);
            if (comboBoxStopBits.Text == "1")
            {
                serialPort1.StopBits = StopBits.One;
            }
            else
            {
                serialPort1.StopBits = StopBits.Two;
            }
            if (comboBoxParity.Text == "None")
            {
                serialPort1.Parity = Parity.None;
            }
            else if (comboBoxParity.Text == "Even")
            {
                serialPort1.Parity = Parity.Even;
            }
            else if (comboBoxParity.Text == "Odd")
            {
                serialPort1.Parity = Parity.Odd;
            }
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                buttonBaglan.Enabled = false;
                buttonBaglantıKes.Enabled = true;
                buttonGonder.Enabled = true;
                timer1.Enabled = true;
            }
        }

        private void buttonBaglantıKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                buttonBaglan.Enabled = true;
                buttonBaglantıKes.Enabled = false;
                buttonGonder.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (textBox1.Text.Length > 0)
                {
                    serialPort1.Write(textBox1.Text);
                    richTextBox1.Text+="Gönderilen : "+textBox1.Text+"\n";
                    textBox1.Clear();
                }
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string gelen = serialPort1.ReadExisting();
                if (gelen.Length > 0)
                {
                    richTextBox1.Text += "Gelen : " + gelen + "\n";
                }
            }
        }
    }
}
