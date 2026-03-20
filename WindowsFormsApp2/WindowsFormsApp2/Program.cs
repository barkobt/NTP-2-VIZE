using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /* 
       Uygulamanın ana kapısı (Giriş Noktası). 
       WindowsFormsApp2 projesi buradan başlar.
    */
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Programın ana ekranını (Form1) çalıştırır.
            Application.Run(new Form1());
        }
    }
}

