namespace FormRenkSecimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRnd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(55, 93);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(45, 104);
            this.trackBarRed.TabIndex = 3;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(106, 93);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(45, 104);
            this.trackBarGreen.TabIndex = 4;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(157, 93);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(45, 104);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.trackBarBlue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBarRed);
            this.groupBox1.Controls.Add(this.trackBarGreen);
            this.groupBox1.Location = new System.Drawing.Point(1067, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RenkSecimi";
            // 
            // buttonRnd
            // 
            this.buttonRnd.Location = new System.Drawing.Point(917, 209);
            this.buttonRnd.Name = "buttonRnd";
            this.buttonRnd.Size = new System.Drawing.Size(144, 64);
            this.buttonRnd.TabIndex = 7;
            this.buttonRnd.Text = "Rastgele";
            this.buttonRnd.UseVisualStyleBackColor = true;
            this.buttonRnd.Click += new System.EventHandler(this.buttonRnd_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1324, 646);
            this.Controls.Add(this.buttonRnd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRnd;
        private System.Windows.Forms.Timer timer1;
    }
}

