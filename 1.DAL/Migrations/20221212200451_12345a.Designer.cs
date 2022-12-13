﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221212200451_12345a")]
    partial class _12345a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Models.chucVu", b =>
                {
                    b.Property<int>("IDChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDChucVu"), 1L, 1);

                    b.Property<string>("tenCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDChucVu");

                    b.ToTable("chucVu", (string)null);

                    b.HasData(
                        new
                        {
                            IDChucVu = 1,
                            tenCV = "Quản lý"
                        },
                        new
                        {
                            IDChucVu = 2,
                            tenCV = "Nhân viên"
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.hangSX", b =>
                {
                    b.Property<int>("IDHangSX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHangSX"), 1L, 1);

                    b.Property<string>("tenHangSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDHangSX");

                    b.ToTable("hangSX", (string)null);

                    b.HasData(
                        new
                        {
                            IDHangSX = 1,
                            tenHangSX = "Sao Vàng",
                            trangThai = true
                        },
                        new
                        {
                            IDHangSX = 2,
                            tenHangSX = "Sahara",
                            trangThai = true
                        },
                        new
                        {
                            IDHangSX = 3,
                            tenHangSX = "Tỷ Xuân",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.Property<int>("IDHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHoaDon"), 1L, 1);

                    b.Property<int>("IDNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("SDT_KH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ghiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayBan")
                        .HasColumnType("datetime2");

                    b.Property<float>("tongTien")
                        .HasColumnType("real");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDHoaDon");

                    b.HasIndex("IDNhanVien");

                    b.HasIndex("SDT_KH");

                    b.ToTable("hoaDon", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDonChiTiet", b =>
                {
                    b.Property<int>("IDHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.Property<float>("donGia")
                        .HasColumnType("real");

                    b.HasKey("IDHoaDon", "IDSanPham");

                    b.HasIndex("IDSanPham");

                    b.ToTable("hoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.khachHang", b =>
                {
                    b.Property<string>("SDT_KH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("diem")
                        .HasColumnType("int");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("SDT_KH");

                    b.ToTable("khachHang", (string)null);

                    b.HasData(
                        new
                        {
                            SDT_KH = "0123456789",
                            TenKH = "Nguyễn Văn A",
                            diaChi = "Hà Nội",
                            diem = 10000,
                            gioiTinh = true,
                            trangThai = true
                        },
                        new
                        {
                            SDT_KH = "0123456567",
                            TenKH = "Nguyễn Văn B",
                            diaChi = "Hải Phòng",
                            diem = 10000,
                            gioiTinh = false,
                            trangThai = true
                        },
                        new
                        {
                            SDT_KH = "0123456678",
                            TenKH = "Nguyễn Văn C",
                            diaChi = "Lạng Sơn",
                            diem = 10000,
                            gioiTinh = true,
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.mauSac", b =>
                {
                    b.Property<int>("IDMauSac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDMauSac"), 1L, 1);

                    b.Property<string>("tenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDMauSac");

                    b.ToTable("mauSac", (string)null);

                    b.HasData(
                        new
                        {
                            IDMauSac = 1,
                            tenMau = "Xanh",
                            trangThai = true
                        },
                        new
                        {
                            IDMauSac = 2,
                            tenMau = "Đỏ",
                            trangThai = true
                        },
                        new
                        {
                            IDMauSac = 3,
                            tenMau = "Trắng",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.Property<int>("IDNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDNhanVien"), 1L, 1);

                    b.Property<int>("IDChucVu")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("tinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("IDNhanVien");

                    b.HasIndex("IDChucVu");

                    b.ToTable("nhanVien", (string)null);

                    b.HasData(
                        new
                        {
                            IDNhanVien = 1,
                            IDChucVu = 1,
                            SDT = "0379702133",
                            TenNV = "Nguyễn Văn Đạo",
                            diaChi = "Tuyên Quang",
                            email = "daonvph18705@gmail.com",
                            matKhau = "123",
                            tinhTrang = true
                        },
                        new
                        {
                            IDNhanVien = 2,
                            IDChucVu = 2,
                            SDT = "0379702144",
                            TenNV = "Nguyễn Văn B",
                            diaChi = "Hà Nội",
                            email = "baaa@gmail.com",
                            matKhau = "123",
                            tinhTrang = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.sanPham1", b =>
                {
                    b.Property<int>("IDsanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDsanPham"), 1L, 1);

                    b.Property<string>("tenLoaiHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDsanPham");

                    b.ToTable("sanPham", (string)null);

                    b.HasData(
                        new
                        {
                            IDsanPham = 1,
                            tenLoaiHang = "Cổ tròn",
                            trangThai = true
                        },
                        new
                        {
                            IDsanPham = 2,
                            tenLoaiHang = "Cổ tim",
                            trangThai = true
                        },
                        new
                        {
                            IDsanPham = 3,
                            tenLoaiHang = "Oversize",
                            trangThai = true
                        },
                        new
                        {
                            IDsanPham = 4,
                            tenLoaiHang = "Ba lỗ",
                            trangThai = true
                        },
                        new
                        {
                            IDsanPham = 5,
                            tenLoaiHang = "Cổ chữ V",
                            trangThai = true
                        },
                        new
                        {
                            IDsanPham = 6,
                            tenLoaiHang = "Polo",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.Property<int>("IDSanPhamChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDSanPhamChiTiet"), 1L, 1);

                    b.Property<float>("Giaban")
                        .HasColumnType("real");

                    b.Property<float>("Gianhap")
                        .HasColumnType("real");

                    b.Property<int>("IDHangSX")
                        .HasColumnType("int");

                    b.Property<int>("IDMauSac")
                        .HasColumnType("int");

                    b.Property<int>("IDSize")
                        .HasColumnType("int");

                    b.Property<int>("IDsanPham")
                        .HasColumnType("int");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.Property<string>("linkAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDSanPhamChiTiet");

                    b.HasIndex("IDHangSX");

                    b.HasIndex("IDMauSac");

                    b.HasIndex("IDSize");

                    b.HasIndex("IDsanPham");

                    b.ToTable("sanPhamChiTiet", (string)null);

                    b.HasData(
                        new
                        {
                            IDSanPhamChiTiet = 1,
                            Giaban = 1500f,
                            Gianhap = 1000f,
                            IDHangSX = 1,
                            IDMauSac = 1,
                            IDSize = 1,
                            IDsanPham = 1,
                            Soluong = 1000,
                            TenSP = "Lacoste",
                            Trangthai = true,
                            linkAnh = "",
                            maSP = "SP01"
                        },
                        new
                        {
                            IDSanPhamChiTiet = 2,
                            Giaban = 2000f,
                            Gianhap = 1500f,
                            IDHangSX = 2,
                            IDMauSac = 2,
                            IDSize = 2,
                            IDsanPham = 2,
                            Soluong = 1200,
                            TenSP = "Gucci",
                            Trangthai = true,
                            linkAnh = "",
                            maSP = "SP02"
                        },
                        new
                        {
                            IDSanPhamChiTiet = 3,
                            Giaban = 1700f,
                            Gianhap = 1200f,
                            IDHangSX = 3,
                            IDMauSac = 3,
                            IDSize = 3,
                            IDsanPham = 1,
                            Soluong = 1300,
                            TenSP = "ADLV",
                            Trangthai = true,
                            linkAnh = "",
                            maSP = "SP03"
                        },
                        new
                        {
                            IDSanPhamChiTiet = 4,
                            Giaban = 2100f,
                            Gianhap = 1600f,
                            IDHangSX = 2,
                            IDMauSac = 3,
                            IDSize = 1,
                            IDsanPham = 3,
                            Soluong = 1400,
                            TenSP = "Uniqlo",
                            Trangthai = true,
                            linkAnh = "",
                            maSP = "SP04"
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.size", b =>
                {
                    b.Property<int>("IDSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDSize"), 1L, 1);

                    b.Property<string>("SiZe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IDSize");

                    b.ToTable("size", (string)null);

                    b.HasData(
                        new
                        {
                            IDSize = 1,
                            SiZe = "M",
                            trangThai = true
                        },
                        new
                        {
                            IDSize = 2,
                            SiZe = "L",
                            trangThai = true
                        },
                        new
                        {
                            IDSize = 3,
                            SiZe = "XL",
                            trangThai = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.nhanVien", "nhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.khachHang", "khachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("SDT_KH");

                    b.Navigation("khachHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.hoaDon", "hoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.sanPhamChiTiet", "sanPham")
                        .WithMany("hoaDonChiTiet")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.chucVu", "chucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.hangSX", "hangSX")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IDHangSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.mauSac", "mauSac")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IDMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.size", "size")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IDSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.sanPham1", "sanPham1")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IDsanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hangSX");

                    b.Navigation("mauSac");

                    b.Navigation("sanPham1");

                    b.Navigation("size");
                });

            modelBuilder.Entity("_1.DAL.Models.chucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.Models.hangSX", b =>
                {
                    b.Navigation("SanphamChitietss");
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.Models.khachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.Models.mauSac", b =>
                {
                    b.Navigation("SanphamChitietss");
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.Models.sanPham1", b =>
                {
                    b.Navigation("SanphamChitietss");
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.Navigation("hoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.size", b =>
                {
                    b.Navigation("SanphamChitietss");
                });
#pragma warning restore 612, 618
        }
    }
}
