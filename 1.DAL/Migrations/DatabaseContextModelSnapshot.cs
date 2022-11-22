﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Models.chatLieu", b =>
                {
                    b.Property<string>("maChatLieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenCL")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tenCL");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.HasKey("maChatLieu");

                    b.ToTable("chatLieu", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.chucVu", b =>
                {
                    b.Property<string>("maChucVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IDchucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tenCV");

                    b.HasKey("maChucVu");

                    b.ToTable("chucVu", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.hangSX", b =>
                {
                    b.Property<string>("maHangSX")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdHangSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenHangSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tenHangSX");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.HasKey("maHangSX");

                    b.ToTable("hangSX", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.Property<string>("maHoaDon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDT_KH")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayBan")
                        .HasColumnType("date")
                        .HasColumnName("ngayBan");

                    b.Property<DateTime>("ngayTT")
                        .HasColumnType("date")
                        .HasColumnName("ngayTT");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("Trangthai");

                    b.HasKey("maHoaDon");

                    b.HasIndex("SDT_KH");

                    b.HasIndex("maNhanVien");

                    b.ToTable("hoaDon", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDonChiTiet", b =>
                {
                    b.Property<string>("maHoaDon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maSanPhamChiTiet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int")
                        .HasColumnName("Soluong");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.Property<int>("donGia")
                        .HasColumnType("int")
                        .HasColumnName("donGia");

                    b.HasKey("maHoaDon", "maSanPhamChiTiet");

                    b.HasIndex("maSanPhamChiTiet");

                    b.ToTable("hoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.khachHang", b =>
                {
                    b.Property<string>("SDT_KH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenKH");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("diaChi");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit")
                        .HasColumnName("gioiTinh");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.HasKey("SDT_KH");

                    b.ToTable("khachHang", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.mauSac", b =>
                {
                    b.Property<string>("maMauSac")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tenMau");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.HasKey("maMauSac");

                    b.ToTable("mauSac", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.Property<string>("maNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenNV");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("maChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("matKhau");

                    b.Property<bool>("tinhTrang")
                        .HasColumnType("bit")
                        .HasColumnName("tinhTrang");

                    b.HasKey("maNhanVien");

                    b.HasIndex("maChucVu");

                    b.ToTable("nhanVien", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.sanPham", b =>
                {
                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSP");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("Trangthai");

                    b.HasKey("maSanPham");

                    b.ToTable("Sanpham", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.Property<string>("maSanPhamChiTiet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Giaban")
                        .HasColumnType("int");

                    b.Property<int>("Gianhap")
                        .HasColumnType("int");

                    b.Property<Guid>("IdSanPhamChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.Property<string>("maChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maHangSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("maSanPhamChiTiet");

                    b.HasIndex("maChatLieu");

                    b.HasIndex("maHangSX");

                    b.HasIndex("maMauSac");

                    b.HasIndex("maSanPham");

                    b.HasIndex("maSize");

                    b.ToTable("sanPhamChiTiet", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.size", b =>
                {
                    b.Property<string>("maSize")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SiZe")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SiZe");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.HasKey("maSize");

                    b.ToTable("size", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.khachHang", "khachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("SDT_KH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.nhanVien", "nhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("maNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.hoaDon", "hoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("maHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.sanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("hoaDonChiTiet")
                        .HasForeignKey("maSanPhamChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("sanPhamChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.chucVu", "chucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("maChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.chatLieu", "chatLieu")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("maChatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.hangSX", "hangSX")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("maHangSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.mauSac", "mauSac")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("maMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.sanPham", "sanPham")
                        .WithMany("sanPhamChiTiets")
                        .HasForeignKey("maSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.size", "size")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("maSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chatLieu");

                    b.Navigation("hangSX");

                    b.Navigation("mauSac");

                    b.Navigation("sanPham");

                    b.Navigation("size");
                });

            modelBuilder.Entity("_1.DAL.Models.chatLieu", b =>
                {
                    b.Navigation("SanphamChitietss");
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

            modelBuilder.Entity("_1.DAL.Models.sanPham", b =>
                {
                    b.Navigation("sanPhamChiTiets");
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
