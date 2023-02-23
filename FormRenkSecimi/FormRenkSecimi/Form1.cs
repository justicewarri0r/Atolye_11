using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRenkSecimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonRnd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int red = rnd.Next(0, 255);
            int green = rnd.Next(0, 255);
            int blue = rnd.Next(0, 255);
            trackBarRed.Value = red;
            trackBarGreen.Value = green;
            trackBarBlue.Value = blue;
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int red = rnd.Next(0, 255);
            int green = rnd.Next(0, 255);
            int blue = rnd.Next(0, 255);
            trackBarRed.Value = red;
            trackBarGreen.Value = green;
            trackBarBlue.Value = blue;
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }
    }
}
