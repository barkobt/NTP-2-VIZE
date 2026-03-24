# WinForms Kapsamlı Ders Notları — Sınav Hazırlık Rehberi

> **Hedef Kitle:** C# temel bilgisi olan, WinForms sınavına hazırlanan öğrenciler.
> Bu doküman; teorik anlatım, gerçek kod örnekleri ve sınav ipuçlarını bir arada sunar.

---

## İçindekiler

1. [WinForms Nedir?](#1-winforms-nedir)
2. [Visual Studio Arayüzü](#2-visual-studio-arayüzü)
3. [Temel Kontroller ve Önemli Properties'leri](#3-temel-kontroller)
4. [SaveFileDialog ve OpenFileDialog — SINAV ÖNEMLİ](#4-dosya-diyalogları)
5. [Çoklu Form (Multi-Form) Mimarisi — SINAV ÖNEMLİ](#5-çoklu-form-mimarisi)
6. [Olaylar (Events) — Nasıl Bağlanır?](#6-olaylar-events)
7. [Dosya Okuma ve Yazma — Tam Şablonlar](#7-dosya-okuma-ve-yazma)
8. [Sıkça Kullanılan Kod Kalıpları](#8-sıkça-kullanılan-kod-kalıpları)
9. [Sınav Kontrol Listesi](#9-sinav-kontrol-listesi)

---

## 1. WinForms Nedir?

Windows Forms (WinForms), C# ile Windows masaüstü uygulamaları geliştirmemizi sağlayan bir teknolojidir. Sadece kod yazmak yerine; butonları, metin kutularını ve etiketleri görsel bir ekran üzerine **sürükleyip bırakarak** yerleştirirsiniz. Altında otomatik C# kodu oluşur.

### Projenin Temel Dosya Yapısı

```
ProjeAdı/
├── Program.cs          ← Uygulamanın başladığı yer (Ana kapı)
├── Form1.cs            ← SİZİN yazdığınız mantık kodları
├── Form1.Designer.cs   ← Visual Studio'nun otomatik yazdığı UI kodu (EL SÜRME!)
└── Form1.resx          ← Resimler ve kaynaklar için (genelde boş bırakılır)
```

**Program.cs'in görevi:** `Application.Run(new Form1())` satırıyla Form1'i başlatır. Genelde değiştirmenize gerek yoktur.

---

## 2. Visual Studio Arayüzü

### Önemli Pencereler

| Pencere | Kısayol | Ne İşe Yarar? |
|---------|---------|---------------|
| **Toolbox** | Ctrl+Alt+X | Forma ekleyebileceğiniz tüm kontroller (Button, TextBox vb.) |
| **Properties** | F4 | Seçili kontrolün özellikleri (renk, boyut, isim vb.) |
| **Solution Explorer** | Ctrl+Alt+L | Projedeki tüm dosyaların listesi |
| **Error List** | Ctrl+W, E | Derleme hataları ve uyarılar |

### Design (Tasarım) vs Code (Kod) Ekranı

- **Design ekranı:** Form1.cs'e sağ tıklayın → "View Designer" veya Shift+F7
- **Code ekranı:** Form1.cs'e sağ tıklayın → "View Code" veya F7

> **İpucu:** Bir kontrole (butona vb.) Design ekranında **çift tıklarsanız**, Visual Studio otomatik olarak o kontrolün `_Click` metodunu oluşturur ve sizi Code ekranına götürür.

---

## 3. Temel Kontroller

Her kontrolün **2 zorunlu özelliği** vardır:
- **`Name`**: Kodda bu kontrole nasıl hitap edeceğiniz. Anlamlı isim verin: `btnHesapla`, `txtAd`, `lblSonuc`
- **`Text`**: Ekranda görünen yazı (Label, Button gibi kontroller için)

---

### Label — Yazı Gösterme

Kullanıcının **değiştiremeyeceği** bir yazı göstermek için kullanılır. Sonuç, başlık, açıklama gibi şeyler için idealdir.

**Önemli Properties:**

| Property | Açıklama | Örnek Değer |
|----------|----------|-------------|
| `Text` | Gösterilen yazı | `"Ortalama:"` |
| `Name` | Kod adı | `lblSonuc` |
| `Font` | Yazı tipi ve boyutu | `Microsoft Sans Serif, 12pt, Bold` |
| `ForeColor` | Yazı rengi | `Red`, `Blue` |
| `AutoSize` | Yazıya göre boyutu ayarla | `true` (genelde açık bırakın) |

**Kodda Kullanımı:**
```csharp
// Label'ın metnini koddan değiştirme:
lblSonuc.Text = "Hesaplama tamamlandı.";
lblSonuc.Text = ortalama.ToString(); // Sayıyı metne çevirip göster

// Renk değiştirme (geçti = yeşil, kaldı = kırmızı gibi):
lblDurum.ForeColor = System.Drawing.Color.Green;
lblDurum.ForeColor = System.Drawing.Color.Red;
```

---

### Button — Tıklanabilir Buton

Kullanıcının bir işlemi başlatması için tıkladığı kontrol.

**Önemli Properties:**

| Property | Açıklama |
|----------|----------|
| `Text` | Buton üzerindeki yazı: `"Hesapla"`, `"Kaydet"` |
| `Name` | Kod adı: `btnHesapla`, `btnKaydet` |
| `Enabled` | `false` yapılırsa buton gri olur ve tıklanamaz |

**Event Bağlama:** Design ekranında butona çift tıklayın → `button1_Click` metodu oluşur.

```csharp
private void btnHesapla_Click(object sender, EventArgs e)
{
    // Bu kod butona her tıklandığında çalışır.
    lblSonuc.Text = "Buton tıklandı!";
}
```

---

### TextBox — Metin Girişi

Kullanıcının klavyeden metin yazması için kullanılır.

**Önemli Properties:**

| Property | Açıklama | Örnek |
|----------|----------|-------|
| `Text` | Kutunun içindeki metin | `""` (başlangıçta boş) |
| `Name` | Kod adı | `txtAd`, `txtSonuc` |
| `Multiline` | Birden fazla satır yazılabilir mi? | `true`/`false` |
| `ReadOnly` | Kullanıcı değiştirebilir mi? | `true` = sadece okunur |
| `ScrollBars` | Kaydırma çubuğu | `Vertical`, `Both`, `None` |

**Kodda Kullanımı:**
```csharp
// Kullanıcının yazdığını okuma:
string ad = txtAd.Text;
double sayi = Convert.ToDouble(txtSayi.Text); // Metni sayıya çevir

// TextBox'a yazma:
txtSonuc.Text = "Merhaba!";
txtSonuc.Text += "\r\n" + "Yeni satır"; // += ile üstüne ekle, \r\n = Enter

// TextBox'ı temizleme:
txtSonuc.Clear();
// veya:
txtSonuc.Text = "";
```

> **Dikkat:** `Convert.ToDouble(txtSayi.Text)` ile sayıya çevirirken kullanıcı boş bırakmış veya harf yazmışsa program çöker. Bunun için `try-catch` kullanın (Bölüm 8'de anlatıldı).

---

### NumericUpDown — Sayı Seçici

Sadece sayı girilebilen, ok tuşlarıyla artırılıp azaltılabilen kutu. TextBox'a göre daha güvenlidir çünkü kullanıcı harf giremez.

**Önemli Properties:**

| Property | Açıklama | Örnek |
|----------|----------|-------|
| `Value` | Şu anki değer | `50` |
| `Minimum` | En küçük izin verilen değer | `0` |
| `Maximum` | En büyük izin verilen değer | `100` |
| `DecimalPlaces` | Ondalık basamak sayısı | `0` (tam sayı), `2` (iki ondalık) |
| `Increment` | Her ok tuşunda kaç artacak | `1`, `5`, `0.5` |

**Kodda Kullanımı:**
```csharp
// Değeri okuma — .Value her zaman sayı döndürür, (int) ile tam sayıya çevirin:
int kolonSayisi = (int)numericUpDown1.Value;
double not = (double)nudVize.Value;

// Örnek: WindowsFormsApp1'den (Loto uygulaması)
for (int i = 0; i < (int)numericUpDown1.Value; i++)
{
    textBox1.Text += sayi6() + "\r\n"; // Her döngüde bir loto satırı ekle
}
```

---

### ComboBox — Açılır Liste

Kullanıcıya önceden belirlenmiş seçeneklerden birini seçtirmek için kullanılır.

**Önemli Properties:**

| Property | Açıklama |
|----------|----------|
| `Items` | Listedeki seçenekler (Designer'da veya kodda eklenir) |
| `SelectedIndex` | Seçili elemanın sırası (0'dan başlar) |
| `DropDownStyle` | `DropDownList` = kullanıcı sadece seçebilir, yazamaz |
| `Text` | Seçili elemanın metni |

**Designer'da Eleman Ekleme:** Properties → Items → ... butonuna tıkla → her satıra bir eleman yaz.

**Kodda Kullanımı:**
```csharp
// Form yüklenirken ilk seçeneği seçili yap:
private void Form1_Load(object sender, EventArgs e)
{
    comboBox1.SelectedIndex = 0; // İlk elemanı seç
}

// Seçili elemana göre işlem yapmak:
// SelectedIndex: 0 = ilk, 1 = ikinci, 2 = üçüncü...
if (comboBox1.SelectedIndex == 0) sonuc = AsalTesti(sayi);
else if (comboBox1.SelectedIndex == 1) sonuc = MukemmelTesti(sayi);

// Seçili elemanın metnini almak:
string secilen = comboBox1.Text;
```

---

### ListBox — Çoklu Liste Gösterimi

Birden fazla sonucu alt alta listelemek için kullanılır. Hesaplama sonuçları, geçmiş kayıtlar gibi şeyler için idealdir.

**Önemli Properties:**

| Property | Açıklama |
|----------|----------|
| `Items` | Listedeki elemanlar |
| `SelectedIndex` | Seçili elemanın sırası |
| `SelectedItem` | Seçili elemanın değeri |
| `TopIndex` | Görünüm en üstündeki eleman (auto-scroll için) |

**Kodda Kullanımı:**
```csharp
// Listeye eleman ekleme:
listBox1.Items.Add("Sonuç: 42");
listBox1.Items.Add(sayi + " asaldır."); // Sayı otomatik metne çevrilir

// Listeyi tamamen temizleme:
listBox1.Items.Clear();

// Auto-Scroll (Yeni eklenen elemanı görmek için listeyi en alta kaydır):
listBox1.Items.Add("Yeni sonuç...");
listBox1.TopIndex = listBox1.Items.Count - 1; // Her zaman en alta kaydır

// Eleman sayısını öğrenme:
int kacEleman = listBox1.Items.Count;

// Örnek: WindowsFormsApp2'den (Sayı Analizi uygulaması)
private void UygulaVeEkle(int sayi, int testIndeks)
{
    string sonuc = "";
    if (testIndeks == 0) sonuc = AsalTesti(sayi);
    else if (testIndeks == 1) sonuc = MukemmelTesti(sayi);

    listBox1.Items.Add(sonuc);
    listBox1.TopIndex = listBox1.Items.Count - 1; // Auto-scroll
}
```

---

### Timer — Otomatik Zamanlayıcı

Arka planda "görünmez" bir saattir. Belirlediğiniz aralıklarla (örneğin her 1 saniyede bir) otomatik olarak kod çalıştırır.

**Toolbox'ta:** Toolbox → Components → Timer

**Önemli Properties:**

| Property | Açıklama | Örnek |
|----------|----------|-------|
| `Enabled` | Çalışıyor mu? | `true`/`false` |
| `Interval` | Kaç milisaniyede bir çalışır? | `1000` = 1 saniye, `500` = yarım saniye |

**Önemli Metotlar:**
- `timer1.Start()` — Başlat
- `timer1.Stop()` — Durdur

**Kodda Kullanımı:**
```csharp
// Timer'ı başlatma/durdurma toggle butonu:
private void btnBaslatDurdur_Click(object sender, EventArgs e)
{
    if (timer1.Enabled)
    {
        timer1.Stop();
        btnBaslatDurdur.Text = "Başlat";
    }
    else
    {
        timer1.Start();
        btnBaslatDurdur.Text = "Durdur";
    }
}

// Timer her Interval kadar süre geçince bu metod çalışır:
private void timer1_Tick(object sender, EventArgs e)
{
    saniye++;
    lblSure.Text = "Geçen süre: " + saniye + " sn";
}
```

**Dikkat:** Timer, forma eklendiğinde Design ekranında görünmez ama aşağıdaki gri alanda (component tray) görünür.

---

## 4. Dosya Diyalogları — SINAV ÖNEMLİ

> Bu bölümü iyi öğrenin! Sınavda mutlaka karşınıza çıkabilir.

### SaveFileDialog — Dosyayı Kaydet Penceresi

"Farklı Kaydet" penceresini açar. Kullanıcı dosya adını ve konumunu seçer, siz de o yola yazarsınız.

**Toolbox'ta:** Toolbox → Dialogs → SaveFileDialog

Forma ekledikten sonra Design ekranında görünmez, gri component tray'de görünür.

**Önemli Properties:**

| Property | Açıklama | Örnek |
|----------|----------|-------|
| `Title` | Pencerenin başlığı | `"Sonucu kaydedin"` |
| `Filter` | Gösterilecek dosya türleri | `"Metin Dosyası\|*.txt\|Tüm Dosyalar\|*.*"` |
| `FileName` | Kullanıcının seçtiği dosyanın tam yolu | (Otomatik dolar) |

**Kullanım Şablonu — Ezberleyin:**
```csharp
private void btnKaydet_Click(object sender, EventArgs e)
{
    // 1. Adım: Kaydet penceresinin başlığını ayarla
    saveFileDialog1.Title = "Sonucu kaydedin";

    // 2. Adım: Hangi dosya türleri gösterilsin? (| ile ayırt edin)
    saveFileDialog1.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

    // 3. Adım: Pencereyi aç ve kullanıcının "Kaydet" e tıklayıp tıklamadığını kontrol et
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
        // 4. Adım: Kullanıcı "Kaydet"e tıkladıysa burası çalışır
        // saveFileDialog1.FileName = kullanıcının seçtiği dosya yolu

        // 'using' bloğu: işlem bitince dosyayı otomatik kapatır
        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
        {
            // Dosyaya satır satır yaz:
            sw.WriteLine("Bu ilk satır.");
            sw.WriteLine(textBox1.Text);        // TextBox içeriğini kaydet
            sw.WriteLine("Ad: " + txtAd.Text);  // Birden fazla bilgi yaz
        }
        // 'using' bloğunun dışına çıkınca dosya kapanır.

        MessageBox.Show("Dosya başarıyla kaydedildi!");
    }
    // Kullanıcı "İptal"e tıkladıysa hiçbir şey olmaz.
}
```

> **Kritik:** `using System.IO;` satırını dosyanın en üstüne eklemeyi unutmayın!

---

### OpenFileDialog — Dosyayı Aç Penceresi

"Dosya Aç" penceresini açar. Kullanıcı bir dosya seçer, siz de o dosyayı okursunuz.

**Kullanım Şablonu — Ezberleyin:**
```csharp
private void btnDosyaAc_Click(object sender, EventArgs e)
{
    // OpenFileDialog'u koddan oluşturuyoruz (forma eklemeden de kullanılabilir)
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Title = "Okumak için dosya seçin";
    ofd.Filter = "Metin Dosyası|*.txt|Tüm Dosyalar|*.*";

    // Pencereyi aç:
    if (ofd.ShowDialog() != DialogResult.OK)
        return; // Kullanıcı iptal ettiyse metodu durdur

    // YÖNTEM 1: Tüm satırları bir dizi olarak oku (en kolay yol):
    string[] satirlar = File.ReadAllLines(ofd.FileName);

    // Her satırı işle:
    for (int i = 0; i < satirlar.Length; i++)
    {
        if (satirlar[i].Trim() == "") continue; // Boş satırları atla
        listBox1.Items.Add(satirlar[i]);
    }

    // YÖNTEM 2: Sadece ilk satırı oku:
    string ilkSatir = File.ReadAllLines(ofd.FileName)[0];

    // YÖNTEM 3: Tüm dosyayı tek metin olarak oku:
    string tumMetin = File.ReadAllText(ofd.FileName);
    textBox1.Text = tumMetin;
}
```

---

### Filter (Filtre) Formatı

```
"Görünen Ad|*.uzantı|Görünen Ad 2|*.uzantı2"

Örnekler:
"Metin Dosyası|*.txt"                          → Sadece .txt
"Metin Dosyası|*.txt|Tüm Dosyalar|*.*"         → .txt veya hepsi
"Excel|*.xlsx|Word|*.docx|Tüm Dosyalar|*.*"    → Üç seçenek
```

---

## 5. Çoklu Form Mimarisi — SINAV ÖNEMLİ

> Bu bölüm sınavda muhtemelen karşınıza çıkacak! Birden fazla form içeren bir soru gelme ihtimali yüksektir.

### Form2 Nasıl Eklenir?

1. Solution Explorer'da projeye sağ tıklayın
2. "Add" → "Windows Form..."
3. İsim verin: `Form2.cs` → Ekle

Bu işlem otomatik olarak `Form2.cs` ve `Form2.Designer.cs` dosyalarını oluşturur.

---

### ShowDialog() vs Show() — ÇOK ÖNEMLİ FARK

```csharp
// YÖNTEM 1: ShowDialog() — Modal Pencere (SINAV İÇİN ÖĞRENIN)
Form2 f2 = new Form2();
f2.ShowDialog();
// Form2 açıldıktan sonra bu satırın ALTINA bir daha gelinmez.
// Form2 kapatılmadan Form1 ile etkileşime geçilemez!
// Not kontrol ekranı, kayıt ekranı gibi "önce bunu tamamla" pencereleri için ideal.

// YÖNTEM 2: Show() — Modeless (Serbest) Pencere
Form2 f2 = new Form2();
f2.Show();
// Form2 açılır ama Form1 de aktif kalmaya devam eder.
// İkisi de aynı anda kullanılabilir.
```

**Sınavda genelde `ShowDialog()` kullanılır.**

---

### Form1'den Form2'ye Veri Geçirme

**Yöntem 1: Public Property (En Temiz Yol)**

```csharp
// Form2.cs içinde:
public partial class Form2 : System.Windows.Forms.Form
{
    // Form1'den gönderilecek veriyi tutacak public değişken:
    public string GonderilenVeri { get; set; }

    public Form2()
    {
        InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        // Form2 açılınca, Form1'den gelen veriyi kullan:
        lblGelen.Text = "Gelen veri: " + GonderilenVeri;
    }
}

// Form1.cs içinde:
private void btnForm2Ac_Click(object sender, EventArgs e)
{
    Form2 f2 = new Form2();
    f2.GonderilenVeri = textBox1.Text; // Veriyi gönder
    f2.ShowDialog();                   // Formu aç
}
```

**Yöntem 2: Constructor (Kurucu) Parametresi**

```csharp
// Form2.cs içinde:
public partial class Form2 : System.Windows.Forms.Form
{
    private string gelenMetin;

    // Parametre alan kurucu:
    public Form2(string metin)
    {
        InitializeComponent();
        gelenMetin = metin;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        lblGelen.Text = gelenMetin;
    }
}

// Form1.cs içinde:
private void btnForm2Ac_Click(object sender, EventArgs e)
{
    Form2 f2 = new Form2(textBox1.Text); // Veriyi constructor'a ver
    f2.ShowDialog();
}
```

**Gerçek Örnek — WindowsFormsApp1:**
```csharp
// Form2 kendi içinde OpenFileDialog ile dosyaları okuyor,
// Form1'den veri geçirmeye gerek yok:
private void button4_Click(object sender, EventArgs e)
{
    Form2 f2 = new Form2();
    f2.ShowDialog(); // Form2 kapanana kadar Form1 kilitlenir
}
```

---

## 6. Olaylar (Events)

### Event Nedir?

Kullanıcı bir şey yaptığında (tıkladı, yazdı, seçti) veya bir şey olduğunda (form açıldı, timer attı) tetiklenen özel metodlara **Event Handler** denir.

### Event Bağlama Yöntemleri

**Yöntem 1 (Kolay): Designer'da çift tıkla**
- Butona çift tıkla → `button1_Click` oluşur
- Form'a çift tıkla → `Form1_Load` oluşur
- Timer'a (component tray'de) çift tıkla → `timer1_Tick` oluşur

**Yöntem 2: Properties → Events sekmesi**
1. Kontrolü seçin
2. Properties penceresinde yıldırım (⚡) simgesine tıklayın
3. İstediğiniz event'e çift tıklayın

### Yaygın Kullanılan Events

| Kontrol | Event | Ne Zaman Tetiklenir? |
|---------|-------|---------------------|
| Form | `Load` | Form ilk açıldığında |
| Button | `Click` | Tıklandığında |
| TextBox | `TextChanged` | Her tuş basışında |
| ComboBox | `SelectedIndexChanged` | Seçim değiştiğinde |
| ListBox | `SelectedIndexChanged` | Seçim değiştiğinde |
| Timer | `Tick` | Her interval sonunda |
| NumericUpDown | `ValueChanged` | Değer değiştiğinde |

---

## 7. Dosya Okuma ve Yazma

### StreamWriter ile Dosyaya Yazma

```csharp
using System.IO; // Dosyanın en üstünde olmalı!

// TEMEL KULLANIM:
using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
{
    sw.WriteLine("Bu bir satırdır."); // Satır ekler (sonunda Enter var)
    sw.Write("Bu satır sonu yok");    // Enter olmadan yazar
    sw.WriteLine();                    // Sadece boş satır ekler
}
// 'using' bloğu bitince dosya otomatik kapanır.

// MEVCUT DOSYANIN SONUNA EKLEME (append = true):
using (StreamWriter sw = new StreamWriter(dosyaYolu, append: true))
{
    sw.WriteLine("Bu satır dosyanın sonuna eklenir.");
}
```

### File.ReadAllLines ile Dosya Okuma

```csharp
using System.IO;

// Tüm satırları bir string dizisi olarak oku:
string[] satirlar = File.ReadAllLines(ofd.FileName);

// Her satırı işle:
for (int i = 0; i < satirlar.Length; i++)
{
    if (satirlar[i].Trim() == "") continue; // Boş satırları atla
    listBox1.Items.Add(satirlar[i]);
}
```

### Virgüllü / Noktalı Virgüllü Satırları Parçalama (Split)

```csharp
// Örnek satır: "12345;Ahmet Yılmaz;70;85"

string satir = "12345;Ahmet Yılmaz;70;85";

// Split: Metni belirli karakterden böl, dizi döndürür
string[] parcalar = satir.Split(';');
// parcalar[0] = "12345"
// parcalar[1] = "Ahmet Yılmaz"
// parcalar[2] = "70"
// parcalar[3] = "85"

// Sayıya çevirme:
int no    = Convert.ToInt32(parcalar[0]);
string ad = parcalar[1];
double viz = Convert.ToDouble(parcalar[2]);
double fin = Convert.ToDouble(parcalar[3]);

// Virgülle ayrılmış örnek: "1,5,12,33,42,49"
string[] sayilar = "1,5,12,33,42,49".Split(',');
List<int> liste = new List<int>();
for (int i = 0; i < sayilar.Length; i++)
{
    liste.Add(Convert.ToInt32(sayilar[i]));
}
```

---

## 8. Sıkça Kullanılan Kod Kalıpları

### try-catch ile Güvenli Sayı Okuma

```csharp
private void btnHesapla_Click(object sender, EventArgs e)
{
    try
    {
        // Bu kodlar hata verirse 'catch' bloğuna atlar:
        double vize = Convert.ToDouble(txtVize.Text);
        double final = Convert.ToDouble(txtFinal.Text);

        double ortalama = vize * 0.4 + final * 0.6;
        lblSonuc.Text = ortalama.ToString("F2"); // 2 ondalık basamak göster
    }
    catch
    {
        // Hata oluşursa burası çalışır (örn: kullanıcı harf yazdıysa):
        MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
```

### MessageBox Kullanımı

```csharp
// Basit bilgi mesajı:
MessageBox.Show("İşlem tamamlandı.");

// Başlık ve ikon ile:
MessageBox.Show("Dosya kaydedildi!", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

// Evet/Hayır sorusu:
DialogResult cevap = MessageBox.Show("Emin misiniz?", "Onay",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
if (cevap == DialogResult.Yes)
{
    // Evet'e basıldı
}
```

### Random — Rastgele Sayı Üretme

```csharp
// Sınıf düzeyinde tanımla:
Random r = new Random();

// Belirli aralıkta sayı üret:
int sayi = r.Next(1, 50);   // 1'den 49'a kadar (50 dahil değil!)
int sayi2 = r.Next(0, 101); // 0'dan 100'e kadar

// Birbirinden farklı 6 sayı üretme (loto gibi):
List<int> liste = new List<int>();
while (liste.Count < 6)
{
    int yeni = r.Next(1, 50);
    if (!liste.Contains(yeni)) // Tekrar ekleme!
        liste.Add(yeni);
}
liste.Sort(); // Küçükten büyüğe sırala
```

### String.Join — Listeyi Metne Çevirme

```csharp
List<int> liste = new List<int>() { 5, 12, 23, 38, 41, 47 };

// Elemanları virgülle birleştir:
string metin = String.Join(",", liste); // "5,12,23,38,41,47"
```

### Harf Notu Hesaplama

```csharp
private string HarfNotuHesapla(double ortalama)
{
    if (ortalama >= 90) return "AA";
    else if (ortalama >= 85) return "BA";
    else if (ortalama >= 75) return "BB";
    else if (ortalama >= 70) return "CB";
    else if (ortalama >= 60) return "CC";
    else if (ortalama >= 55) return "DC";
    else if (ortalama >= 50) return "DD";
    else return "FF";
}
```

### Koşula Göre Label Rengi Değiştirme

```csharp
if (ortalama >= 50)
{
    lblDurum.Text = "Geçti";
    lblDurum.ForeColor = System.Drawing.Color.Green;
}
else
{
    lblDurum.Text = "Kaldı";
    lblDurum.ForeColor = System.Drawing.Color.Red;
}
```

---

## 9. Sınav Kontrol Listesi

Sınav sırasında bu listeyi zihinsel olarak kontrol edin:

### Proje Başlarken
- [ ] `using System.IO;` eklendi mi? (dosya işlemi varsa)
- [ ] Tüm kontrollere anlamlı `Name` verildi mi? (`btnHesapla`, `txtAd` vb.)
- [ ] Form başlığı (`Text` property) anlamlı mı?

### SaveFileDialog / OpenFileDialog Kullanırken
- [ ] `ShowDialog() == DialogResult.OK` kontrolü yapıldı mı?
- [ ] `using (StreamWriter sw = ...)` kalıbı kullanıldı mı?
- [ ] `sw.WriteLine(...)` ile doğru veriler yazıldı mı?
- [ ] Okuma: `File.ReadAllLines(ofd.FileName)` kullanıldı mı?

### Multi-Form Projesinde
- [ ] `Form2 f2 = new Form2();` ile nesne oluşturuldu mu?
- [ ] `f2.ShowDialog()` çağrıldı mı?
- [ ] Form2'ye veri geçirilmesi gerekiyorsa public property veya constructor kullanıldı mı?

### Timer Kullanırken
- [ ] `timer1.Interval` uygun değere ayarlandı mı? (1000 = 1 saniye)
- [ ] `timer1_Tick` event handler'ı bağlandı mı?
- [ ] Başlat/Durdur mantığı doğru mu?

### Genel
- [ ] `try-catch` ile kullanıcı girişi doğrulandı mı?
- [ ] `listBox1.Items.Clear()` ile eski sonuçlar temizlendi mi?
- [ ] `listBox1.TopIndex = listBox1.Items.Count - 1;` ile auto-scroll eklendi mi?
- [ ] `Convert.ToInt32()` / `Convert.ToDouble()` ile metin→sayı dönüşümleri yapıldı mı?
- [ ] Form_Load'da ComboBox için `comboBox1.SelectedIndex = 0;` ayarlandı mı?

---

*Bu notlar NTP-2-VIZE projesi için hazırlanmıştır. WindowsFormsApp1 (Loto) ve WindowsFormsApp2 (Sayı Analizi) projelerindeki gerçek kod örneklerine bakarak pratik yapmanız önerilir.*
