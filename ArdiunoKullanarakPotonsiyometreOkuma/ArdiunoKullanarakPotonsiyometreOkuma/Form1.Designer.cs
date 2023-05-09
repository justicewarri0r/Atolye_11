namespace ArdiunoKullanarakPotonsiyometreOkuma
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.buttonBaglantıyıKes = new System.Windows.Forms.Button();
            this.comboBoxPortNo = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(667, 39);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(121, 61);
            this.buttonBaglan.TabIndex = 3;
            this.buttonBaglan.Text = "Baglan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // buttonBaglantıyıKes
            // 
            this.buttonBaglantıyıKes.Location = new System.Drawing.Point(667, 106);
            this.buttonBaglantıyıKes.Name = "buttonBaglantıyıKes";
            this.buttonBaglantıyıKes.Size = new System.Drawing.Size(121, 61);
            this.buttonBaglantıyıKes.TabIndex = 4;
            this.buttonBaglantıyıKes.Text = "Baglantıyı Kes";
            this.buttonBaglantıyıKes.UseVisualStyleBackColor = true;
            this.buttonBaglantıyıKes.Click += new System.EventHandler(this.buttonBaglantıyıKes_Click);
            // 
            // comboBoxPortNo
            // 
            this.comboBoxPortNo.FormattingEnabled = true;
            this.comboBoxPortNo.Location = new System.Drawing.Point(667, 12);
            this.comboBoxPortNo.Name = "comboBoxPortNo";
            this.comboBoxPortNo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortNo.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 25);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(649, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPortNo);
            this.Controls.Add(this.buttonBaglantıyıKes);
            this.Controls.Add(this.buttonBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.Button buttonBaglantıyıKes;
        private System.Windows.Forms.ComboBox comboBoxPortNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

