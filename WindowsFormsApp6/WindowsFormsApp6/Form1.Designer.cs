namespace WindowsFormsApp6
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
            this.txtSayi1        = new System.Windows.Forms.TextBox();
            this.txtSayi2        = new System.Windows.Forms.TextBox();
            this.comboBox1       = new System.Windows.Forms.ComboBox();
            this.btnHesapla      = new System.Windows.Forms.Button();
            this.btnGecmisiKaydet = new System.Windows.Forms.Button();
            this.btnTemizle      = new System.Windows.Forms.Button();
            this.lblSonuc        = new System.Windows.Forms.Label();
            this.label4          = new System.Windows.Forms.Label();
            this.listBox1        = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "1. Sayi:";
            //
            // txtSayi1
            //
            this.txtSayi1.Location = new System.Drawing.Point(70, 15);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 0;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Text = "2. Sayi:";
            //
            // txtSayi2
            //
            this.txtSayi2.Location = new System.Drawing.Point(70, 41);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 1;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Text = "Islem:";
            //
            // comboBox1 — İşlem seçici: +, -, *, /
            //
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] { "Toplama (+)", "Cikarma (-)", "Carpma (*)", "Bolme (/)" });
            this.comboBox1.Location = new System.Drawing.Point(70, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 2;
            //
            // btnHesapla
            //
            this.btnHesapla.Location = new System.Drawing.Point(12, 100);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(90, 25);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            //
            // lblSonuc — Sonuç etiketi
            //
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSonuc.Location = new System.Drawing.Point(12, 135);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Text = "Sonuc: ---";
            //
            // label4 — "İşlem Geçmişi:" başlığı
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Text = "Islem Gecmisi:";
            //
            // listBox1 — İşlem geçmişi
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 160);
            this.listBox1.TabIndex = 4;
            //
            // btnGecmisiKaydet — SaveFileDialog ile kaydet
            //
            this.btnGecmisiKaydet.Location = new System.Drawing.Point(12, 360);
            this.btnGecmisiKaydet.Name = "btnGecmisiKaydet";
            this.btnGecmisiKaydet.Size = new System.Drawing.Size(130, 25);
            this.btnGecmisiKaydet.TabIndex = 5;
            this.btnGecmisiKaydet.Text = "Gecmisi Kaydet";
            this.btnGecmisiKaydet.UseVisualStyleBackColor = true;
            this.btnGecmisiKaydet.Click += new System.EventHandler(this.btnGecmisiKaydet_Click);
            //
            // btnTemizle
            //
            this.btnTemizle.Location = new System.Drawing.Point(150, 360);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 25);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Gecmisi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGecmisiKaydet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnGecmisiKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
