using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    /*
       WindowsFormsApp6: Hesap Makinesi (Geçmiş Kayıtlı)
       ---------------------------------------------------
       4 işlem yapabilen (toplama, çıkarma, çarpma, bölme) basit hesap makinesi.
       Her işlem ListBox'taki geçmiş listesine eklenir.
       İstenirse geçmiş "Geçmişi Kaydet" butonu ile .txt dosyasına kaydedilebilir.

       ÖĞRENILECEK KAVRAMLAR:
       - TextBox'tan sayı okuma ve try-catch ile hata yakalama
       - ComboBox ile seçenek sunma (işlem türü seçimi)
       - ListBox'a geçmiş ekleme
       - Sıfıra bölme kontrolü (bölme işleminde özel durum)
       - SaveFileDialog ile geçmişi dosyaya kaydetme
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılınca ComboBox'ın ilk seçeneğini (Toplama) seçili yap:
            comboBox1.SelectedIndex = 0;
        }

        /* "Hesapla" Butonuna tıklandığında çalışır. */
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // try-catch: Kullanıcı sayı yerine harf girerse programın çökmesini önler.
            try
            {
                // txtSayi1 ve txtSayi2: Kullanıcının girdiği sayılar
                double sayi1 = Convert.ToDouble(txtSayi1.Text);
                double sayi2 = Convert.ToDouble(txtSayi2.Text);

                double sonuc = 0;
                string islem = "";

                // comboBox1.SelectedIndex: Seçili işlemin sıra numarası
                // 0 = Toplama, 1 = Çıkarma, 2 = Çarpma, 3 = Bölme
                if (comboBox1.SelectedIndex == 0)
                {
                    sonuc = sayi1 + sayi2;
                    islem = "+";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    sonuc = sayi1 - sayi2;
                    islem = "-";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    sonuc = sayi1 * sayi2;
                    islem = "*";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    // Bölme işleminde sıfıra bölme kontrolü:
                    if (sayi2 == 0)
                    {
                        MessageBox.Show("Sıfıra bölme yapılamaz!", "Matematik Hatası",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Metodu burada durdur
                    }
                    sonuc = sayi1 / sayi2;
                    islem = "/";
                }

                // Sonucu lblSonuc etiketinde göster:
                // ToString("G"): Gereksiz ondalık sıfırları göstermez (örn: 6 değil 6.0000)
                lblSonuc.Text = "Sonuc: " + sonuc.ToString("G");

                // Geçmiş listesine ekle:
                // String.Format: "5 + 3 = 8" formatında metin oluşturur
                string gecmisKaydi = String.Format("{0} {1} {2} = {3}", sayi1, islem, sayi2, sonuc.ToString("G"));
                listBox1.Items.Add(gecmisKaydi);

                // Auto-scroll: Listenin en altına kaydır (son eklenen görünsün):
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            catch
            {
                MessageBox.Show("Lütfen iki sayı giriniz!", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* "Gecmisi Kaydet" Butonuna tıklandığında çalışır. */
        private void btnGecmisiKaydet_Click(object sender, EventArgs e)
        {
            // Liste boşsa kaydetme:
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Kaydedilecek işlem geçmişi yok!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // saveFileDialog1: Dosya kaydetme penceresi
            saveFileDialog1.Title  = "İşlem geçmişini kaydedin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("=== HESAP MAKİNESİ GEÇMİŞİ ===");
                    // listBox1'deki her işlem satırını dosyaya yaz:
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i].ToString());
                    }
                }
                MessageBox.Show("Geçmiş kaydedildi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Gecmisi Temizle" Butonuna tıklandığında çalışır. */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblSonuc.Text = "Sonuc: ---";
        }
    }
}
