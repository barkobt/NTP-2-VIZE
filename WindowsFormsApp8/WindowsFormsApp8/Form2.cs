using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    /*
       WindowsFormsApp8 — Form2: Alışveriş Listesi Detay Ekranı
       ----------------------------------------------------------
       Form1 tarafından kaydedilen .txt dosyasını okur.
       Tüm ürünleri listeler, toplam tutarı ve en pahalı ürünü gösterir.

       Dosya Formatı: Her satır = "ÜrünAdı;Fiyat"
    */
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblToplam.Text    = "Toplam: ---";
            lblEnPahali.Text  = "En Pahali: ---";
        }

        /* "Dosyayı Aç" Butonuna tıklandığında çalışır. */
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblToplam.Text   = "Toplam: ---";
            lblEnPahali.Text = "En Pahali: ---";

            // OpenFileDialog: Dosya seçme penceresi
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title  = "Alisveris listesini secin";
            ofd.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            // Tüm satırları oku:
            string[] satirlar = File.ReadAllLines(ofd.FileName);

            double toplam   = 0;
            double enFazla  = 0;
            string enPahali = "";

            for (int i = 0; i < satirlar.Length; i++)
            {
                if (satirlar[i].Trim() == "") continue;

                // Satırı ";" den parçala: "Süt;12.50" → ["Süt", "12.50"]
                string[] parcalar = satirlar[i].Split(';');
                if (parcalar.Length < 2) continue;

                string urunAdi = parcalar[0];
                double fiyat   = Convert.ToDouble(parcalar[1]);

                toplam += fiyat;

                // En pahalı ürünü bul:
                if (fiyat > enFazla)
                {
                    enFazla  = fiyat;
                    enPahali = urunAdi + " (" + fiyat.ToString("F2") + " TL)";
                }

                // ListBox'a okunabilir format ile ekle:
                listBox1.Items.Add(urunAdi + "  →  " + fiyat.ToString("F2") + " TL");
            }

            // İstatistikleri göster:
            lblToplam.Text   = "Toplam: " + toplam.ToString("F2") + " TL";
            lblEnPahali.Text = "En Pahali: " + enPahali;
        }
    }
}
