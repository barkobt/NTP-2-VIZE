using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    /*
       WindowsFormsApp10: Metin Analizi
       ----------------------------------
       Form1: Kullanıcı büyük bir TextBox'a metin yazar.
              "Analiz Et" butonu Form2'yi açar ve metni gönderir.
              "Kaydet" butonu metni SaveFileDialog ile dosyaya kaydeder.
       Form2: Gelen metni analiz eder ve sonuçları gösterir:
              - Karakter sayısı
              - Kelime sayısı
              - Cümle sayısı (nokta, !, ? ile biten)
              - En uzun kelime
              - En çok geçen harf

       ÖĞRENILECEK KAVRAMLAR:
       - Büyük TextBox (Multiline=true, ScrollBars=Vertical)
       - Form1'den Form2'ye veri geçirme (public property)
       - Metin analizi (Split ile kelime ayırma)
       - Döngü ile karakter sayma
       - SaveFileDialog ile metin kaydetme
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* "Analiz Et" Butonuna tıklandığında çalışır. */
        private void btnAnalizEt_Click(object sender, EventArgs e)
        {
            // Metin boşsa analiz yapma:
            if (txtMetin.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen analiz edilecek metni girin!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Form2 nesnesini oluştur:
            Form2 f2 = new Form2();

            // Form2'ye metni gönder (public property aracılığıyla):
            // Form2.cs'de 'public string GelenMetin { get; set; }' tanımlandı.
            f2.GelenMetin = txtMetin.Text;

            // ShowDialog: Form2 kapanana kadar Form1 kilitlenir
            f2.ShowDialog();
        }

        /* "Metni Kaydet" Butonuna tıklandığında çalışır. */
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMetin.Text.Trim() == "")
            {
                MessageBox.Show("Kaydedilecek metin yok!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Title  = "Metni kaydedin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // txtMetin.Text: Tüm metni dosyaya yaz
                    sw.Write(txtMetin.Text);
                }
                MessageBox.Show("Metin kaydedildi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Temizle" Butonuna tıklandığında çalışır. */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMetin.Clear();
            txtMetin.Focus();
        }
    }
}
