﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221115072611_duan")]
    partial class duan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.chatLieu", b =>
                {
                    b.Property<Guid>("IdChatLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenCL")
                        .IsRequired()
                        .HasColumnName("tenCL")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("trangThai")
                        .HasColumnName("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdChatLieu");

                    b.ToTable("chatLieu");
                });

            modelBuilder.Entity("_1.DAL.Models.chucVu", b =>
                {
                    b.Property<Guid>("IDchucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenCV")
                        .IsRequired()
                        .HasColumnName("tenCV")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IDchucVu");

                    b.ToTable("chucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.hangSX", b =>
                {
                    b.Property<Guid>("IdHangSX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenHangSX")
                        .IsRequired()
                        .HasColumnName("tenHangSX")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("trangThai")
                        .HasColumnName("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdHangSX");

                    b.ToTable("hangSX");
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.Property<Guid>("IdHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ngayBan")
                        .HasColumnName("ngayBan")
                        .HasColumnType("date");

                    b.Property<DateTime>("ngayTT")
                        .HasColumnName("ngayTT")
                        .HasColumnType("date");

                    b.Property<bool>("trangThai")
                        .HasColumnName("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("IdHD");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNV");

                    b.ToTable("hoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhamChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Soluong")
                        .HasColumnName("Soluong")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnName("trangThai")
                        .HasColumnType("bit");

                    b.Property<int>("donGia")
                        .HasColumnName("donGia")
                        .HasColumnType("int");

                    b.HasKey("IdHD", "IdPhamChiTiet");

                    b.HasIndex("IdPhamChiTiet");

                    b.ToTable("hoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.khachHang", b =>
                {
                    b.Property<Guid>("IdKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDT_KH")
                        .IsRequired()
                        .HasColumnName("SDT_KH")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnName("TenKH")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnName("diaChi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnName("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<bool>("trangThai")
                        .HasColumnName("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdKhachHang");

                    b.ToTable("khachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.mauSac", b =>
                {
                    b.Property<Guid>("IdMauSac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenMau")
                        .IsRequired()
                        .HasColumnName("tenMau")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("trangThai")
                        .HasColumnName("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdMauSac");

                    b.ToTable("mauSac");
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.Property<Guid>("IdNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDchucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnName("SDT")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnName("TenNV")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnName("matKhau")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("tinhTrang")
                        .HasColumnName("tinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("IdNV");

                    b.HasIndex("IDchucVu");

                    b.ToTable("nhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.sanPham", b =>
                {
                    b.Property<Guid>("IdSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnName("TenSP")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("trangThai")
                        .HasColumnName("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("IdSP");

                    b.ToTable("Sanpham");
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.Property<Guid>("IdPhamChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Giaban")
                        .HasColumnType("int");

                    b.Property<int>("Gianhap")
                        .HasColumnType("int");

                    b.Property<Guid>("IdChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHangSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("IdPhamChiTiet");

                    b.HasIndex("IdChatLieu");

                    b.HasIndex("IdHangSX");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdSP");

                    b.HasIndex("IdSize");

                    b.ToTable("sanPhamChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.size", b =>
                {
                    b.Property<Guid>("IdSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SiZe")
                        .IsRequired()
                        .HasColumnName("SiZe")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("trangThai")
                        .HasColumnName("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdSize");

                    b.ToTable("size");
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.khachHang", "khachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.nhanVien", "nhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_1.DAL.Models.hoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.hoaDon", "hoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.sanPhamChiTiet", "sanPhamChiTiet")
                        .WithMany("hoaDonChiTiet")
                        .HasForeignKey("IdPhamChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_1.DAL.Models.nhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.chucVu", "chucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDchucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_1.DAL.Models.sanPhamChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.chatLieu", "chatLieu")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IdChatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.hangSX", "hangSX")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IdHangSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.mauSac", "mauSac")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.sanPham", "sanPham")
                        .WithMany("sanPhamChiTiets")
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.size", "size")
                        .WithMany("SanphamChitietss")
                        .HasForeignKey("IdSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
