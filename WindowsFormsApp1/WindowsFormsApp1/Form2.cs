using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /*
       WindowsFormsApp1 — Form2: Çekiliş Sonuç Kontrol Ekranı
       --------------------------------------------------------
       Bu form, Form1'de kaydedilen iki dosyayı karşılaştırır:
       1. Çekiliş dosyası: "3,12,25,31,40,47" gibi tek bir satır
       2. Kolonlar dosyası: Her satırda bir loto kolonu

       Her kolonun çekilişle kaç sayısı tuttuğunu hesaplar ve listeler.

       ÖĞRENILECEK KAVRAMLAR:
       - OpenFileDialog ile dosya seçme
       - File.ReadAllLines ile tüm satırları okuma
       - String.Split ile satırı parçalama
       - List<int> ile karşılaştırma
    */
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /* "Sonuçları Kontrol Et" Butonuna tıklandığında çalışır. */
        private void button1_Click(object sender, EventArgs e)
        {
            // Önceki sonuçları temizle (yeni kontrol için hazırla):
            listBox1.Items.Clear();
            textBox1.Clear();

            // --- ADIM 1: Çekiliş dosyasını oku ---
            // OpenFileDialog: Dosya seçme penceresi (koddan oluşturuyoruz)
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title  = "Cekilis dosyasini secin";
            ofd.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            // Kullanıcı "İptal" tıkladıysa işlemi durdur:
            if (ofd.ShowDialog() != DialogResult.OK) return;

            // File.ReadAllLines: Dosyadaki tüm satırları string dizisi olarak okur
            // [0]: Çekiliş dosyasının ilk (ve tek) satırını alıyoruz
            string cekilisMetni = File.ReadAllLines(ofd.FileName)[0];

            // ListeCevir: Kendi metodumuz. "3,12,25" → List {3, 12, 25}
            List<int> cekilis = ListeCevir(cekilisMetni);

            // --- ADIM 2: Kolonlar dosyasını oku ---
            ofd.Title  = "Kolonlar dosyasini secin";
            ofd.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            // Dosyadaki tüm satırları (tüm kolonları) oku:
            string[] kolonlar = File.ReadAllLines(ofd.FileName);

            // --- ADIM 3: Her kolonu çekilişle karşılaştır ---
            // sonuc[i]: i sayısını tutturan kaç kolon var?
            // Örn: sonuc[3] = 5 → 3 sayı tutturan 5 kolon var
            int[]    sonuc  = new int[7];
            string[] sonucK = new string[7];  // Tutturanların metin listesi

            for (int i = 0; i < kolonlar.Length; i++)
            {
                // Boş satırları atla:
                if (kolonlar[i].Trim() == "") continue;

                // Bu satırı (kolonu) sayı listesine çevir:
                List<int> kolon = ListeCevir(kolonlar[i]);

                // Bu kolonda kaç doğru tahmin var?
                int tutturanSayi = 0;
                for (int j = 0; j < kolon.Count; j++)
                {
                    // cekilis.Contains(kolon[j]): Bu sayı çekilişte var mı?
                    if (cekilis.Contains(kolon[j]))
                        tutturanSayi++;
                }

                // İlgili sayacı artır:
                sonuc[tutturanSayi]++;
                // Kolonu ilgili metne ekle:
                sonucK[tutturanSayi] += kolonlar[i] + "; ";
            }

            // --- ADIM 4: Sonuçları ekranda göster ---
            // ListBox'a özet (kaç tutturan kaç kolon):
            for (int i = 0; i < sonuc.Length; i++)
            {
                listBox1.Items.Add(i + " tutturan: " + sonuc[i] + " kolon");
            }

            // TextBox'a detaylı liste:
            for (int i = 0; i < sonucK.Length; i++)
            {
                if (sonucK[i] != null && sonucK[i] != "")
                {
                    textBox1.Text += i + " tutturan kolonlar:\r\n" + sonucK[i] + "\r\n\r\n";
                }
            }
        }

        /*
           ListeCevir(): Virgülle ayrılmış sayı metnini List<int>'e çevirir.
           Örnek: "3,12,25,31,40,47" → List<int> {3, 12, 25, 31, 40, 47}

           'private': Sadece Form2 içinden çağrılabilir.
           'List<int>': İçinde tam sayı tutan dinamik liste döndürür.
        */
        private List<int> ListeCevir(string sayilar)
        {
            List<int> l = new List<int>();

            // Split(','): Metni virgüllerden parçalara böler
            // "3,12,25" → ["3", "12", "25"]
            string[] parts = sayilar.Trim().Split(',');

            for (int i = 0; i < parts.Length; i++)
            {
                // parts[i] boş olabilir (iki virgül yan yana gelirse), kontrol et:
                if (parts[i].Trim() != "")
                {
                    // Convert.ToInt32: Metin halindeki sayıyı gerçek sayıya çevirir
                    // "12" → 12
                    l.Add(Convert.ToInt32(parts[i].Trim()));
                }
            }
            return l;
        }
    }
}
