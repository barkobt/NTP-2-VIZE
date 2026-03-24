namespace WindowsFormsApp5
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
            this.components      = new System.ComponentModel.Container();
            this.label1          = new System.Windows.Forms.Label();
            this.label2          = new System.Windows.Forms.Label();
            this.label3          = new System.Windows.Forms.Label();
            this.label4          = new System.Windows.Forms.Label();
            this.txtNo           = new System.Windows.Forms.TextBox();
            this.txtAd           = new System.Windows.Forms.TextBox();
            this.nudVize         = new System.Windows.Forms.NumericUpDown();
            this.nudFinal        = new System.Windows.Forms.NumericUpDown();
            this.btnEkle         = new System.Windows.Forms.Button();
            this.btnKaydet       = new System.Windows.Forms.Button();
            this.btnForm2        = new System.Windows.Forms.Button();
            this.btnTemizle      = new System.Windows.Forms.Button();
            this.listBox1        = new System.Windows.Forms.ListBox();
            this.lblBilgi        = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).BeginInit();
            this.SuspendLayout();
            //
            // label1 — "Öğrenci No:" başlığı
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "Öğrenci No:";
            //
            // txtNo — Öğrenci numarası giriş kutusu
            //
            this.txtNo.Location = new System.Drawing.Point(100, 15);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(120, 20);
            this.txtNo.TabIndex = 0;
            //
            // label2 — "Ad Soyad:" başlığı
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Text = "Ad Soyad:";
            //
            // txtAd — Ad soyad giriş kutusu
            //
            this.txtAd.Location = new System.Drawing.Point(100, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 1;
            //
            // label3 — "Vize (0-100):" başlığı
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Text = "Vize (0-100):";
            //
            // nudVize — Vize notu seçici (0-100 arası)
            //
            this.nudVize.Location = new System.Drawing.Point(100, 67);
            this.nudVize.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudVize.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudVize.Name = "nudVize";
            this.nudVize.Size = new System.Drawing.Size(60, 20);
            this.nudVize.TabIndex = 2;
            //
            // label4 — "Final (0-100):" başlığı
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Text = "Final (0-100):";
            //
            // nudFinal — Final notu seçici (0-100 arası)
            //
            this.nudFinal.Location = new System.Drawing.Point(100, 93);
            this.nudFinal.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudFinal.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudFinal.Name = "nudFinal";
            this.nudFinal.Size = new System.Drawing.Size(60, 20);
            this.nudFinal.TabIndex = 3;
            //
            // btnEkle — Listeye öğrenci ekle
            //
            this.btnEkle.Location = new System.Drawing.Point(12, 125);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 25);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            //
            // btnKaydet — SaveFileDialog ile dosyaya kaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(108, 125);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 25);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet (.txt)";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            //
            // btnForm2 — Form2'yi aç (sonuç ekranı)
            //
            this.btnForm2.Location = new System.Drawing.Point(12, 157);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(130, 25);
            this.btnForm2.TabIndex = 6;
            this.btnForm2.Text = "Sonuclari Goster";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            //
            // btnTemizle — Listeyi temizle
            //
            this.btnTemizle.Location = new System.Drawing.Point(148, 157);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 25);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            //
            // listBox1 — Eklenen öğrenciler burada listelenir
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 160);
            this.listBox1.TabIndex = 8;
            //
            // lblBilgi — Kaç öğrenci eklendiği bilgisi
            //
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.ForeColor = System.Drawing.Color.DimGray;
            this.lblBilgi.Location = new System.Drawing.Point(12, 370);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Text = "Henüz öğrenci eklenmedi.";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudVize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ogrenci Not Kayit Sistemi - Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.NumericUpDown nudVize;
        private System.Windows.Forms.NumericUpDown nudFinal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
