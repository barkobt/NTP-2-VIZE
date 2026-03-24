namespace WindowsFormsApp5
{
    partial class Form2
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
            this.btnAc    = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblOrt   = new System.Windows.Forms.Label();
            this.lblGecen = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.label1   = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1 — Başlık bilgisi
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Text = "Ogrenci Sonuc Listesi";
            //
            // btnAc — Dosya aç ve analiz et
            //
            this.btnAc.Location = new System.Drawing.Point(12, 40);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(180, 27);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Dosyayi Ac ve Analiz Et";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            //
            // listBox1 — Öğrenci listesi: No | Ad | Notlar | Ortalama | Durum
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(560, 200);
            this.listBox1.TabIndex = 1;
            //
            // lblOrt — Sınıf ortalaması
            //
            this.lblOrt.AutoSize = true;
            this.lblOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOrt.Location = new System.Drawing.Point(12, 295);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Text = "Sinif Ort: ---";
            //
            // lblGecen — Geçen öğrenci sayısı
            //
            this.lblGecen.AutoSize = true;
            this.lblGecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblGecen.ForeColor = System.Drawing.Color.Green;
            this.lblGecen.Location = new System.Drawing.Point(12, 320);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Text = "Gecen: ---";
            //
            // lblKalan — Kalan öğrenci sayısı
            //
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblKalan.ForeColor = System.Drawing.Color.Red;
            this.lblKalan.Location = new System.Drawing.Point(12, 345);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Text = "Kalan: ---";
            //
            // Form2
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 380);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblGecen);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Ogrenci Not Sistemi - Sonuclar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblGecen;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label label1;
    }
}
