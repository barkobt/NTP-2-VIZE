using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    /*
       Uygulamanın başladığı yer (Giriş Noktası).
       Program her zaman buradan çalışmaya başlar.
    */
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ana ekran olarak Form1'i çalıştır:
            Application.Run(new Form1());
        }
    }
}
