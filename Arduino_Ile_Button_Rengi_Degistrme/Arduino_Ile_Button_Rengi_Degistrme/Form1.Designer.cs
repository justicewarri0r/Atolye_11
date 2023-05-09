namespace Arduino_Ile_Button_Rengi_Degistrme
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
            this.comboBoxPortNo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.buttonBaglantıKes = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBoxPortNo
            // 
            this.comboBoxPortNo.FormattingEnabled = true;
            this.comboBoxPortNo.Location = new System.Drawing.Point(308, 59);
            this.comboBoxPortNo.Name = "comboBoxPortNo";
            this.comboBoxPortNo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortNo.TabIndex = 0;
            this.comboBoxPortNo.Text = "COM3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(354, 86);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(75, 23);
            this.buttonBaglan.TabIndex = 2;
            this.buttonBaglan.Text = "Baglan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // buttonBaglantıKes
            // 
            this.buttonBaglantıKes.Location = new System.Drawing.Point(354, 115);
            this.buttonBaglantıKes.Name = "buttonBaglantıKes";
            this.buttonBaglantıKes.Size = new System.Drawing.Size(75, 23);
            this.buttonBaglantıKes.TabIndex = 2;
            this.buttonBaglantıKes.Text = "Baglantı Kes";
            this.buttonBaglantıKes.UseVisualStyleBackColor = true;
            this.buttonBaglantıKes.Click += new System.EventHandler(this.buttonBaglantıKes_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 646);
            this.Controls.Add(this.buttonBaglantıKes);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPortNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPortNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.Button buttonBaglantıKes;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

