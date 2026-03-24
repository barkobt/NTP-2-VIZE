namespace WindowsFormsApp11
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
            this.label1          = new System.Windows.Forms.Label();
            this.label2          = new System.Windows.Forms.Label();
            this.label3          = new System.Windows.Forms.Label();
            this.txtAd           = new System.Windows.Forms.TextBox();
            this.nudVize         = new System.Windows.Forms.NumericUpDown();
            this.nudFinal        = new System.Windows.Forms.NumericUpDown();
            this.btnEkle         = new System.Windows.Forms.Button();
            this.btnSil          = new System.Windows.Forms.Button();
            this.btnKaydet       = new System.Windows.Forms.Button();
            this.btnTemizle      = new System.Windows.Forms.Button();
            this.listBox1        = new System.Windows.Forms.ListBox();
            this.lblOrtalama     = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudVize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinal)).BeginInit();
            this.SuspendLayout();
            //
            // label1 — "Ad Soyad:" başlığı
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "Ad Soyad:";
            //
            // txtAd — Öğrenci adı giriş kutusu
            //
            this.txtAd.Location = new System.Drawing.Point(90, 15);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(220, 20);
            this.txtAd.TabIndex = 0;
            //
            // label2 — "Vize (0-100):" başlığı
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Text = "Vize (0-100):";
            //
            // nudVize — Vize notu (0-100)
            //
            this.nudVize.Location = new System.Drawing.Point(90, 41);
            this.nudVize.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudVize.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudVize.Name = "nudVize";
            this.nudVize.Size = new System.Drawing.Size(60, 20);
            this.nudVize.TabIndex = 1;
            //
            // label3 — "Final (0-100):" başlığı
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Text = "Final (0-100):";
            //
            // nudFinal — Final notu (0-100)
            //
            this.nudFinal.Location = new System.Drawing.Point(90, 67);
            this.nudFinal.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudFinal.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudFinal.Name = "nudFinal";
            this.nudFinal.Size = new System.Drawing.Size(60, 20);
            this.nudFinal.TabIndex = 2;
            //
            // btnEkle — Öğrenciyi listeye ekle
            //
            this.btnEkle.Location = new System.Drawing.Point(12, 102);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 26);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            //
            // btnSil — Seçili öğrenciyi sil
            //
            this.btnSil.Location = new System.Drawing.Point(98, 102);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 26);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Secileni Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            //
            // listBox1 — Eklenen öğrenciler listesi
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 160);
            this.listBox1.TabIndex = 5;
            //
            // lblOrtalama — Sınıf ortalaması (canlı güncellenir)
            //
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOrtalama.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOrtalama.Location = new System.Drawing.Point(12, 315);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Text = "Sinif Ort: ---  |  0 ogrenci";
            //
            // btnKaydet — SaveFileDialog ile kaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(12, 345);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 27);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet (.txt)";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            //
            // btnTemizle — Listeyi temizle
            //
            this.btnTemizle.Location = new System.Drawing.Point(150, 345);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 27);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Listeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 390);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudVize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Vize-Final Not Takip Defteri";
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
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.NumericUpDown nudVize;
        private System.Windows.Forms.NumericUpDown nudFinal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
