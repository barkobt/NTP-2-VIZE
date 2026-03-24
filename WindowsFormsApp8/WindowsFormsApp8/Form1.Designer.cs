namespace WindowsFormsApp8
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
            this.txtUrun         = new System.Windows.Forms.TextBox();
            this.nudFiyat        = new System.Windows.Forms.NumericUpDown();
            this.btnEkle         = new System.Windows.Forms.Button();
            this.btnSil          = new System.Windows.Forms.Button();
            this.btnKaydet       = new System.Windows.Forms.Button();
            this.btnDetay        = new System.Windows.Forms.Button();
            this.listBox1        = new System.Windows.Forms.ListBox();
            this.lblToplamBilgi  = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "Urun Adi:";
            //
            // txtUrun
            //
            this.txtUrun.Location = new System.Drawing.Point(80, 15);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(200, 20);
            this.txtUrun.TabIndex = 0;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Text = "Fiyat (TL):";
            //
            // nudFiyat — Fiyat girişi (ondalıklı, max 99999)
            //
            this.nudFiyat.DecimalPlaces = 2;
            this.nudFiyat.Location = new System.Drawing.Point(80, 41);
            this.nudFiyat.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(100, 20);
            this.nudFiyat.TabIndex = 1;
            //
            // btnEkle
            //
            this.btnEkle.Location = new System.Drawing.Point(12, 75);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 25);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            //
            // btnSil — Seçili ürünü sil
            //
            this.btnSil.Location = new System.Drawing.Point(98, 75);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 25);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Secileni Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            //
            // listBox1 — Ürün listesi
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 160);
            this.listBox1.TabIndex = 4;
            //
            // lblToplamBilgi — Toplam tutar ve ürün sayısı
            //
            this.lblToplamBilgi.AutoSize = true;
            this.lblToplamBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblToplamBilgi.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblToplamBilgi.Location = new System.Drawing.Point(12, 285);
            this.lblToplamBilgi.Name = "lblToplamBilgi";
            this.lblToplamBilgi.Text = "Toplam: 0.00 TL  |  0 urun";
            //
            // btnKaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(12, 315);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 27);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet (.txt)";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            //
            // btnDetay — Form2'yi açar
            //
            this.btnDetay.Location = new System.Drawing.Point(140, 315);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(140, 27);
            this.btnDetay.TabIndex = 6;
            this.btnDetay.Text = "Detay Goster (Form2)";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblToplamBilgi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Alisveris Listesi - Urun Girisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblToplamBilgi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
