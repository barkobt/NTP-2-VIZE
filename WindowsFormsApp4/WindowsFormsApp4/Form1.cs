using System;
using System.IO;          // Dosya kaydetme için gerekli kütüphane
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    /*
       WindowsFormsApp4: Not Hesaplama Uygulaması
       ------------------------------------------
       Kullanıcının vize ve final notlarını girdiği, ağırlıklı ortalamanın
       hesaplandığı ve harf notunun belirlendiği basit bir Windows Forms uygulaması.

       Formül: Ortalama = (Vize * 0.4) + (Final * 0.6)
       Harf Notu: AA (90+), BA (85+), BB (75+), CB (70+), CC (60+),
                  DC (55+), DD (50+), FF (50 altı)
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Tasarım ekranında eklediğimiz tüm kontrolleri (Label, TextBox, Button vb.)
            // hazır hale getirir. Bu satır olmadan form boş görünür.
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form ilk açıldığında yapılacak işlemler buraya yazılır.
            // Başlangıçta sonuç etiketlerini sıfırlıyoruz.
            lblOrt.Text   = "---";
            lblHarf.Text  = "---";
            lblDurum.Text = "---";
        }

        /* "Hesapla" Butonuna tıklandığında çalışır. */
        private void button1_Click(object sender, EventArgs e)
        {
            // try-catch: Kullanıcı sayı yerine harf girerse programın çökmesini önler.
            try
            {
                // txtVize.Text → kullanıcının yazdığı metin (örn: "75")
                // Convert.ToDouble → o metni gerçek sayıya çevirir (75.0)
                double vize  = Convert.ToDouble(txtVize.Text);
                double final = Convert.ToDouble(txtFinal.Text);

                // Girilen notların 0-100 arasında olup olmadığını kontrol et:
                if (vize < 0 || vize > 100 || final < 0 || final > 100)
                {
                    MessageBox.Show("Notlar 0 ile 100 arasında olmalıdır!", "Geçersiz Değer",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Metodu burada durdur, aşağıya gitme
                }

                // Ağırlıklı ortalama hesaplama:
                // Vize %40, Final %60 katkı sağlar.
                double ortalama = (vize * 0.4) + (final * 0.6);

                // lblOrt: Ortalama sonucunu gösteren etiket.
                // ToString("F2"): Sayıyı 2 ondalık basamakla gösterir (örn: 72.50)
                lblOrt.Text = ortalama.ToString("F2");

                // Harf notunu hesapla ve lblHarf etiketine yaz:
                lblHarf.Text = HarfNotuHesapla(ortalama);

                // 50 ve üzeri = Geçti, altı = Kaldı
                if (ortalama >= 50)
                {
                    lblDurum.Text = "Geçti";
                    // ForeColor: Yazı rengini yeşil yap
                    lblDurum.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblDurum.Text = "Kaldı";
                    // ForeColor: Yazı rengini kırmızı yap
                    lblDurum.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                // Hata oluşursa (örn: boş bırakıldı veya harf yazıldı) bu blok çalışır.
                MessageBox.Show("Lütfen vize ve final kutularına geçerli bir sayı girin!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /* "Sonucu Kaydet" Butonuna tıklandığında çalışır. */
        private void button2_Click(object sender, EventArgs e)
        {
            // Hesaplama yapılmadan kaydetmeye çalışırsa uyar:
            if (lblOrt.Text == "---")
            {
                MessageBox.Show("Önce hesaplama yapın!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // saveFileDialog1: Toolbox'tan eklediğimiz "Kaydet" penceresi bileşeni.
            saveFileDialog1.Title  = "Not sonucunu kaydedin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            // ShowDialog(): Kaydet penceresini açar.
            // DialogResult.OK: Kullanıcı "Kaydet" butonuna tıkladıysa bu değeri döndürür.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // saveFileDialog1.FileName: Kullanıcının seçtiği dosya yolu
                // 'using': StreamWriter işi bitince dosyayı otomatik kapatır.
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("=== NOT HESAPLAMA SONUCU ===");
                    sw.WriteLine("Vize Notu  : " + txtVize.Text);
                    sw.WriteLine("Final Notu : " + txtFinal.Text);
                    sw.WriteLine("Ortalama   : " + lblOrt.Text);
                    sw.WriteLine("Harf Notu  : " + lblHarf.Text);
                    sw.WriteLine("Durum      : " + lblDurum.Text);
                }

                MessageBox.Show("Sonuç başarıyla kaydedildi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
           HarfNotuHesapla: Verilen ortalamaya göre harf notunu döndürür.
           'private': Sadece bu form içinden çağrılabilir.
           'string': Metin türünde sonuç döndürür ("AA", "BB" gibi).
        */
        private string HarfNotuHesapla(double ortalama)
        {
            if (ortalama >= 90)      return "AA";
            else if (ortalama >= 85) return "BA";
            else if (ortalama >= 75) return "BB";
            else if (ortalama >= 70) return "CB";
            else if (ortalama >= 60) return "CC";
            else if (ortalama >= 55) return "DC";
            else if (ortalama >= 50) return "DD";
            else                     return "FF";
        }

        /* saveFileDialog olayı — genelde boş bırakılır. */
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
