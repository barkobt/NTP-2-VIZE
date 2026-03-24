using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    /*
       WindowsFormsApp8: Alışveriş Listesi
       -------------------------------------
       Form1: Ürün adı ve fiyatı girilerek listeye eklenir.
              Liste SaveFileDialog ile .txt dosyasına kaydedilir.
              "Detay" butonu Form2'yi açar.
       Form2: Kaydedilen dosya OpenFileDialog ile açılır.
              Tüm ürünler, toplam tutar ve en pahalı ürün gösterilir.

       Dosya Formatı (her satır bir ürün):
           ÜrünAdı;Fiyat
       Örnek: Süt;12.50

       ÖĞRENILECEK KAVRAMLAR:
       - NumericUpDown ile fiyat girişi (ondalıklı)
       - ListBox ile ürün yönetimi
       - SaveFileDialog ve StreamWriter ile kaydetme
       - İki form arasında geçiş (ShowDialog)
       - Toplamı ve maksimumu hesaplama
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblToplamBilgi.Text = "Toplam: 0.00 TL  |  0 urun";
        }

        /* "Ekle" Butonuna tıklandığında çalışır. */
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ürün adı boş bırakılmışsa uyar:
            if (txtUrun.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen ürün adını girin!", "Eksik Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ürün bilgisini "Ad;Fiyat" formatında birleştir:
            // nudFiyat.Value: NumericUpDown'dan ondalıklı fiyat bilgisi
            // .ToString("F2"): 2 ondalık basamak (12.50 gibi)
            string satir = txtUrun.Text.Trim() + ";" + nudFiyat.Value.ToString("F2");

            // listBox1'e ekle:
            listBox1.Items.Add(satir);

            // Toplam ve ürün sayısını güncelle:
            ToplamGuncelle();

            // Ürün adı kutusunu temizle, fiyatı sıfırla:
            txtUrun.Clear();
            nudFiyat.Value = 0;
            txtUrun.Focus();
        }

        /* ListBox'taki toplam tutarı ve ürün sayısını hesaplayıp gösterir. */
        private void ToplamGuncelle()
        {
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Her satırı ";" den parçala ve fiyat kısmını topla:
                string[] p = listBox1.Items[i].ToString().Split(';');
                if (p.Length >= 2)
                    toplam += Convert.ToDouble(p[1]);
            }
            lblToplamBilgi.Text = "Toplam: " + toplam.ToString("F2") + " TL  |  " +
                                   listBox1.Items.Count + " urun";
        }

        /* "Kaydet (.txt)" Butonuna tıklandığında çalışır. */
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Önce ürün ekleyin!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Title  = "Alisveris listesini kaydedin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i].ToString());
                    }
                }
                MessageBox.Show("Liste kaydedildi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Detay Goster (Form2)" Butonuna tıklandığında çalışır. */
        private void btnDetay_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            // ShowDialog: Form2 kapanana kadar Form1 kilitlenir (modal)
            f2.ShowDialog();
        }

        /* Seçili ürünü listeden sil. */
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                ToplamGuncelle();
            }
        }
    }
}
