using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /* 
       Form2: Çekiliş sonuçları ile oynanan kolonları karşılaştırdığımız ekran.
    */
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /* 'Kontrol Et' Butonuna tıklandığında çalışır. */
        private void button1_Click(object sender, EventArgs e)
        {
            // İşleme başlamadan önce eski sonuçları temizliyoruz.
            listBox1.Items.Clear();
            textBox1.Clear();

            // OpenFileDialog: Bilgisayardan dosya seçmemizi sağlayan pencereyi açar.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Çekiliş dosyasını seçin.";
            ofd.Filter = "Tüm dosyalar|*.*|text dosyalar|*.txt"; // Sadece belirli uzantıları göstermek için.

            // Kullanıcı dosya seçmeden pencereyi kapattıysa işlemi iptal et.
            if (ofd.ShowDialog() != DialogResult.OK) return;

            string sayilar;
            List<int> cekilis;

            // File.ReadAllLines: Dosyadaki tüm satırları bir dizi (array) olarak okur.
            // [0]: Çekiliş dosyasının sadece ilk satırını alıyoruz.
            sayilar = File.ReadAllLines(ofd.FileName)[0];

            // ListeCevir: Kendi yazdığımız metod. Virgüllü metni sayı listesine çevirir.
            cekilis = ListeCevir(sayilar);

            // Şimdi kolonların olduğu dosyayı seçtiriyoruz.
            ofd.Title = "Kolonlar dosyasını seçin.";
            ofd.Filter = "Tüm dosyalar|*.*|text dosyalar|*.txt";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            List<int> kolon;
            // sonuc: Kaç tane 0, 1, 2... 6 tutturan olduğunu saymak için dizi.
            int[] sonuc = new int[7]; 
            // sonucK: Tutturan kolonların listesini metin olarak tutmak için.
            string[] sonucK = new string[7];

            // Dosyadaki tüm satırları (kolonları) okuyoruz.
            string[] kolonlar = File.ReadAllLines(ofd.FileName);

            // Her bir kolonu tek tek kontrol ediyoruz.
            for (int i = 0; i < kolonlar.Length; i++)
            {
                // Boş satır varsa atla.
                if (kolonlar[i].Trim() == "") continue;

                // Satırı sayı listesine çevir.
                kolon = ListeCevir(kolonlar[i]);
                
                int say = 0; // Bu kolonda kaç tane doğru tahmin var?
                for (int j = 0; j < kolon.Count; j++)
                {
                    // Eğer çekiliş listesi, kolonun bu sayısını içeriyorsa:
                    if (cekilis.Contains(kolon[j])) say++;
                }

                // 'say' değişkeni kaç tuttuğunu gösterir (0-6 arası).
                // İlgili indeksi 1 artırıyoruz.
                sonuc[say]++;
                // Tutturan kolonu ilgili metne ekliyoruz.
                sonucK[say] += kolonlar[i] + "; ";
            }

            // Sonuçları ListBox'a (Liste kutusu) ekleyerek kullanıcıya gösteriyoruz.
            for (int i = 0; i < sonuc.Length; i++)
            {
                listBox1.Items.Add(i + " tutturan " + sonuc[i] + " kişi");
            }

            // Detaylı listeyi TextBox'a yazıyoruz.
            for (int i = 0; i < sonucK.Length; i++)
            {
                textBox1.Text += "\r\n" + i + " tutturan " + sonucK[i] + ":\r\n";
            }
        }

        /* 
           Virgülle ayrılmış metni ("1,2,3") List<int> yapısına çeviren yardımcı metod.
        */
        private List<int> ListeCevir(string sayilar)
        {
            List<int> l = new List<int>();
            // Split(','): Metni virgüllerden parçalara böler ve dizi yapar.
            string[] parts = sayilar.Split(',');

            for (int i = 0; i < parts.Length; i++)
            {
                // Convert.ToInt32: Metin halindeki sayıyı ("5") gerçek sayıya (5) çevirir.
                l.Add(Convert.ToInt32(parts[i]));
            }
            return l;
        }
    }
}
