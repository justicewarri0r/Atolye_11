namespace Pizzaci
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
            this.comboBoxHamur = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxBoyut = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxIcecek = new System.Windows.Forms.ComboBox();
            this.comboBoxKenar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxHamur
            // 
            this.comboBoxHamur.FormattingEnabled = true;
            this.comboBoxHamur.Items.AddRange(new object[] {
            "Kalın Hamur",
            "Orta Hamur",
            "İnce Hamur"});
            this.comboBoxHamur.Location = new System.Drawing.Point(6, 78);
            this.comboBoxHamur.Name = "comboBoxHamur";
            this.comboBoxHamur.Size = new System.Drawing.Size(136, 21);
            this.comboBoxHamur.TabIndex = 0;
            this.comboBoxHamur.Text = "Hamur Seçimi Yapınız";
            this.comboBoxHamur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBoxBoyut);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxIcecek);
            this.groupBox1.Controls.Add(this.comboBoxKenar);
            this.groupBox1.Controls.Add(this.comboBoxHamur);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 466);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yekta Pizza";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Siparişiniz";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(460, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 290);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxBoyut
            // 
            this.comboBoxBoyut.FormattingEnabled = true;
            this.comboBoxBoyut.Items.AddRange(new object[] {
            "Büyük Boy",
            "Orta Boy",
            "Küçük Boy"});
            this.comboBoxBoyut.Location = new System.Drawing.Point(6, 38);
            this.comboBoxBoyut.Name = "comboBoxBoyut";
            this.comboBoxBoyut.Size = new System.Drawing.Size(136, 21);
            this.comboBoxBoyut.TabIndex = 5;
            this.comboBoxBoyut.Text = "Pizza Boyunu Seçiniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxIcecek
            // 
            this.comboBoxIcecek.FormattingEnabled = true;
            this.comboBoxIcecek.Items.AddRange(new object[] {
            "Coca Cola",
            "Pepsi",
            "Fanta",
            "Niğde Gazozu",
            "Ayran",
            "Şalgam (Acılı)",
            "Şalgam (Acısız)",
            "Sprite"});
            this.comboBoxIcecek.Location = new System.Drawing.Point(6, 158);
            this.comboBoxIcecek.Name = "comboBoxIcecek";
            this.comboBoxIcecek.Size = new System.Drawing.Size(136, 21);
            this.comboBoxIcecek.TabIndex = 0;
            this.comboBoxIcecek.Text = "İçecek Seçiniz";
            this.comboBoxIcecek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxKenar
            // 
            this.comboBoxKenar.FormattingEnabled = true;
            this.comboBoxKenar.Items.AddRange(new object[] {
            "Ekstra Kalın Kenar",
            "Normal Kalınlıkta Kenar",
            "İnce Kenar"});
            this.comboBoxKenar.Location = new System.Drawing.Point(6, 118);
            this.comboBoxKenar.Name = "comboBoxKenar";
            this.comboBoxKenar.Size = new System.Drawing.Size(136, 21);
            this.comboBoxKenar.TabIndex = 0;
            this.comboBoxKenar.Text = "Kenar seçimi Yapınız";
            this.comboBoxKenar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 646);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHamur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxIcecek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxBoyut;
        private System.Windows.Forms.ComboBox comboBoxKenar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

