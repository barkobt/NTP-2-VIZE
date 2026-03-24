namespace WindowsFormsApp8
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
            this.btnDosyaAc  = new System.Windows.Forms.Button();
            this.listBox1    = new System.Windows.Forms.ListBox();
            this.lblToplam   = new System.Windows.Forms.Label();
            this.lblEnPahali = new System.Windows.Forms.Label();
            this.label1      = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Text = "Alisveris Detay Ekrani";
            //
            // btnDosyaAc
            //
            this.btnDosyaAc.Location = new System.Drawing.Point(12, 40);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(160, 27);
            this.btnDosyaAc.TabIndex = 0;
            this.btnDosyaAc.Text = "Dosyayi Ac ve Yukle";
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            //
            // listBox1
            //
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 200);
            this.listBox1.TabIndex = 1;
            //
            // lblToplam
            //
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplam.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblToplam.Location = new System.Drawing.Point(12, 295);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Text = "Toplam: ---";
            //
            // lblEnPahali
            //
            this.lblEnPahali.AutoSize = true;
            this.lblEnPahali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEnPahali.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnPahali.Location = new System.Drawing.Point(12, 325);
            this.lblEnPahali.Name = "lblEnPahali";
            this.lblEnPahali.Text = "En Pahali: ---";
            //
            // Form2
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 365);
            this.Controls.Add(this.lblEnPahali);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDosyaAc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Alisveris Listesi - Detay";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblEnPahali;
        private System.Windows.Forms.Label label1;
    }
}
