# 📚 WinForms Geliştirme Ders Notları (Sıfırdan Başlayanlar İçin)

Bu proje, C# ile Windows masaüstü uygulamaları geliştirmenin temel taşlarını öğretmek amacıyla hazırlanmıştır. Eğer daha önce hiç kod yazmadıysan veya bir derse gitmediysen, bu notlar senin için bir rehber olacaktır.

## 1. WinForms Nedir?
Windows Forms (WinForms), görsel arayüzü olan programlar yapmanı sağlar. Sadece kod yazmazsın; aynı zamanda butonları, kutuları ve yazıları bir ekran üzerine sürükleyip bırakarak yerleştirirsin.

## 2. Visual Studio Arayüzü (Tasarım Ekranı)
Bir formu açtığında (örneğin `Form1.cs`), karşında iki dünya vardır:
1.  **Design (Tasarım) Ekranı:** Butonları gördüğün yer.
2.  **Code (Kod) Ekranı:** Butona basınca ne olacağını yazdığın yer.

### Önemli Pencereler:
-   **Toolbox (Araç Kutusu):** Uygulamana ekleyebileceğin her şey buradadır (Button, Label, TextBox, Timer vb.).
-   **Properties (Özellikler) Penceresi:** Bir öğeye tıkladığında sağ altta açılır. Buradan öğenin:
    -   `Name`: Kod yazarken ona nasıl hitap edeceğin (Örn: `btnKaydet`).
    -   `Text`: Üzerinde yazan yazı (Örn: "Kaydet").
    -   `BackColor`: Arka plan rengi.
    -   `Font`: Yazı tipi ve boyutu.
-   **Solution Explorer:** Projendeki dosyaların listesidir.

## 3. Temel Kontroller ve Kullanımları
-   **Label:** Sadece yazı göstermek için kullanılır.
-   **Button:** Kullanıcının tıklayıp bir işlemi başlatması için.
-   **TextBox:** Kullanıcının klavyeden metin girişi yapması için.
-   **NumericUpDown:** Sadece sayı seçtirmek için (Ok işaretleri ile artırıp azaltılabilir).
-   **ListBox:** Birden fazla sonucu alt alta listelemek için.
-   **Timer:** Arka planda "görünmez" bir saattir. Belirli aralıklarla (örneğin her 1000 milisaniye = 1 saniye) kod çalıştırır.

## 4. Olaylar (Events)
WinForms'da her şey bir **Olay** üzerine kuruludur.
-   Bir butona **çift tıklarsan**, Visual Studio seni otomatik olarak kod ekranına atar ve `button1_Click` metodunu oluşturur.
-   Bu metodun içine yazdığın her şey, sadece o butona basıldığında çalışır.

## 5. Dosya İşlemleri (Kaydetme ve Açma)
Programdaki verileri kalıcı hale getirmek için dosyaları kullanırız.
-   **SaveFileDialog:** "Farklı Kaydet" penceresini açar.
-   **OpenFileDialog:** "Dosya Aç" penceresini açar.
-   **StreamWriter:** Bir dosyaya yazı yazmamızı sağlayan "kalem" gibidir.
-   **File.ReadAllLines:** Bir dosyadaki tüm satırları tek seferde okuyup bize verir.

## 6. Proje Yapısı
-   **Program.cs:** Uygulamanın "kalbidir". Program buradan başlar.
-   **Form1.cs:** Senin yazdığın mantık kodları.
-   **Form1.Designer.cs:** Sen tasarım ekranında bir butonu kaydırdığında Visual Studio'nun otomatik yazdığı kodlar. **Buraya elle müdahale etmemelisin!**

---
*Bu notlar, projeyi incelerken sana yol göstermesi için hazırlanmıştır. İyi çalışmalar!*
