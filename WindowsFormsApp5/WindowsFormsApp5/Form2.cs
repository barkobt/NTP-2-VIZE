using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    /*
       WindowsFormsApp5 — Form2: Öğrenci Sonuç Görüntüleme Ekranı
       ------------------------------------------------------------
       Bu form; Form1 tarafından kaydedilen .txt dosyasını okur ve
       her öğrencinin geçti/kaldı durumunu, sınıf ortalamasını ve
       istatistikleri listeler.

       Dosya Formatı (her satır bir öğrenci):
           ÖğrenciNo;AdSoyad;Vize;Final
    */
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form açılınca istatistik etiketlerini sıfırla:
            lblOrt.Text   = "Sınıf Ort: ---";
            lblGecen.Text = "Geçen: ---";
            lblKalan.Text = "Kalan: ---";
        }

        /* "Dosyayı Aç ve Analiz Et" Butonuna tıklandığında çalışır. */
        private void btnAc_Click(object sender, EventArgs e)
        {
            // Önceki sonuçları temizle:
            listBox1.Items.Clear();
            lblOrt.Text   = "Sınıf Ort: ---";
            lblGecen.Text = "Geçen: ---";
            lblKalan.Text = "Kalan: ---";

            // OpenFileDialog: Dosya seçme penceresi (koddan oluşturuyoruz)
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title  = "Öğrenci dosyasını seçin";
            ofd.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            // Kullanıcı "İptal" tıkladıysa işlemi durdur:
            if (ofd.ShowDialog() != DialogResult.OK) return;

            // File.ReadAllLines: Tüm satırları bir dizi olarak okur.
            string[] satirlar = File.ReadAllLines(ofd.FileName);

            // İstatistik için sayaçlar:
            int    toplamOgrenci = 0;
            int    gecen         = 0;
            int    kalan         = 0;
            double ortalamaToplamı = 0;

            // Her satırı (her öğrenciyi) işle:
            for (int i = 0; i < satirlar.Length; i++)
            {
                // Boş satırları atla (.Trim() baştaki/sondaki boşlukları siler):
                if (satirlar[i].Trim() == "") continue;

                // Split(';'): Satırı noktalı virgülden parçalara böl
                // Örn: "12345;Ahmet;70;85" → ["12345", "Ahmet", "70", "85"]
                string[] parcalar = satirlar[i].Split(';');

                // Yeterli parça yoksa bu satırı atla (bozuk veri koruması):
                if (parcalar.Length < 4) continue;

                string no    = parcalar[0];
                string ad    = parcalar[1];
                double vize  = Convert.ToDouble(parcalar[2]);
                double final = Convert.ToDouble(parcalar[3]);

                // Ağırlıklı ortalama: Vize %40, Final %60
                double ort = (vize * 0.4) + (final * 0.6);

                // Durum belirleme:
                string durum = (ort >= 50) ? "GECTI" : "KALDI";

                // Sayaçları güncelle:
                toplamOgrenci++;
                ortalamaToplamı += ort;
                if (ort >= 50) gecen++;
                else           kalan++;

                // ListBox'a okunabilir format ile ekle:
                // String.Format: Metni belirli bir şablona göre biçimlendirir.
                string gosterim = String.Format("No:{0} | {1} | Vize:{2} Final:{3} | Ort:{4:F1} | {5}",
                                                 no, ad, vize, final, ort, durum);
                listBox1.Items.Add(gosterim);
            }

            // İstatistikleri hesapla ve göster:
            if (toplamOgrenci > 0)
            {
                double sinifOrt = ortalamaToplamı / toplamOgrenci;
                lblOrt.Text   = "Sinif Ort: " + sinifOrt.ToString("F2");
                lblGecen.Text = "Gecen: " + gecen + " ogrenci";
                lblKalan.Text = "Kalan: " + kalan + " ogrenci";
            }
            else
            {
                MessageBox.Show("Dosyada geçerli öğrenci kaydı bulunamadı!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
