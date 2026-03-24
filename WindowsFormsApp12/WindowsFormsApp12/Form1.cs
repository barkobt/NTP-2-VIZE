using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    /*
       WindowsFormsApp12: İsim Çekilişi (Şans Uygulaması)
       ----------------------------------------------------
       Katılımcı isimlerini listeye ekler.
       "Cekilisi Yap" butonu listeden rastgele bir isim seçer.
       Seçilen kazanan büyük ve renkli bir etikette gösterilir.
       "Sonucu Kaydet" butonu sonucu SaveFileDialog ile .txt'ye yazar.

       Bu uygulama loto/şans formatına örnektir.

       ÖĞRENILECEK KAVRAMLAR:
       - Random ile rastgele indeks seçme
       - ListBox'tan eleman okuma (Items[index].ToString())
       - SaveFileDialog ile sonuç kaydetme
       - Label rengi ve fontla kazananı vurgulama
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        // Seçilen kazananı sınıf değişkeni olarak tutalım (kaydetmek için gerekli):
        string kazanan = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlangıç durumunu ayarla:
            lblSonuc.Text     = "Kazan: ---";
            lblKatilimci.Text = "Katilimci: 0";
        }

        /* "Listeye Ekle" Butonuna tıklandığında çalışır. */
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // İsim boş bırakılamaz:
            string isim = txtIsim.Text.Trim();
            if (isim == "")
            {
                MessageBox.Show("Lutfen bir isim girin!", "Eksik Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aynı isim zaten listede mi? (büyük-küçük harf duyarsız)
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower() == isim.ToLower())
                {
                    MessageBox.Show("Bu isim zaten listede var!", "Uyari",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Listeye ekle:
            listBox1.Items.Add(isim);

            // Katılımcı sayısını güncelle:
            lblKatilimci.Text = "Katilimci: " + listBox1.Items.Count;

            // Girişi temizle:
            txtIsim.Clear();
            txtIsim.Focus();

            // Kazanan sıfırlansın (yeni liste için):
            kazanan = "";
            lblSonuc.Text      = "Cekilisi bekliyor...";
            lblSonuc.ForeColor = System.Drawing.Color.DimGray;
        }

        /* "Çekilişi Yap" Butonuna tıklandığında çalışır. */
        private void btnCekilis_Click(object sender, EventArgs e)
        {
            // Listede en az 1 isim olmalı:
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Listeye en az 1 katilimci ekleyin!", "Uyari",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Random: 0 ile (listCount-1) arasında rastgele indeks üret
            // new Random(): Her çağrıda farklı sonuç için mümkünse form düzeyinde tutun,
            // ama burada yalın örnekte her tıklamada yeni Random yeterli.
            Random r = new Random();
            int rastgeleIndeks = r.Next(0, listBox1.Items.Count);

            // Kazananı oku:
            kazanan = listBox1.Items[rastgeleIndeks].ToString();

            // Kazananı büyük, renkli etikette göster:
            lblSonuc.Text      = "KAZANAN: " + kazanan;
            lblSonuc.ForeColor = System.Drawing.Color.DarkGreen;

            // Listede kazananı seçili göster:
            listBox1.SelectedIndex = rastgeleIndeks;

            MessageBox.Show("Tebrikler!\n\nKazanan: " + kazanan,
                            "Cekilisi Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* "Sonucu Kaydet" Butonuna tıklandığında çalışır. */
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydetmek için çekiliş yapılmış olmalı:
            if (kazanan == "")
            {
                MessageBox.Show("Once cekilisi yapin, sonra kaydedin!", "Uyari",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SaveFileDialog: Dosya kaydetme penceresi
            saveFileDialog1.Title  = "Cekilisi sonucunu kaydedin";
            saveFileDialog1.Filter = "Metin Dosyasi|*.txt|Tum Dosyalar|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // using bloğu: Dosya yazımı biter bitmez otomatik kapatır
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("=== CEKILISI SONUCLARI ===");
                    sw.WriteLine("Tarih: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                    sw.WriteLine("");
                    sw.WriteLine("--- KATILIMCILAR (" + listBox1.Items.Count + " kisi) ---");

                    // Tüm katılımcıları yaz:
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + listBox1.Items[i].ToString());
                    }

                    sw.WriteLine("");
                    sw.WriteLine("--- KAZANAN ---");
                    sw.WriteLine(kazanan);
                }

                MessageBox.Show("Sonuc kaydedildi!\nDosya: " + saveFileDialog1.FileName,
                                "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Listeyi Temizle" Butonuna tıklandığında çalışır. */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
                "Tum liste ve cekilisi sonucu silinecek. Emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                kazanan           = "";
                lblSonuc.Text     = "Kazan: ---";
                lblSonuc.ForeColor = System.Drawing.Color.DimGray;
                lblKatilimci.Text = "Katilimci: 0";
            }
        }
    }
}
