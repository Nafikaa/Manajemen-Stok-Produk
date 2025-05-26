using System;
using System.Windows.Forms;

namespace ManajemenStokProduk
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Buka LoginForm terlebih dahulu
            Application.Run(new Form2());
        }
    }
}
