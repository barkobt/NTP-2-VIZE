using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /* 
       Program.cs: Uygulamanın 'Giriş Noktası' (Entry Point) burasıdır.
       Program çalıştırıldığında ilk olarak bu dosya devreye girer.
    */
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread] // Windows Form uygulamalarının düzgün çalışması için gereklidir.
        static void Main()
        {
            // Görsel özellikleri (renk, yazı tipi vb.) etkinleştirir.
            Application.EnableVisualStyles();
            // Varsayılan metin işleme ayarını yapar.
            Application.SetCompatibleTextRenderingDefault(false);

            // Programın ana penceresini (Form1) başlatır.
            // Buradaki 'Form1' ismini 'Form2' yaparsanız uygulama Form2 ile açılır.
            Application.Run(new Form1());
        }
    }
}

