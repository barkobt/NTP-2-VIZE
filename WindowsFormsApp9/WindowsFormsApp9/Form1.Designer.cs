namespace WindowsFormsApp9
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
            this.components  = new System.ComponentModel.Container();
            this.label1      = new System.Windows.Forms.Label();
            this.txtTahmin   = new System.Windows.Forms.TextBox();
            this.btnTahmin   = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.lblIpucu    = new System.Windows.Forms.Label();
            this.lblDeneme   = new System.Windows.Forms.Label();
            this.lblSure     = new System.Windows.Forms.Label();
            this.timer1      = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "Sayi Tahmin Oyunu (1-100)";
            //
            // lblIpucu — Büyük/Küçük/Doğru ipucu
            //
            this.lblIpucu.AutoSize = true;
            this.lblIpucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblIpucu.ForeColor = System.Drawing.Color.DimGray;
            this.lblIpucu.Location = new System.Drawing.Point(12, 55);
            this.lblIpucu.Name = "lblIpucu";
            this.lblIpucu.Text = "1 ile 100 arasinda bir sayi tuttum...";
            //
            // label1 için yer bırakarak tahmin alanı
            //
            // txtTahmin — Tahmin girişi
            //
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTahmin.Location = new System.Drawing.Point(12, 100);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 29);
            this.txtTahmin.TabIndex = 0;
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnTahmin
            //
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTahmin.Location = new System.Drawing.Point(120, 100);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(100, 29);
            this.btnTahmin.TabIndex = 1;
            this.btnTahmin.Text = "Tahmin Et!";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            //
            // lblDeneme — Deneme sayacı
            //
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDeneme.Location = new System.Drawing.Point(12, 145);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Text = "Deneme: 0";
            //
            // lblSure — Timer'dan gelen süre
            //
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSure.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSure.Location = new System.Drawing.Point(120, 145);
            this.lblSure.Name = "lblSure";
            this.lblSure.Text = "Sure: 0 sn";
            //
            // btnYeniOyun
            //
            this.btnYeniOyun.Location = new System.Drawing.Point(12, 180);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(100, 27);
            this.btnYeniOyun.TabIndex = 2;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            //
            // timer1 — Her 1 saniyede bir Tick çalışır
            //
            this.timer1.Interval = 1000; // 1000 ms = 1 saniye
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblIpucu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Sayi Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label lblIpucu;
        private System.Windows.Forms.Label lblDeneme;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer1;
    }
}
