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
                new chucVu() { IDChucVu = 1, tenCV = "Quản lý" },
                new chucVu() { IDChucVu = 2, tenCV = "Nhân viên" }
                );
            modelBuilder.Entity<hangSX>().HasData(
                new hangSX() { IDHangSX = 1, tenHangSX = "Sao Vàng", trangThai = true },
                new hangSX() { IDHangSX = 2, tenHangSX = "Sahara", trangThai = true },
                new hangSX() { IDHangSX = 3, tenHangSX = "Tỷ Xuân", trangThai = true }
                );
            modelBuilder.Entity<khachHang>().HasData(
                new khachHang() { SDT_KH = "0123456789", TenKH = "Nguyễn Văn A", gioiTinh=true, diaChi="Hà Nội", trangThai=true, diem = 10000 },
                new khachHang() { SDT_KH = "0123456567", TenKH = "Nguyễn Văn B", gioiTinh = false, diaChi = "Hải Phòng", trangThai = true, diem = 10000 },
                new khachHang() { SDT_KH = "0123456678", TenKH = "Nguyễn Văn C", gioiTinh = true, diaChi = "Lạng Sơn", trangThai = true, diem = 10000 }
                );
            modelBuilder.Entity<mauSac>().HasData(
                new mauSac() { IDMauSac = 1, tenMau = "Xanh" ,trangThai = true},
                new mauSac() { IDMauSac = 2, tenMau = "Đỏ", trangThai = true },
                new mauSac() { IDMauSac = 3, tenMau = "Trắng", trangThai = true }
                );
            modelBuilder.Entity<size>().HasData(
                new size() { IDSize = 1, SiZe = "M", trangThai = true },
                new size() { IDSize = 2, SiZe = "L", trangThai = true },
                new size() { IDSize = 3, SiZe = "XL", trangThai = true }
                );
            modelBuilder.Entity<sanPham1>().HasData(
              new sanPham1() { IDsanPham = 1, tenLoaiHang = "Cổ tròn", trangThai = true },
              new sanPham1() { IDsanPham = 2, tenLoaiHang = "Cổ tim", trangThai = true },
              new sanPham1() { IDsanPham = 3, tenLoaiHang = "Oversize", trangThai = true },
              new sanPham1() { IDsanPham = 4, tenLoaiHang = "Ba lỗ", trangThai = true },
              new sanPham1() { IDsanPham = 5, tenLoaiHang = "Cổ chữ V", trangThai = true },
              new sanPham1() { IDsanPham = 6, tenLoaiHang = "Polo", trangThai = true }
             
              );
            modelBuilder.Entity<nhanVien>().HasData(
                new nhanVien() { IDNhanVien = 1, TenNV = "Nguyễn Văn Đạo", IDChucVu = 1, diaChi = "Tuyên Quang",SDT="0379702133", email="daonvph18705@gmail.com" ,tinhTrang=true, matKhau="123" },
                 new nhanVien() { IDNhanVien = 2, TenNV = "Nguyễn Văn B", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0379702144", email = "baaa@gmail.com", tinhTrang = true, matKhau = "123" }
                );
            modelBuilder.Entity<sanPhamChiTiet>().HasData(
                new sanPhamChiTiet() { IDSanPhamChiTiet = 1,maSP = "SP01", TenSP = "Lacoste", Gianhap = 1000, Giaban = 1500, Soluong = 1000, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh="" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 2, maSP = "SP02", TenSP = "Gucci", Gianhap = 1500, Giaban = 2000, Soluong = 1200, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 3, maSP = "SP03", TenSP = "ADLV", Gianhap = 1200, Giaban = 1700, Soluong = 1300, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 4, maSP = "SP04", TenSP = "Uniqlo", Gianhap = 1600, Giaban = 2100, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" }
                );
        }
    }
}
