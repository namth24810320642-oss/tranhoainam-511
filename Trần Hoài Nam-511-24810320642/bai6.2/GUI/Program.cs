using System;
using System.Windows.Forms;
using bai6._2.GUI;

namespace bai6._2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy ứng dụng Quản lý Nhân sự & Tính lương
            Application.Run(new frmHRM());
        }
    }
}