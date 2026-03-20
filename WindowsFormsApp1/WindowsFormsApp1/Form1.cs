using System; // Temel sistem fonksiyonlarını (tarih, saat, temel veri tipleri) içeren kütüphane.
using System.Collections.Generic; // Listeler (List<T>) gibi dinamik veri yapılarını kullanmamızı sağlar.
using System.ComponentModel; // Bileşenlerin (controls) tasarımı ve çalışma zamanı davranışları için gerekli.
using System.Data; // Veri işlemleri için kullanılır (bu projede temel seviyede var).
using System.Drawing; // UI öğelerinin renkleri, boyutları gibi görsel özellikleri için.
using System.IO; // Dosya okuma/yazma işlemleri (StreamWriter, File) için kritik kütüphane.
using System.Linq; // Veri sorgulama (sıralama, filtreleme) işlemlerini kolaylaştıran kütüphane.
using System.Text; // Metin işlemleri ve kodlamalar için.
using System.Threading.Tasks; // Asenkron (paralel) işlemler için (temel projelerde çok kullanılmaz).
using System.Windows.Forms; // Windows Form öğelerini (Button, TextBox, Form) kullanmamızı sağlayan ana kütüphane.

namespace WindowsFormsApp1
{
    /* 
       'partial' anahtar kelimesi, bu sınıfın kodlarının birden fazla dosyaya bölündüğünü gösterir.
       Formun görsel tasarımı 'Form1.Designer.cs' dosyasındadır, biz burada mantığını (Logic) yazarız.
       ': Form' ifadesi, bu sınıfın bir 'Form' olduğunu (kalıtım/inheritance) belirtir.
    */
    public partial class Form1 : Form
    {
        /* Form oluşturulduğunda çalışan ilk metod (Constructor). */
        public Form1()
        {
            // Tasarım ekranında eklediğimiz buton, kutu vb. her şeyi hazır hale getirir.
            // Bu metodu silmemelisiniz, aksi halde form boş görünür.
            InitializeComponent();
        }

        /* Form ilk açıldığında (yüklendiğinde) yapılacak işlemler buraya yazılır. */
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /* Rastgele sayı üretmek için kullanılan nesne. Sınıf düzeyinde tanımladık ki her yerde aynı nesneyi kullanalım. */
        Random r = new Random();

        /* 
           Bu metod 1-49 arasında, birbirinden farklı 6 adet sayı üretir.
           'private': Sadece bu form içinden erişilebilir.
           'String': Metin türünde bir sonuç döndürür.
        */
        private String sayi6()
        {
            // Sayıları geçici olarak tutmak için bir liste oluşturuyoruz.
            List<int> lst = new List<int>();

            // Listede 6 sayı olana kadar döngü devam eder.
            while (lst.Count < 6)
            {
                // 1 ile 50 arasında (50 dahil değil, yani 49'a kadar) sayı üretir.
                int num = r.Next(1, 50);

                // Eğer bu sayı listede daha önce yoksa listeye ekle (Tekrarı önler).
                if (!lst.Contains(num))
                    lst.Add(num);
            }

            // Sayıları küçükten büyüğe sıralar (Loto kuralları gereği).
            lst.Sort();

            // Sayıları aralarına virgül koyarak tek bir metin (string) haline getirir.
            // Örn: [1, 5, 12...] -> "1,5,12..."
            return String.Join(",", lst);
        }

        /* 'Loto Oyna' Butonuna tıklandığında çalışır. */
        private void button2_Click(object sender, EventArgs e)
        {
            // numericUpDown1: Kullanıcının kaç kolon oynamak istediğini seçtiği sayı kutusu.
            // .Value: Seçilen sayısal değeri verir. (int) ile tam sayıya çeviriyoruz.
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                // Her döngüde 6 sayı üretir ve textBox1'e (büyük metin kutusu) ekler.
                // += : Mevcut metnin üzerine ekle demektir.
                // "\r\n" : Yeni bir satıra geçmek için kullanılan komuttur (Enter tuşu gibi).
                textBox1.Text += sayi6() + "\r\n";
            }
        }

        /* 'Tek Çekiliş Yap' Butonuna tıklandığında çalışır. */
        private void button1_Click(object sender, EventArgs e)
        {
            // textBox2: Çekiliş sonucunu (tek satır) gösteren kutu.
            textBox2.Text = sayi6();
        }

        /* 'Sonuç Kontrol Ekranına Git' Butonuna tıklandığında çalışır. */
        private void button4_Click(object sender, EventArgs e)
        {
            // Diğer formu (Form2) bir nesne olarak oluşturuyoruz.
            Form2 f2 = new Form2();
            
            // ShowDialog(): Yeni formu açar ve o form kapanana kadar bu formu kilitler.
            // .Show() deseydik ikisi de aynı anda aktif kalabilirdi.
            f2.ShowDialog();
        }

        /* 'Kolonları Kaydet' Butonuna tıklandığında çalışır. */
        private void button3_Click(object sender, EventArgs e)
        {
            // saveFileDialog1: Dosya kaydetme penceresini açan araç.
            // Tasarım ekranında (Design) 'Toolbox'tan eklenir.
            saveFileDialog1.Title = "Kaydetmek için dosya ismi verin";

            // Eğer kullanıcı iptal etmeyip 'Kaydet' butonuna bastıysa:
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // StreamWriter: Dosyaya yazı yazmamızı sağlayan araç.
                // using bloğu işi bittiğinde dosyayı güvenli bir şekilde kapatır.
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // textBox1'deki tüm metni (oynanan kolonları) dosyaya yazar.
                    sw.WriteLine(textBox1.Text);
                }
            }
        }

        /* 'Çekilişi Kaydet' Butonuna tıklandığında çalışır. */
        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Çekiliş Kaydetmek için dosya ismi verin";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // textBox2'deki çekiliş sonucunu dosyaya yazar.
                    sw.WriteLine(textBox2.Text);
                }
            }
        }

        /* Bu metod saveFileDialog'un bir olayıdır, genelde boş bırakılabilir. */
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}
