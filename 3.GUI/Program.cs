using _3.GUI.View;
using _3.GUI.View.BanHang;
using _3.GUI.View.FrmNhanvien;
using _3.GUI.View.FromSanPham;

namespace _3.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new FRDangNhap());
=======
            Application.Run(new FrmGioHang());
>>>>>>> 33a27ea21b69dab0825ad3dc65caa64f5960f8e6
        }
    }
}