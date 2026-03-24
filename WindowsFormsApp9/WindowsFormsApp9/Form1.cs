using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    /*
       WindowsFormsApp9: Sayı Tahmin Oyunu
       -------------------------------------
       Program gizli bir sayı üretir (1-100 arası).
       Kullanıcı sayıyı tahmin etmeye çalışır.
       Her tahminden sonra "Büyük" veya "Küçük" ipucu verilir.
       Timer ile geçen süre saniye saniye gösterilir.
       Oyun kazanılınca süre durdurulur ve deneme sayısı gösterilir.

       ÖĞRENILECEK KAVRAMLAR:
       - Random ile gizli sayı üretme (Form_Load'da)
       - Timer ile saniye sayacı
       - Koşullu ipucu (if-else if)
       - Oyunu sıfırlama (yeni oyun = form load gibi davranış)
       - TextBox'tan int okuma ve try-catch
    */
    public partial class Form1 : System.Windows.Forms.Form
    {
        // Sınıf değişkenleri: Tüm metodlardan erişilebilir
        Random r = new Random();
        int   gizliSayi  = 0;  // Bulunması gereken sayı
        int   denemeSay  = 0;  // Kaç kez tahmin yapıldı?
        int   saniye     = 0;  // Timer'dan gelen saniye sayacı
        bool  oyunBitti  = false; // Oyun kazanıldı mı?

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılınca yeni oyun başlat:
            YeniOyunBaslat();
        }

        /*
           YeniOyunBaslat(): Tüm değişkenleri sıfırlar ve yeni bir gizli sayı üretir.
           Bu metod hem Form_Load hem de "Yeni Oyun" butonundan çağrılır.
        */
        private void YeniOyunBaslat()
        {
            // 1 ile 100 arasında (100 dahil) rastgele sayı üret:
            // r.Next(1, 101): 1 dahil, 101 hariç → yani 1-100 arası
            gizliSayi = r.Next(1, 101);

            // Sayaçları sıfırla:
            denemeSay = 0;
            saniye    = 0;
            oyunBitti = false;

            // Ekrandaki bilgileri güncelle:
            lblIpucu.Text   = "1 ile 100 arasinda bir sayi tuttum...";
            lblDeneme.Text  = "Deneme: 0";
            lblSure.Text    = "Sure: 0 sn";

            // TextBox'u temizle, imleci oraya getir:
            txtTahmin.Clear();
            txtTahmin.Enabled = true;
            btnTahmin.Enabled = true;
            txtTahmin.Focus();

            // Timer'ı başlat (her 1 saniyede bir timer1_Tick çalışır):
            timer1.Start();
        }

        /* "Tahmin Et" Butonuna tıklandığında çalışır. */
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            // Oyun bitmişse tahmin yapma:
            if (oyunBitti) return;

            int tahmin;
            try
            {
                // TextBox'taki metni tam sayıya çevir:
                tahmin = Convert.ToInt32(txtTahmin.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1-100 aralığı kontrolü:
            if (tahmin < 1 || tahmin > 100)
            {
                MessageBox.Show("Lütfen 1 ile 100 arasında bir sayı girin!", "Aralık Hatası",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Deneme sayısını artır:
            denemeSay++;
            lblDeneme.Text = "Deneme: " + denemeSay;

            // Tahmini gizli sayıyla karşılaştır:
            if (tahmin < gizliSayi)
            {
                // Tahmin küçük: İpucu ver
                lblIpucu.Text = tahmin + " - Daha BUYUK bir sayi dene!";
                lblIpucu.ForeColor = System.Drawing.Color.DarkBlue;
            }
            else if (tahmin > gizliSayi)
            {
                // Tahmin büyük: İpucu ver
                lblIpucu.Text = tahmin + " - Daha KUCUK bir sayi dene!";
                lblIpucu.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                // TAHMİN DOĞRU!
                timer1.Stop(); // Zamanlayıcıyı durdur
                oyunBitti = true;

                // Kutlama mesajı:
                lblIpucu.Text = "TEBRIKLER! " + gizliSayi + " sayisini buldun!";
                lblIpucu.ForeColor = System.Drawing.Color.DarkGreen;

                // Giriş kutusunu ve butonu devre dışı bırak:
                txtTahmin.Enabled = false;
                btnTahmin.Enabled = false;

                MessageBox.Show("Tebrikler!\nGizli sayi: " + gizliSayi +
                                "\nDeneme: " + denemeSay +
                                "\nSure: " + saniye + " saniye",
                                "Kazandin!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // TextBox'u temizle, bir sonraki tahmin için hazırla:
            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        /* Timer her 1 saniyede bir bu metodu çağırır. */
        private void timer1_Tick(object sender, EventArgs e)
        {
            // saniye değişkenini artır:
            saniye++;
            // Ekranda göster:
            lblSure.Text = "Sure: " + saniye + " sn";
        }

        /* "Yeni Oyun" Butonuna tıklandığında çalışır. */
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            // Timer'ı durdur (çalışıyorsa), her şeyi sıfırla:
            timer1.Stop();
            YeniOyunBaslat();
        }
    }
}
