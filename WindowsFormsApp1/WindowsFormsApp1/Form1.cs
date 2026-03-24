using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /*
       WindowsFormsApp1: Loto Uygulaması
       -----------------------------------
       Bu uygulama 1-49 arasında rastgele loto numaraları üretir.
       Üretilen numaralar dosyaya kaydedilebilir.
       Form2 ekranında kaydedilen çekiliş ile kolonlar karşılaştırılır.

       TEMEL KAVRAMLAR (Bu projeden öğrenilecekler):
       - Random sınıfı ile rastgele sayı üretme
       - List<int> ile tekrarsız sayı listesi oluşturma
       - TextBox'a satır ekleme (\r\n)
       - SaveFileDialog ile dosyaya yazma (StreamWriter)
       - Form2'yi ShowDialog() ile açma (Çok-Form mimarisi)
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            // Tasarım ekranındaki tüm kontrolleri hazır hale getirir:
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılınca kolon sayacı etiketini sıfırla:
            lblKolonSayisi.Text = "Kolon: 0";
        }

        /*
           Random nesnesi: Rastgele sayı üretmek için kullanılır.
           Sınıf düzeyinde (metod dışında) tanımlandı ki her metodda tekrar
           oluşturulmak zorunda kalmasın. Her yerde aynı nesneyi kullanırız.
        */
        Random r = new Random();

        /*
           sayi6(): 1-49 arasında, birbirinden FARKLI, SIRALI 6 sayı üretir.
           'private String': Sadece bu sınıf içinden çağrılabilir, metin döndürür.
           Örnek çıktı: "3,12,25,31,40,47"
        */
        private string sayi6()
        {
            // Üretilen sayıları geçici olarak tutmak için boş bir liste:
            List<int> lst = new List<int>();

            // 6 farklı sayı elde edilene kadar döngü devam eder.
            // Eğer üretilen sayı zaten listede varsa tekrar dener:
            while (lst.Count < 6)
            {
                // r.Next(1, 50): 1 ile 49 arasında rastgele sayı (50 DAHİL DEĞİL!)
                int num = r.Next(1, 50);

                // !lst.Contains(num): Bu sayı listede YOK ise ekle (tekrar önlenir):
                if (!lst.Contains(num))
                    lst.Add(num);
            }

            // lst.Sort(): Listeyi küçükten büyüğe sıralar
            // Örn: [31, 3, 47, 12, 25, 40] → [3, 12, 25, 31, 40, 47]
            lst.Sort();

            // String.Join(",", lst): Listedeki sayıları virgülle birleştirir
            // Örn: [3, 12, 25, 31, 40, 47] → "3,12,25,31,40,47"
            return String.Join(",", lst);
        }

        /*
           KolonSayisiniGuncelle(): textBox1'deki dolu satır sayısını sayarak
           lblKolonSayisi etiketini günceller.
        */
        private void KolonSayisiniGuncelle()
        {
            // textBox1.Lines: Her satırı ayrı bir eleman olarak veren dizi
            int sayac = 0;
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                // Boş satırları saymıyoruz (.Trim() baştaki/sondaki boşlukları siler)
                if (textBox1.Lines[i].Trim() != "")
                    sayac++;
            }
            lblKolonSayisi.Text = "Kolon: " + sayac;
        }

        /* "Tek Çekiliş Yap" Butonuna tıklandığında çalışır. */
        private void button1_Click(object sender, EventArgs e)
        {
            // sayi6() çağrılır, üretilen sayı kombinasyonu textBox2'ye yazılır.
            // textBox2: Çekiliş sonucunu gösteren TEK satırlık kutu.
            textBox2.Text = sayi6();
        }

        /* "Toplu Loto Oyna" Butonuna tıklandığında çalışır. */
        private void button2_Click(object sender, EventArgs e)
        {
            // numericUpDown1.Value: Kullanıcının seçtiği kolon sayısı
            // (int) ile ondalıklı sayıdan tam sayıya çeviriyoruz
            int kolonSayisi = (int)numericUpDown1.Value;

            for (int i = 0; i < kolonSayisi; i++)
            {
                // Her döngüde 1 loto kolonu üretilip textBox1'e EKLENIR.
                // "+=" operatörü: Mevcut metnin ÜSTÜNE ekler, silmez!
                // "\r\n": Yeni satıra geçmek için kullanılan karakter dizisi (Enter gibi)
                textBox1.Text += sayi6() + "\r\n";
            }

            // Kolon sayacını güncelle:
            KolonSayisiniGuncelle();
        }

        /* "Kolonları Kaydet" Butonuna tıklandığında çalışır. */
        private void button3_Click(object sender, EventArgs e)
        {
            // textBox1 boşsa kaydetme:
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Önce loto kolonu üretin!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // saveFileDialog1.Title: Pencerenin üst çubuğunda görünen yazı
            saveFileDialog1.Title  = "Kolonları kaydetmek için dosya ismi verin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            // ShowDialog(): Kaydet penceresini açar ve sonucu döndürür.
            // DialogResult.OK: Kullanıcı "Kaydet" e tıkladığında bu değer gelir.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // saveFileDialog1.FileName: Kullanıcının seçtiği dosya yolu
                // 'using' bloğu: İçindeki kod biter bitmez dosyayı güvenle kapatır.
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // textBox1.Text: Tüm loto kolonlarını içeren metin
                    sw.WriteLine(textBox1.Text);
                }
                MessageBox.Show("Kolonlar başarıyla kaydedildi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Temizle" Butonuna tıklandığında çalışır. */
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // textBox1'deki tüm kolonları sil:
            textBox1.Clear();
            // Kolon sayacını sıfırla:
            lblKolonSayisi.Text = "Kolon: 0";
        }

        /* "Çekilişi Kaydet" Butonuna tıklandığında çalışır. */
        private void button5_Click(object sender, EventArgs e)
        {
            // Çekiliş yapılmamışsa uyar:
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Önce 'Tek Çekiliş Yap' butonuna basın!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Title  = "Çekiliş sonucunu kaydetmek için dosya ismi verin";
            saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // textBox2.Text: "3,12,25,31,40,47" gibi tek satır çekiliş sonucu
                    sw.WriteLine(textBox2.Text);
                }
                MessageBox.Show("Çekiliş başarıyla kaydedildi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* "Sonuç Kontrol Et" Butonuna tıklandığında çalışır. */
        private void button4_Click(object sender, EventArgs e)
        {
            // Form2 nesnesini oluştur (henüz ekranda görünmez):
            Form2 f2 = new Form2();

            // f2.ShowDialog(): Form2'yi MODAL olarak açar.
            // MODAL = Form2 kapanana kadar Form1 ile etkileşime girilmez.
            // Bu sınavda en çok kullanılan çok-form açma yöntemidir!
            f2.ShowDialog();
        }

        /* saveFileDialog1_FileOk: Bu olay genelde boş bırakılır. */
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
