namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components       = new System.ComponentModel.Container();
            this.button1          = new System.Windows.Forms.Button();
            this.button2          = new System.Windows.Forms.Button();
            this.button3          = new System.Windows.Forms.Button();
            this.button4          = new System.Windows.Forms.Button();
            this.button5          = new System.Windows.Forms.Button();
            this.btnTemizle       = new System.Windows.Forms.Button();
            this.textBox1         = new System.Windows.Forms.TextBox();
            this.textBox2         = new System.Windows.Forms.TextBox();
            this.numericUpDown1   = new System.Windows.Forms.NumericUpDown();
            this.lblKolonSayisi   = new System.Windows.Forms.Label();
            this.saveFileDialog1  = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            //
            // button1 — "Tek Cekilis Yap"
            //
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tek Cekilis Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2 — "Toplu Loto Oyna"
            //
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Toplu Loto Oyna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button3 — "Kolonlari Kaydet" (SaveFileDialog kullanir)
            //
            this.button3.Location = new System.Drawing.Point(12, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kolonlari Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // button4 — "Sonuc Kontrol Et" (Form2'yi acar)
            //
            this.button4.Location = new System.Drawing.Point(12, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sonuc Kontrol Et";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button5 — "Cekilisi Kaydet" (SaveFileDialog kullanir)
            //
            this.button5.Location = new System.Drawing.Point(138, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cekilisi Kaydet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // btnTemizle — Kolonlar listesini temizler (YENİ)
            //
            this.btnTemizle.Location = new System.Drawing.Point(12, 102);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            //
            // textBox2 — Cekilis sonucu (tek satir)
            //
            this.textBox2.Location = new System.Drawing.Point(264, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 6;
            //
            // textBox1 — Loto kolonlari (cok satirli)
            //
            this.textBox1.Location = new System.Drawing.Point(264, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(200, 190);
            this.textBox1.TabIndex = 5;
            //
            // numericUpDown1 — Kac kolon oynanacak?
            //
            this.numericUpDown1.Location = new System.Drawing.Point(138, 44);
            this.numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDown1.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblKolonSayisi — Uretilen kolon sayacı (YENİ)
            //
            this.lblKolonSayisi.AutoSize = true;
            this.lblKolonSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblKolonSayisi.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKolonSayisi.Location = new System.Drawing.Point(138, 70);
            this.lblKolonSayisi.Name = "lblKolonSayisi";
            this.lblKolonSayisi.TabIndex = 9;
            this.lblKolonSayisi.Text = "Kolon: 0";
            //
            // saveFileDialog1
            //
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lblKolonSayisi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Loto Uygulamasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblKolonSayisi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
