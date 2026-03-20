# WindowsFormsApp1 - Loto Uygulaması

## Proje Özeti
Bu proje, .NET Framework 4.7.2 kullanılarak geliştirilmiş bir Windows Forms uygulamasıdır. Kullanıcıların rastgele loto numaraları üretmesini, bu numaraları dosyaya kaydetmesini ve daha sonra çekiliş sonuçlarıyla karşılaştırarak sonuçları kontrol etmesini sağlar.

### Temel Teknolojiler
- **Dil:** C#
- **Çerçeve:** .NET Framework 4.7.2
- **UI:** WinForms (Windows Forms)

### Mimari
Uygulama iki ana formdan oluşur:
1.  **Form1:** Ana ekran. Rastgele numara üretme, çoklu loto oynama ve sonuçları kaydetme işlemlerini yürütür.
2.  **Form2:** Sonuç kontrol ekranı. Kaydedilen çekiliş ve kolon dosyalarını karşılaştırarak kaç numaranın tuttuğunu listeler.

## Derleme ve Çalıştırma
Uygulama Visual Studio 2022 veya daha yeni bir sürümle açılmalıdır.

### Adımlar:
1.  `WindowsFormsApp1.slnx` veya `WindowsFormsApp1/WindowsFormsApp1.csproj` dosyasını Visual Studio ile açın.
2.  `Build` menüsünden `Build Solution` (Ctrl+Shift+B) seçeneğini kullanarak projeyi derleyin.
3.  `F5` tuşuna basarak uygulamayı başlatın.

**Not:** Proje .NET Framework 4.7.2 bağımlılığına sahiptir. Eğer yüklü değilse, Visual Studio Installer üzerinden kurulmalıdır.

## Geliştirme Notları

### Tasarımcı (Designer) Sorunları:
- Eğer tasarım ekranı (Designer) açılmazsa, `Form1.cs` veya `Form2.cs` dosyalarında sınıf tanımının `System.Windows.Forms.Form` olarak tam nitelikli (fully qualified) olduğundan emin olun.
- WinForms tasarımcısı DPI ölçeklendirme sorunları yaşayabilir. Visual Studio'yu %100 ölçeklendirme ile çalıştırmak bu sorunları çözer.

### Kod Standartları:
- `InitializeComponent()` metoduna manuel müdahale etmek yerine, mümkünse Visual Studio Designer kullanılmalıdır.
- Dosya işlemleri için `System.IO` kütüphanesi kullanılmaktadır.
- Proje `WindowsFormsApp1` namespace'i altında organize edilmiştir.

### Anahtar Dosyalar:
- `Program.cs`: Uygulamanın giriş noktası (`Main`).
- `Form1.cs`: Loto üretim mantığı.
- `Form2.cs`: Sonuç karşılaştırma mantığı.
- `WindowsFormsApp1.csproj`: Proje yapılandırması ve bağımlılıkları.
