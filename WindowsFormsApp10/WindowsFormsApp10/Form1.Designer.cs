namespace WindowsFormsApp10
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
            this.txtMetin        = new System.Windows.Forms.TextBox();
            this.btnAnalizEt     = new System.Windows.Forms.Button();
            this.btnKaydet       = new System.Windows.Forms.Button();
            this.btnTemizle      = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Text = "Metninizi asagiya girin:";
            //
            // txtMetin — Büyük, çok satırlı metin girişi
            //
            this.txtMetin.Location = new System.Drawing.Point(12, 40);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetin.Size = new System.Drawing.Size(500, 250);
            this.txtMetin.TabIndex = 0;
            //
            // btnAnalizEt — Form2'yi açar
            //
            this.btnAnalizEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAnalizEt.Location = new System.Drawing.Point(12, 305);
            this.btnAnalizEt.Name = "btnAnalizEt";
            this.btnAnalizEt.Size = new System.Drawing.Size(140, 30);
            this.btnAnalizEt.TabIndex = 1;
            this.btnAnalizEt.Text = "Analiz Et (Form2)";
            this.btnAnalizEt.UseVisualStyleBackColor = true;
            this.btnAnalizEt.Click += new System.EventHandler(this.btnAnalizEt_Click);
            //
            // btnKaydet — SaveFileDialog ile kaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(160, 305);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 30);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Metni Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            //
            // btnTemizle
            //
            this.btnTemizle.Location = new System.Drawing.Point(288, 305);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 30);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 355);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAnalizEt);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Metin Analizi - Giris";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnAnalizEt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
