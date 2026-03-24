using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    /*
       WindowsFormsApp7: Sıcaklık Dönüştürücü
       -----------------------------------------
       Celsius, Fahrenheit ve Kelvin birimleri arasında dönüşüm yapar.
       Kullanıcı bir değer girer, kaynak birimi seçer, tüm birimlerdeki
       karşılıkları anında gösterilir.

       DÖNÜŞÜM FORMÜLLERİ:
       - Celsius → Fahrenheit: F = (C * 9/5) + 32
       - Celsius → Kelvin:     K = C + 273.15
       - Fahrenheit → Celsius: C = (F - 32) * 5/9
       - Kelvin → Celsius:     C = K - 273.15

       ÖĞRENILECEK KAVRAMLAR:
       - NumericUpDown ile güvenli sayı girişi (harf girilemez)
       - ComboBox ile seçim yapma
       - Koşullu hesaplama (if-else if zinciri)
       - Label'a hesaplanmış değer yazma
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // İlk açılışta Celsius seçili gelsin:
            comboBox1.SelectedIndex = 0;
        }

        /* "Dönüştür" Butonuna tıklandığında çalışır. */
        private void btnDonustur_Click(object sender, EventArgs e)
        {
            // nudDeger.Value: NumericUpDown'dan güvenli şekilde sayı alınır
            // (double) ile decimal tipini double'a çeviriyoruz
            double deger = (double)nudDeger.Value;

            double celsius    = 0;
            double fahrenheit = 0;
            double kelvin     = 0;

            // Seçilen kaynak birime göre önce Celsius'a çevir, sonra diğerlerini hesapla:
            if (comboBox1.SelectedIndex == 0)
            {
                // Giriş birim: Celsius
                celsius    = deger;
                // Celsius → Fahrenheit: çarpma önce, sonra toplama
                fahrenheit = (celsius * 9.0 / 5.0) + 32;
                // Celsius → Kelvin: sabit ekleme
                kelvin     = celsius + 273.15;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                // Giriş birimi: Fahrenheit
                // Fahrenheit → Celsius: önce 32 çıkar, sonra 5/9 ile çarp
                celsius    = (deger - 32) * 5.0 / 9.0;
                fahrenheit = deger;
                kelvin     = celsius + 273.15;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                // Giriş birimi: Kelvin
                // Kelvin → Celsius: sabit çıkarma
                celsius    = deger - 273.15;
                fahrenheit = (celsius * 9.0 / 5.0) + 32;
                kelvin     = deger;
            }

            // Sonuçları ilgili etiketlere yaz:
            // "F2": 2 ondalık basamak göster (örn: 36.57)
            lblCelsius.Text    = celsius.ToString("F2")    + " C";
            lblFahrenheit.Text = fahrenheit.ToString("F2") + " F";
            lblKelvin.Text     = kelvin.ToString("F2")     + " K";
        }
    }
}
