namespace WindowsFormsApp7
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
            this.components    = new System.ComponentModel.Container();
            this.label1        = new System.Windows.Forms.Label();
            this.label2        = new System.Windows.Forms.Label();
            this.nudDeger      = new System.Windows.Forms.NumericUpDown();
            this.comboBox1     = new System.Windows.Forms.ComboBox();
            this.btnDonustur   = new System.Windows.Forms.Button();
            this.lblCTitle     = new System.Windows.Forms.Label();
            this.lblFTitle     = new System.Windows.Forms.Label();
            this.lblKTitle     = new System.Windows.Forms.Label();
            this.lblCelsius    = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblKelvin     = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeger)).BeginInit();
            this.SuspendLayout();
            //
            // label1 — "Değer:" başlığı
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Text = "Deger:";
            //
            // nudDeger — Giriş değeri (ondalıklı, geniş aralık)
            //
            this.nudDeger.DecimalPlaces = 2;
            this.nudDeger.Location = new System.Drawing.Point(70, 15);
            this.nudDeger.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudDeger.Minimum = new decimal(new int[] { 27315, 0, 0, -2146893824 }); // -273.15
            this.nudDeger.Name = "nudDeger";
            this.nudDeger.Size = new System.Drawing.Size(100, 20);
            this.nudDeger.TabIndex = 0;
            //
            // label2 — "Kaynak Birim:" başlığı
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Text = "Birim:";
            //
            // comboBox1 — Celsius / Fahrenheit / Kelvin
            //
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] { "Celsius (C)", "Fahrenheit (F)", "Kelvin (K)" });
            this.comboBox1.Location = new System.Drawing.Point(70, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 1;
            //
            // btnDonustur
            //
            this.btnDonustur.Location = new System.Drawing.Point(12, 75);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(100, 27);
            this.btnDonustur.TabIndex = 2;
            this.btnDonustur.Text = "Donustur";
            this.btnDonustur.UseVisualStyleBackColor = true;
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            //
            // lblCTitle — "Celsius:" başlığı
            //
            this.lblCTitle.AutoSize = true;
            this.lblCTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCTitle.Location = new System.Drawing.Point(12, 125);
            this.lblCTitle.Name = "lblCTitle";
            this.lblCTitle.Text = "Celsius:";
            //
            // lblCelsius — Celsius sonucu
            //
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCelsius.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCelsius.Location = new System.Drawing.Point(120, 123);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Text = "---";
            //
            // lblFTitle — "Fahrenheit:" başlığı
            //
            this.lblFTitle.AutoSize = true;
            this.lblFTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFTitle.Location = new System.Drawing.Point(12, 160);
            this.lblFTitle.Name = "lblFTitle";
            this.lblFTitle.Text = "Fahrenheit:";
            //
            // lblFahrenheit — Fahrenheit sonucu
            //
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFahrenheit.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFahrenheit.Location = new System.Drawing.Point(120, 158);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Text = "---";
            //
            // lblKTitle — "Kelvin:" başlığı
            //
            this.lblKTitle.AutoSize = true;
            this.lblKTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKTitle.Location = new System.Drawing.Point(12, 195);
            this.lblKTitle.Name = "lblKTitle";
            this.lblKTitle.Text = "Kelvin:";
            //
            // lblKelvin — Kelvin sonucu
            //
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblKelvin.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblKelvin.Location = new System.Drawing.Point(120, 193);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Text = "---";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblKTitle);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblFTitle);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblCTitle);
            this.Controls.Add(this.btnDonustur);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDeger);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Sicaklik Donusturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDeger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDeger;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDonustur;
        private System.Windows.Forms.Label lblCTitle;
        private System.Windows.Forms.Label lblFTitle;
        private System.Windows.Forms.Label lblKTitle;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblKelvin;
    }
}
