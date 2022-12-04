using _3.GUI.View;
using _3.GUI.View.BanHang;
using _3.GUI.View.FrmNhanvien;
using _3.GUI.View.FromSanPham;

namespace _3.GUI
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FRDangNhap());
        }
    }
}