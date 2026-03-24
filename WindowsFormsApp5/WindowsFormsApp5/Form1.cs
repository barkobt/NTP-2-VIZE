using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    /*
       WindowsFormsApp5 — Form1: Öğrenci Not Giriş Ekranı
       ----------------------------------------------------
       Bu form; öğrenci numarası, adı, vize ve final notlarını alır.
       "Ekle" butonu ile listeye ekler, "Kaydet" butonu ile dosyaya kaydeder.
       "Sonuçları Göster" butonu Form2'yi açarak istatistikleri gösterir.

       Dosya Formatı (satır başına 1 öğrenci):
           ÖğrenciNo;AdSoyad;Vize;Final
       Örnek: 12345;Ahmet Yılmaz;70;85
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılınca bilgi etiketi güncellenir:
            lblBilgi.Text = "Henüz öğrenci eklenmedi.";
        }

        /* "Ekle" Butonuna tıklandığında çalışır. */
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Öğrenci numarası veya adı boş bırakılmışsa uyar:
            if (txtNo.Text.Trim() == "" || txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Öğrenci numarası ve adı boş bırakılamaz!", "Eksik Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Metodu burada durdur
            }

            // Girilen bilgileri tek bir satır halinde birleştir:
            // Noktalı virgül (;) ile ayırıyoruz, böylece okurken parçalara bölebileceğiz.
            string satir = txtNo.Text.Trim() + ";" +
                           txtAd.Text.Trim() + ";" +
                           (int)nudVize.Value + ";" +
                           (int)nudFinal.Value;

            // listBox1: Eklenen öğrencileri görsel olarak listelemek için.
            listBox1.Items.Add(satir);

            // Kaç öğrenci eklendiğini bilgi etiketinde göster:
            lblBilgi.Text = "Toplam " + listBox1.Items.Count + " öğrenci eklendi.";

            // Giriş kutularını temizle, bir sonraki öğrenci için hazır hale getir:
            txtNo.Clear();
            txtAd.Clear();
            nudVize.Value  = 0;
            nudFinal.Value = 0;

            // İmleci tekrar öğrenci no kutusuna getir:
            txtNo.Focus();
        }

        /* "Kaydet" Butonuna tıklandığında çalışır. */
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Liste boşsa kaydetme:
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Kaydedilecek öğrenci yok! Önce öğrenci ekleyin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // saveFileDialog1: Dosya kaydetme penceresi (Designer'dan eklendi)
            saveFileDialog1.Title  = "Öğrenci listesini kaydedin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            // Pencereyi aç, kullanıcı "Kaydet"e tıkladıysa devam et:
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // StreamWriter: Dosyaya satır satır yazmayı sağlar.
                // 'using': Blok bitince dosya otomatik kapanır.
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // listBox1'deki her satırı (her öğrenciyi) dosyaya yaz:
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        sw.WriteLine(listBox1.Items[i].ToString());
                    }
                }

                MessageBox.Show(listBox1.Items.Count + " öğrenci başarıyla kaydedildi!\n" +
                                "Dosya: " + saveFileDialog1.FileName,
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Sonuçları Göster" Butonuna tıklandığında çalışır. */
        private void btnForm2_Click(object sender, EventArgs e)
        {
            // Form2'yi oluştur ve aç:
            Form2 f2 = new Form2();

            // ShowDialog(): Form2 kapanana kadar Form1 kilitlenir (modal pencere).
            // Bu sınavda en çok kullanılan çoklu form açma yöntemidir.
            f2.ShowDialog();
        }

        /* "Listeyi Temizle" Butonuna tıklandığında çalışır. */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Kullanıcıya onay sor:
            DialogResult cevap = MessageBox.Show("Tüm liste silinecek. Emin misiniz?",
                                                  "Onay", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                lblBilgi.Text = "Liste temizlendi.";
            }
        }
    }
}
