using System;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    /*
       WindowsFormsApp10 — Form2: Metin Analiz Sonuçları
       ---------------------------------------------------
       Form1'den gelen metni analiz eder:
       - Karakter sayısı (boşluklar dahil/hariç)
       - Kelime sayısı (boşluklara göre ayrılmış)
       - Cümle sayısı (nokta, !, ? ile biten)
       - En uzun kelime
       - En çok tekrar eden harf (a-z veya A-Z)

       VERİ GEÇIŞI:
       Form1'den 'GelenMetin' public property'si ile metin gelir.
       Form2_Load içinde bu metin analiz edilir ve sonuçlar gösterilir.
    */
    public partial class Form2 : System.Windows.Forms.Form
    {
        // Public property: Form1 bu özelliğe değer atayarak veri gönderir.
        // 'f2.GelenMetin = txtMetin.Text;' şeklinde kullanılır.
        public string GelenMetin { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form açılınca gelen metni analiz et:
            if (GelenMetin == null || GelenMetin.Trim() == "")
            {
                listBox1.Items.Add("Analiz edilecek metin yok!");
                return;
            }

            string metin = GelenMetin;

            // --- KARAKTER SAYISI ---
            int karSayiBosluklu  = metin.Length;
            int karSayiBosLuksuz = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ') karSayiBosLuksuz++;
            }

            // --- KELIME SAYISI ---
            // Önce metni küçük harfe çevir, sonra boşluklara göre böl:
            // StringSplitOptions.RemoveEmptyEntries: Çift boşluktan oluşan boş parçaları atar
            string[] kelimeler = metin.Split(new char[] { ' ', '\r', '\n', '\t' },
                                             StringSplitOptions.RemoveEmptyEntries);
            int kelimeSayisi = kelimeler.Length;

            // --- CÜMLE SAYISI ---
            // Nokta, ünlem ve soru işareti sayılır:
            int cumleSayisi = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == '.' || metin[i] == '!' || metin[i] == '?')
                    cumleSayisi++;
            }
            // En az 1 cümle var kabul ediyoruz (nokta yoksa bile):
            if (cumleSayisi == 0 && kelimeSayisi > 0) cumleSayisi = 1;

            // --- EN UZUN KELİME ---
            string enUzun = "";
            for (int i = 0; i < kelimeler.Length; i++)
            {
                // Noktalama işaretlerini temizle (karşılaştırma için):
                string temiz = kelimeler[i].Trim('.', ',', '!', '?', ';', ':');
                if (temiz.Length > enUzun.Length)
                    enUzun = temiz;
            }

            // --- EN ÇOK GEÇEN HARF ---
            // 26 harf için sayaç dizisi (a=0, b=1, ... z=25):
            int[] harfSayac = new int[26];
            string metinKucuk = metin.ToLower(); // Büyük/küçük fark gözetmemek için
            for (int i = 0; i < metinKucuk.Length; i++)
            {
                char c = metinKucuk[i];
                // 'a' ile 'z' arasındaki harfleri say (diğer karakterleri atla):
                if (c >= 'a' && c <= 'z')
                    harfSayac[c - 'a']++;
            }
            // En büyük değeri bul:
            int enFazlaSayi = 0;
            char enFazlaHarf = '-';
            for (int i = 0; i < 26; i++)
            {
                if (harfSayac[i] > enFazlaSayi)
                {
                    enFazlaSayi = harfSayac[i];
                    enFazlaHarf = (char)('a' + i); // Sayıyı tekrar harfe çevir
                }
            }

            // --- SONUÇLARI LISTBOX'A EKLE ---
            listBox1.Items.Add("=== METİN ANALİZ SONUÇLARI ===");
            listBox1.Items.Add("");
            listBox1.Items.Add("Karakter Sayisi (bosluklu)  : " + karSayiBosluklu);
            listBox1.Items.Add("Karakter Sayisi (bosluksuz) : " + karSayiBosLuksuz);
            listBox1.Items.Add("Kelime Sayisi               : " + kelimeSayisi);
            listBox1.Items.Add("Cumle Sayisi                : " + cumleSayisi);
            listBox1.Items.Add("En Uzun Kelime              : " + enUzun);
            if (enFazlaSayi > 0)
                listBox1.Items.Add("En Cok Gecen Harf          : '" + enFazlaHarf + "' (" + enFazlaSayi + " kez)");
            listBox1.Items.Add("");
            listBox1.Items.Add("--- Kelimeler ---");

            // Tüm kelimeleri de listele:
            for (int i = 0; i < kelimeler.Length; i++)
            {
                listBox1.Items.Add((i + 1) + ". " + kelimeler[i]);
            }
        }
    }
}
