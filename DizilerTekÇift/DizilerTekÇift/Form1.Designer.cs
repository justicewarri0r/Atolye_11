namespace DizilerTekÇift
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTek = new System.Windows.Forms.Button();
            this.buttonCift = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTek
            // 
            this.buttonTek.Location = new System.Drawing.Point(15, 99);
            this.buttonTek.Name = "buttonTek";
            this.buttonTek.Size = new System.Drawing.Size(100, 42);
            this.buttonTek.TabIndex = 3;
            this.buttonTek.Text = "Tek Sayıları Göster";
            this.buttonTek.UseVisualStyleBackColor = true;
            this.buttonTek.Click += new System.EventHandler(this.buttonTek_Click);
            // 
            // buttonCift
            // 
            this.buttonCift.Location = new System.Drawing.Point(15, 147);
            this.buttonCift.Name = "buttonCift";
            this.buttonCift.Size = new System.Drawing.Size(100, 42);
            this.buttonCift.TabIndex = 4;
            this.buttonCift.Text = "Çift Sayıları Göster";
            this.buttonCift.UseVisualStyleBackColor = true;
            this.buttonCift.Click += new System.EventHandler(this.buttonCift_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(910, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(393, 420);
            this.listBox1.TabIndex = 5;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(15, 195);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(100, 42);
            this.buttonTemizle.TabIndex = 6;
            this.buttonTemizle.Text = "Dizileri Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 644);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCift);
            this.Controls.Add(this.buttonTek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTek;
        private System.Windows.Forms.Button buttonCift;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonTemizle;
    }
}

