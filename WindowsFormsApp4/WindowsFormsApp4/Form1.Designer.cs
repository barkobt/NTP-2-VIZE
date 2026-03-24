namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtVize        = new System.Windows.Forms.TextBox();
            this.label1         = new System.Windows.Forms.Label();
            this.label2         = new System.Windows.Forms.Label();
            this.label3         = new System.Windows.Forms.Label();
            this.lblOrt         = new System.Windows.Forms.Label();
            this.lblDurum       = new System.Windows.Forms.Label();
            this.lbl5           = new System.Windows.Forms.Label();
            this.lblHarf        = new System.Windows.Forms.Label();
            this.label5         = new System.Windows.Forms.Label();
            this.txtFinal       = new System.Windows.Forms.TextBox();
            this.button1        = new System.Windows.Forms.Button();
            this.button2        = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            //
            // txtVize
            //
            this.txtVize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVize.Location = new System.Drawing.Point(112, 73);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(119, 20);
            this.txtVize.TabIndex = 0;
            //
            // label1 — "Vize" yazısı
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(55, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vize";
            //
            // label2 — "Ortalama" başlığı
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(280, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ortalama:";
            //
            // label3 — "Harf Notu" başlığı
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(280, 125);
            this.label3.Name = "label3";
            this.label3.TabIndex = 10;
            this.label3.Text = "Harf Notu:";
            //
            // lblOrt — Ortalama sonucu gösterilir
            //
            this.lblOrt.AutoSize = true;
            this.lblOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOrt.Location = new System.Drawing.Point(390, 73);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(40, 16);
            this.lblOrt.TabIndex = 3;
            this.lblOrt.Text = "---";
            //
            // lblDurum — "Geçti" veya "Kaldı" yazısı
            //
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDurum.Location = new System.Drawing.Point(390, 99);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(40, 16);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "---";
            //
            // lbl5 — "Durum" başlığı
            //
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl5.Location = new System.Drawing.Point(280, 99);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(46, 16);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "Durum:";
            //
            // lblHarf — Harf notu sonucu gösterilir (AA, BB, FF vb.)
            //
            this.lblHarf.AutoSize = true;
            this.lblHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHarf.Location = new System.Drawing.Point(390, 125);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.TabIndex = 11;
            this.lblHarf.Text = "---";
            //
            // label5 — "Final" yazısı
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(55, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Final";
            //
            // txtFinal
            //
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal.Location = new System.Drawing.Point(112, 99);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(119, 20);
            this.txtFinal.TabIndex = 4;
            //
            // button1 — "Hesapla"
            //
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(112, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2 — "Sonucu Kaydet" (SaveFileDialog kullanır)
            //
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.Location = new System.Drawing.Point(112, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sonucu Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // saveFileDialog1
            //
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 230);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Not Hesaplama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
