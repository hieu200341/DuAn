using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData(
                new chucVu() { maChucVu = 1, tenCV = "Quản lý" },
                new chucVu() { maChucVu = 2, tenCV = "Nhân viên" }
                );
            modelBuilder.Entity<hangSX>().HasData(
                new hangSX() { maHangSX = 1, tenHangSX = "Sao Vàng", trangThai = true },
                new hangSX() { maHangSX = 2, tenHangSX = "Sahara", trangThai = true },
                new hangSX() { maHangSX = 3, tenHangSX = "Tỷ Xuân", trangThai = true }
                );
            modelBuilder.Entity<khachHang>().HasData(
                new khachHang() { SDT_KH = "0123456789", TenKH = "Nguyễn Văn A", gioiTinh=true, diaChi="Hà Nội", trangThai=true },
                new khachHang() { SDT_KH = "0123456567", TenKH = "Nguyễn Văn B", gioiTinh = false, diaChi = "Hải Phòng", trangThai = true },
                new khachHang() { SDT_KH = "0123456678", TenKH = "Nguyễn Văn C", gioiTinh = true, diaChi = "Lạng Sơn", trangThai = true }
                );
            modelBuilder.Entity<mauSac>().HasData(
                new mauSac() { maMauSac = 1, tenMau = "Xanh" ,trangThai = true},
                new mauSac() { maMauSac = 2, tenMau = "Đỏ", trangThai = true },
                new mauSac() { maMauSac = 3, tenMau = "Trắng", trangThai = true }
                );
            modelBuilder.Entity<size>().HasData(
                new size() { maSize = 1, SiZe = "M", trangThai = true },
                new size() { maSize = 2, SiZe = "L", trangThai = true },
                new size() { maSize = 3, SiZe = "XL", trangThai = true }
                );
            modelBuilder.Entity<nhanVien>().HasData(
                new nhanVien() { maNhanVien= 1, TenNV = "Nguyễn Văn Đạo", maChucVu=1, diaChi = "Tuyên Quang",SDT="0379702133", email="daonvph18705@gmail.com" ,tinhTrang=true, matKhau="123" },
                 new nhanVien() { maNhanVien = 2, TenNV = "Nguyễn Văn B", maChucVu = 2, diaChi = "Hà Nội", SDT = "0379702144", email = "baaa@gmail.com", tinhTrang = true, matKhau = "123" }
                );
            modelBuilder.Entity<SanPham>().HasData(
                new SanPham() { maSanPham = 1, TenSP = "Lacoste", Gianhap = 1000, Giaban = 1500, Soluong = 1000, Trangthai = true, maHangSX = 1, maSize = 1,maMauSac = 1, linkAnh="" },
                new SanPham() { maSanPham = 2, TenSP = "Gucci", Gianhap = 1500, Giaban = 2000, Soluong = 1200, Trangthai = true, maHangSX = 2, maSize = 2, maMauSac = 2, linkAnh = "" },
                new SanPham() { maSanPham = 3, TenSP = "ADLV", Gianhap = 1200, Giaban = 1700, Soluong = 1300, Trangthai = true, maHangSX = 3, maSize = 3, maMauSac = 3, linkAnh = "" },
                new SanPham() { maSanPham = 4, TenSP = "Uniqlo", Gianhap = 1600, Giaban = 2100, Soluong = 1400, Trangthai = true, maHangSX = 2, maSize = 1, maMauSac = 3, linkAnh = "" }
                );
        }
    }
}
