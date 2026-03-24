using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    /*
       WindowsFormsApp11: Vize-Final Not Takip Defteri
       -------------------------------------------------
       Öğrencilerin adını, vize ve final notlarını tek formda kaydeder.
       Ağırlıklı ortalamayı (Vize %40, Final %60) canlı hesaplar.
       "Kaydet" butonu ile tüm listeyi SaveFileDialog aracılığıyla
       .txt dosyasına yazar.

       Dosya Formatı (her satır bir öğrenci):
           AdSoyad;Vize;Final
       Örnek: Ahmet Kaya;75;88

       ÖĞRENILECEK KAVRAMLAR:
       - NumericUpDown ile not girişi
       - ListBox'ta canlı güncelleme
       - Döngüyle ortalama hesaplama
       - SaveFileDialog ile dosyaya kaydetme
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılınca ortalama etiketini sıfırla:
            lblOrtalama.Text = "Sinif Ort: ---  |  0 ogrenci";
        }

        /* "Ekle" Butonuna tıklandığında çalışır. */
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ad Soyad boş bırakılamaz:
            if (txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Lutfen ogrenci adi girin!", "Eksik Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // "Ad;Vize;Final" formatında birleştir:
            // (int) ile NumericUpDown'ın ondalıklı değerini tam sayıya indir
            string satir = txtAd.Text.Trim() + ";" +
                           (int)nudVize.Value + ";" +
                           (int)nudFinal.Value;

            // Listeye ekle:
            listBox1.Items.Add(satir);

            // Sınıf ortalamasını yeniden hesapla:
            OrtalamaGuncelle();

            // Giriş alanlarını temizle:
            txtAd.Clear();
            nudVize.Value  = 0;
            nudFinal.Value = 0;
            txtAd.Focus();
        }

        /*
           OrtalamaGuncelle(): ListBox'taki tüm öğrencilerin
           ağırlıklı ortalamasını (Vize %40 + Final %60) hesaplar
           ve lblOrtalama etiketinde gösterir.
        */
        private void OrtalamaGuncelle()
        {
            // Hiç öğrenci yoksa etiketi sıfırla:
            if (listBox1.Items.Count == 0)
            {
                lblOrtalama.Text = "Sinif Ort: ---  |  0 ogrenci";
                return;
            }

            double toplamOrt = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Her satırı ";" den parçala:
                // Örnek: "Ahmet Kaya;75;88" → ["Ahmet Kaya", "75", "88"]
                string[] p = listBox1.Items[i].ToString().Split(';');
                if (p.Length < 3) continue;

                // Convert.ToDouble: Metni sayıya çevirir
                double vize  = Convert.ToDouble(p[1]);
                double final = Convert.ToDouble(p[2]);

                // Ağırlıklı ortalama formülü: %40 vize + %60 final
                toplamOrt += (vize * 0.4) + (final * 0.6);
            }

            double sinifOrt = toplamOrt / listBox1.Items.Count;

            // lblOrtalama: Ortalamanın 2 ondalık basamakla gösterimi
            lblOrtalama.Text = "Sinif Ort: " + sinifOrt.ToString("F2") +
                               "  |  " + listBox1.Items.Count + " ogrenci";
        }

        /* Seçili öğrenciyi listeden sil. */
        private void btnSil_Click(object sender, EventArgs e)
        {
            // SelectedIndex: Hiçbir şey seçili değilse -1 döner
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                OrtalamaGuncelle();
            }
            else
            {
                MessageBox.Show("Lutfen silmek istediginiz ogrenciyi secin.", "Secim Yok",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Kaydet (.txt)" Butonuna tıklandığında çalışır. */
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Boş listeyi kaydetme:
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Kaydedilecek ogrenci yok! Once ekleyin.", "Uyari",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SaveFileDialog: Dosyayı nereye kaydedeceğimizi soran pencere
            saveFileDialog1.Title  = "Not listesini kaydedin";
            saveFileDialog1.Filter = "Metin Dosyasi|*.txt|Tum Dosyalar|*.*";

            // ShowDialog() == DialogResult.OK: Kullanıcı "Kaydet"e tıkladı
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // StreamWriter + using: Dosyaya yaz, bittikten sonra otomatik kapat
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // Başlık satırı yaz:
                    sw.WriteLine("=== VIZE-FINAL NOT TAKIP DEFTERI ===");
                    sw.WriteLine("Ad Soyad;Vize;Final");
                    sw.WriteLine("---");

                    // Her öğrenciyi dosyaya yaz:
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i].ToString());
                    }

                    // Özet olarak sınıf ortalamasını da ekle:
                    sw.WriteLine("---");
                    sw.WriteLine(lblOrtalama.Text);
                }

                MessageBox.Show("Liste basariyla kaydedildi!\nDosya: " + saveFileDialog1.FileName,
                                "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Listeyi Temizle" Butonuna tıklandığında çalışır. */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Önce kullanıcıya sor:
            DialogResult cevap = MessageBox.Show(
                "Tum liste silinecek. Emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                OrtalamaGuncelle();
            }
        }
    }
}
