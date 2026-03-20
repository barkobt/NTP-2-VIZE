using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /* 
       WindowsFormsApp2: Sayı analiz uygulaması.
       Bu uygulama bir sayının Asal, Mükemmel veya Palindrom olup olmadığını kontrol eder.
    */
    public partial class Form1 : Form
    {
        // Rastgele sayı üretmek için nesne.
        Random rastgele = new Random();

        public Form1()
        {
            InitializeComponent();
            // comboBox1: Seçenek listesi (Asal, Mükemmel, Palindrom).
            // İlk açılışta listenin ilk elemanını (0. indeks) seçili yapıyoruz.
            comboBox1.SelectedIndex = 0;
        }

        /* 'Test Et' Butonuna tıklandığında çalışır. */
        private void button1_Click(object sender, EventArgs e)
        {
            // Önceki sonuçları temizle.
            listBox1.Items.Clear();

            // numericUpDown: Sayı seçme kutuları. .Value ile içindeki sayıyı alırız.
            int baslangic = (int)numericUpDown1.Value;
            int bitis = (int)numericUpDown2.Value;

            // Kullanıcı başlangıcı bitişten büyük girerse diye küçük ve büyük olanı ayırıyoruz.
            int kucuk = Math.Min(baslangic, bitis);
            int buyuk = Math.Max(baslangic, bitis);

            // Belirlenen aralıktaki tüm sayıları tek tek test ediyoruz.
            for (int i = kucuk; i <= buyuk; i++)
            {
                // UygulaVeEkle: Testi yapan ve sonucu listeye ekleyen metodumuz.
                UygulaVeEkle(i, comboBox1.SelectedIndex);
            }
        }

        /* 'Oto Test Başlat/Durdur' Butonuna tıklandığında çalışır. */
        private void button2_Click(object sender, EventArgs e)
        {
            // timer1: Belirli aralıklarla (örneğin her 1 saniyede bir) otomatik iş yapan araç.
            // .Enabled: Timer çalışıyor mu çalışmıyor mu bilgisini verir.
            if (timer1.Enabled)
            {
                timer1.Stop(); // Durdur
                button2.Text = "Oto Test Başlat";
            }
            else
            {
                timer1.Start(); // Başlat
                button2.Text = "Oto Test Durdur";
            }
        }

        /* Timer'ın her 'tik' (adım) atışında çalışan olay. */
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer çalıştığı sürece rastgele sayılar seçip test eder.
            int baslangic = (int)numericUpDown1.Value;
            int bitis = (int)numericUpDown2.Value;

            int kucuk = Math.Min(baslangic, bitis);
            int buyuk = Math.Max(baslangic, bitis);

            // Rastgele bir sayı seç
            int rastgeleSayi = rastgele.Next(kucuk, buyuk + 1);
            
            // Rastgele bir test seç (0: Asal, 1: Mükemmel, 2: Palindrom)
            int rastgeleTest = rastgele.Next(0, 3);

            UygulaVeEkle(rastgeleSayi, rastgeleTest);
        }

        /* 
           Seçilen teste göre ilgili fonksiyonu çağıran ve sonucu ListBox'a yazan metod.
        */
        private void UygulaVeEkle(int sayi, int testIndeks)
        {
            string sonuc = "";
            if (testIndeks == 0) sonuc = AsalTesti(sayi);
            else if (testIndeks == 1) sonuc = MukemmelTesti(sayi);
            else if (testIndeks == 2) sonuc = PalindromTesti(sayi);

            // Sonucu listeye ekle.
            listBox1.Items.Add("[Oto] " + sonuc);

            // TopIndex: Listenin en altına otomatik kaydır (Scroll).
            // Böylece yeni eklenenleri hep görürüz.
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        /* 
           Asal Sayı Testi: Sadece 1'e ve kendisine bölünen sayılar asaldır.
        */
        private string AsalTesti(int sayi)
        {
            int sayac = 0;
            // 1'den sayıya kadar her şeye bölmeyi deniyoruz.
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0) sayac++; // Tam bölünüyorsa sayacı artır.
            }

            // Tam bölünen sayısı sadece 2 ise (1 ve kendisi) o sayı asaldır.
            if (sayac == 2) return sayi + " asaldır.";
            else return sayi + " asal değildir.";
        }

        /* 
           Mükemmel Sayı Testi: Kendisi hariç pozitif bölenlerinin toplamı kendine eşit olan sayı.
           Örn: 6 -> 1+2+3 = 6 (Mükemmeldir)
        */
        private string MukemmelTesti(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) toplam = toplam + i;
            }

            if (toplam == sayi && sayi != 0) return sayi + " mükemmeldir.";
            else return sayi + " mükemmel değildir.";
        }

        /* 
           Palindrom Sayı Testi: Tersten okunuşu da aynı olan sayı.
           Örn: 121, 505
        */
        private string PalindromTesti(int sayi)
        {
            // Sayıyı metne çevirip ters çevireceğiz.
            string metin = sayi.ToString();
            string ters = "";
            // Döngüyü sondan başa doğru kuruyoruz.
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                ters = ters + metin[i];
            }

            // Eğer düzü ve tersi aynıysa palindromdur.
            if (metin == ters) return sayi + " palindromdur.";
            else return sayi + " palindrom değildir.";
        }
    }
}
