namespace WindowsFormsApp12
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
            this.txtIsim         = new System.Windows.Forms.TextBox();
            this.btnEkle         = new System.Windows.Forms.Button();
            this.listBox1        = new System.Windows.Forms.ListBox();
            this.lblKatilimci    = new System.Windows.Forms.Label();
            this.btnCekilis      = new System.Windows.Forms.Button();
            this.lblSonuc        = new System.Windows.Forms.Label();
            this.btnKaydet       = new System.Windows.Forms.Button();
            this.btnTemizle      = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            //
            // label1 — "İsim:" başlığı
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "Katilimci Adi:";
            //
            // txtIsim — İsim giriş kutusu
            //
            this.txtIsim.Location = new System.Drawing.Point(100, 15);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(200, 20);
            this.txtIsim.TabIndex = 0;
            //
            // btnEkle — Listeye ekle
            //
            this.btnEkle.Location = new System.Drawing.Point(308, 13);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 24);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Listeye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            //
            // listBox1 — Katılımcı listesi
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 160);
            this.listBox1.TabIndex = 2;
            //
            // lblKatilimci — Katılımcı sayısı
            //
            this.lblKatilimci.AutoSize = true;
            this.lblKatilimci.ForeColor = System.Drawing.Color.DimGray;
            this.lblKatilimci.Location = new System.Drawing.Point(12, 218);
            this.lblKatilimci.Name = "lblKatilimci";
            this.lblKatilimci.Text = "Katilimci: 0";
            //
            // btnCekilis — Çekilişi yap
            //
            this.btnCekilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCekilis.BackColor = System.Drawing.Color.Gold;
            this.btnCekilis.Location = new System.Drawing.Point(12, 245);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(200, 35);
            this.btnCekilis.TabIndex = 3;
            this.btnCekilis.Text = "Cekilisi Yap!";
            this.btnCekilis.UseVisualStyleBackColor = false;
            this.btnCekilis.Click += new System.EventHandler(this.btnCekilis_Click);
            //
            // lblSonuc — Kazanan ismi (büyük, renkli)
            //
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.ForeColor = System.Drawing.Color.DimGray;
            this.lblSonuc.Location = new System.Drawing.Point(12, 295);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Text = "Kazan: ---";
            //
            // btnKaydet — Sonucu kaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(12, 350);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 27);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Sonucu Kaydet (.txt)";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            //
            // btnTemizle — Listeyi temizle
            //
            this.btnTemizle.Location = new System.Drawing.Point(158, 350);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 27);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Listeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 395);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.lblKatilimci);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Isim Cekilisi - Sans Uygulamasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblKatilimci;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
