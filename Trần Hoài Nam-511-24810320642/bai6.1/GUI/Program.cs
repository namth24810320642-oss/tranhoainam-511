using System;
using System.Windows.Forms;
using bai6._1.GUI;

namespace bai6._1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBanHang());
        }
    }
}