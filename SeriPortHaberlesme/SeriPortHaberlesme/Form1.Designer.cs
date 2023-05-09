namespace SeriPortHaberlesme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.comboBoxPortNo = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.buttonBaglantıKes = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 620);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1098, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonGonder
            // 
            this.buttonGonder.ForeColor = System.Drawing.Color.Blue;
            this.buttonGonder.Location = new System.Drawing.Point(1115, 620);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(228, 20);
            this.buttonGonder.TabIndex = 1;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // comboBoxPortNo
            // 
            this.comboBoxPortNo.FormattingEnabled = true;
            this.comboBoxPortNo.Location = new System.Drawing.Point(1224, 12);
            this.comboBoxPortNo.Name = "comboBoxPortNo";
            this.comboBoxPortNo.Size = new System.Drawing.Size(119, 21);
            this.comboBoxPortNo.TabIndex = 2;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "100",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBoxBaud.Location = new System.Drawing.Point(1224, 39);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(119, 21);
            this.comboBoxBaud.TabIndex = 2;
            this.comboBoxBaud.Text = "9600";
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDatabits.Location = new System.Drawing.Point(1224, 66);
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            this.comboBoxDatabits.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDatabits.TabIndex = 2;
            this.comboBoxDatabits.Text = "8";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(1224, 93);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(119, 21);
            this.comboBoxStopBits.TabIndex = 2;
            this.comboBoxStopBits.Text = "1";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comboBoxParity.Location = new System.Drawing.Point(1224, 120);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(119, 21);
            this.comboBoxParity.TabIndex = 2;
            this.comboBoxParity.Text = "None";
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.ForeColor = System.Drawing.Color.Green;
            this.buttonBaglan.Location = new System.Drawing.Point(1115, 147);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(228, 63);
            this.buttonBaglan.TabIndex = 4;
            this.buttonBaglan.Text = "Bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // buttonBaglantıKes
            // 
            this.buttonBaglantıKes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBaglantıKes.Location = new System.Drawing.Point(1115, 216);
            this.buttonBaglantıKes.Name = "buttonBaglantıKes";
            this.buttonBaglantıKes.Size = new System.Drawing.Size(228, 63);
            this.buttonBaglantıKes.TabIndex = 5;
            this.buttonBaglantıKes.Text = "Bağlantıyı Kes";
            this.buttonBaglantıKes.UseVisualStyleBackColor = true;
            this.buttonBaglantıKes.Click += new System.EventHandler(this.buttonBaglantıKes_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1097, 602);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1115, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1115, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Databits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1115, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1115, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parity";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 657);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBaglantıKes);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.comboBoxDatabits);
            this.Controls.Add(this.comboBoxBaud);
            this.Controls.Add(this.comboBoxPortNo);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.ComboBox comboBoxPortNo;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.Button buttonBaglantıKes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

