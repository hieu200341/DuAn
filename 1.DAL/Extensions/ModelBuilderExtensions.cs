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
                new khachHang() { SDT_KH = "0123456789", TenKH = "Không tên", gioiTinh=true, diaChi="Hà Nội", trangThai=true, diem = 0 },
                new khachHang() { SDT_KH = "0923456567", TenKH = "Nguyễn Văn B", gioiTinh = false, diaChi = "Hải Phòng", trangThai = true, diem = 0 },
                new khachHang() { SDT_KH = "0923456678", TenKH = "Nguyễn Văn C", gioiTinh = true, diaChi = "Lạng Sơn", trangThai = true, diem = 0 }
                );
            modelBuilder.Entity<mauSac>().HasData(
                new mauSac() { IDMauSac = 1, tenMau = "Xanh" ,trangThai = true},
                new mauSac() { IDMauSac = 2, tenMau = "Đỏ", trangThai = true },
                new mauSac() { IDMauSac = 3, tenMau = "Trắng", trangThai = true },
                new mauSac() { IDMauSac = 4, tenMau = "Hồng", trangThai = true },
                new mauSac() { IDMauSac = 5, tenMau = "Nâu", trangThai = true }
                );
            modelBuilder.Entity<size>().HasData(
                new size() { IDSize = 1, SiZe = "S", trangThai = true },
                new size() { IDSize = 2, SiZe = "M", trangThai = true },
                new size() { IDSize = 3, SiZe = "L", trangThai = true },
                new size() { IDSize = 4, SiZe = "XL", trangThai = true },
                new size() { IDSize = 5, SiZe = "XXL", trangThai = true }
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
                new nhanVien() { IDNhanVien = 1, TenNV = "Nguyễn Văn Đạo", IDChucVu = 1, diaChi = "Tuyên Quang",SDT="0379702133", email="dao7773@gmail.com" ,tinhTrang=true, matKhau="123" },
                 new nhanVien() { IDNhanVien = 2, TenNV = "Phạm Bá Hiếu", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0963147647", email = "hieupbph20211@fpt.edu.vn", tinhTrang = true, matKhau = "123" },
                 new nhanVien() { IDNhanVien = 3, TenNV = "Vũ Văn Quý", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0962611544", email = "quyvvph26931@fpt.edu.vn", tinhTrang = true, matKhau = "123" },
                 new nhanVien() { IDNhanVien = 4, TenNV = "Vũ Đình Hưng", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0314134789", email = "hungvdph27472@fpt.edu.vn", tinhTrang = true, matKhau = "123" }
                );
            modelBuilder.Entity<sanPhamChiTiet>().HasData(
                new sanPhamChiTiet() { IDSanPhamChiTiet = 1,maSP = "SP01", TenSP = "Áo Thun Unisex", Gianhap = 100000, Giaban = 110000, Soluong = 1900, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh="" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 2, maSP = "SP02", TenSP = "Áo Thun BAD VIBES BA VÌ ", Gianhap = 125000, Giaban = 200000, Soluong = 1600, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 3, maSP = "SP03", TenSP = "Áo Thun SAD BOIZ SADTAGRAM ", Gianhap = 115000, Giaban = 170000, Soluong = 1000, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 4, maSP = "SP04", TenSP = "Áo Thun 18 EIGHTEEN STUDIO", Gianhap = 105000, Giaban = 150000, Soluong = 900, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 5, maSP = "SP05", TenSP = "Áo Thun UNDERBROKEN ", Gianhap = 120000, Giaban = 210000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 6, maSP = "SP06", TenSP = "Áo Thun WAKE MORE TO THE POINT", Gianhap = 125000, Giaban = 220000, Soluong = 800, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 7, maSP = "SP07", TenSP = "Áo Thun SADBOIZ SAD STORY", Gianhap = 1600, Giaban = 250000, Soluong = 600, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 8, maSP = "SP08", TenSP = "Áo Thun WAKE MORE TO THE POINT", Gianhap = 200000, Giaban = 290000, Soluong = 1900, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 9, maSP = "SP09", TenSP = "Áo Thun PHI HÀNH GIA VŨ TRỤ", Gianhap = 130000, Giaban = 199000, Soluong = 1500, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 10, maSP = "SP10", TenSP = "Áo Thun FIGHT FOR YOUR RIGHT", Gianhap = 110000, Giaban = 170000, Soluong = 1400, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 11, maSP = "SP11", TenSP = "Áo thun nữ Premium YODY", Gianhap = 100000, Giaban = 150000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 12, maSP = "SP12", TenSP = "Áo thun nam Premium YODY,", Gianhap = 135000, Giaban = 250000, Soluong = 1400, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 13, maSP = "SP13", TenSP = "Áo Thun MẶT CƯỜI MAY MẮN", Gianhap = 140000, Giaban = 210000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 14, maSP = "SP14", TenSP = "Áo Thun Tay Lỡ Form Rộng", Gianhap = 150000, Giaban = 245000, Soluong = 1200, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 15, maSP = "SP15", TenSP = "Áo Thun HECHO POR MAMA TEE ", Gianhap = 200000, Giaban = 270000, Soluong = 1300, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 16, maSP = "SP16", TenSP = "Áo Thun SAD BOIZ VIBES TOSS BLACK", Gianhap = 230000, Giaban = 300000, Soluong = 1420, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 17, maSP = "SP17", TenSP = "Áo Thun Graphic Logo Future ", Gianhap = 130000, Giaban = 205000, Soluong = 1500, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 18, maSP = "SP18", TenSP = "Áo Thun YOUNG GREEN ", Gianhap = 126000, Giaban = 185000, Soluong = 1400, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 19, maSP = "SP19", TenSP = "Áo Thun 3 Sọc Essentials", Gianhap = 192000, Giaban = 276000, Soluong = 1600, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 20, maSP = "SP20", TenSP = "Áo Thun GẤU TRÚC PANDA", Gianhap = 300000, Giaban = 400000, Soluong = 1700, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" }
                );
        }
    }
}
