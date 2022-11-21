using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDon_khachHang_IdKhachHang",
                table: "hoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDon_nhanVien_IdNV",
                table: "hoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiet_hoaDon_IdHD",
                table: "hoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiet_sanPhamChiTiet_IdPhamChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_nhanVien_chucVu_IDchucVu",
                table: "nhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_chatLieu_IdChatLieu",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_hangSX_IdHangSX",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_mauSac_IdMauSac",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_Sanpham_IdSP",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_size_IdSize",
                table: "sanPhamChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_size",
                table: "size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sanPhamChiTiet",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_IdChatLieu",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_IdHangSX",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_IdMauSac",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_IdSize",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_IdSP",
                table: "sanPhamChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sanpham",
                table: "Sanpham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nhanVien",
                table: "nhanVien");

            migrationBuilder.DropIndex(
                name: "IX_nhanVien_IDchucVu",
                table: "nhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mauSac",
                table: "mauSac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_khachHang",
                table: "khachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_hoaDonChiTiet_IdPhamChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDon",
                table: "hoaDon");

            migrationBuilder.DropIndex(
                name: "IX_hoaDon_IdKhachHang",
                table: "hoaDon");

            migrationBuilder.DropIndex(
                name: "IX_hoaDon_IdNV",
                table: "hoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hangSX",
                table: "hangSX");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chucVu",
                table: "chucVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chatLieu",
                table: "chatLieu");

            migrationBuilder.DropColumn(
                name: "IdPhamChiTiet",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "IdChatLieu",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "IdHangSX",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "IdMauSac",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "IdSP",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "IDchucVu",
                table: "nhanVien");

            migrationBuilder.DropColumn(
                name: "IdHD",
                table: "hoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IdPhamChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IdKhachHang",
                table: "hoaDon");

            migrationBuilder.DropColumn(
                name: "IdNV",
                table: "hoaDon");

            migrationBuilder.RenameColumn(
                name: "IdSize",
                table: "sanPhamChiTiet",
                newName: "IdSanPhamChiTiet");

            migrationBuilder.AddColumn<string>(
                name: "maSize",
                table: "size",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maSanPhamChiTiet",
                table: "sanPhamChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maChatLieu",
                table: "sanPhamChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maHangSX",
                table: "sanPhamChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maMauSac",
                table: "sanPhamChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maSanPham",
                table: "sanPhamChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maSize",
                table: "sanPhamChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maSanPham",
                table: "Sanpham",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maNhanVien",
                table: "nhanVien",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maChucVu",
                table: "nhanVien",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maMauSac",
                table: "mauSac",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maHoaDon",
                table: "hoaDonChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maSanPhamChiTiet",
                table: "hoaDonChiTiet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maHD",
                table: "hoaDon",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SDT_KH",
                table: "hoaDon",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maNhanVien",
                table: "hoaDon",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maHangSX",
                table: "hangSX",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maChucVu",
                table: "chucVu",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maChatLieu",
                table: "chatLieu",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_size",
                table: "size",
                column: "maSize");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sanPhamChiTiet",
                table: "sanPhamChiTiet",
                column: "maSanPhamChiTiet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sanpham",
                table: "Sanpham",
                column: "maSanPham");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nhanVien",
                table: "nhanVien",
                column: "maNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mauSac",
                table: "mauSac",
                column: "maMauSac");

            migrationBuilder.AddPrimaryKey(
                name: "PK_khachHang",
                table: "khachHang",
                column: "SDT_KH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonChiTiet",
                table: "hoaDonChiTiet",
                columns: new[] { "maHoaDon", "maSanPhamChiTiet" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDon",
                table: "hoaDon",
                column: "maHD");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hangSX",
                table: "hangSX",
                column: "maHangSX");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chucVu",
                table: "chucVu",
                column: "maChucVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chatLieu",
                table: "chatLieu",
                column: "maChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_maChatLieu",
                table: "sanPhamChiTiet",
                column: "maChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_maHangSX",
                table: "sanPhamChiTiet",
                column: "maHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_maMauSac",
                table: "sanPhamChiTiet",
                column: "maMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_maSanPham",
                table: "sanPhamChiTiet",
                column: "maSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_maSize",
                table: "sanPhamChiTiet",
                column: "maSize");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_maChucVu",
                table: "nhanVien",
                column: "maChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiet_maSanPhamChiTiet",
                table: "hoaDonChiTiet",
                column: "maSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_maNhanVien",
                table: "hoaDon",
                column: "maNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_SDT_KH",
                table: "hoaDon",
                column: "SDT_KH");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDon_khachHang_SDT_KH",
                table: "hoaDon",
                column: "SDT_KH",
                principalTable: "khachHang",
                principalColumn: "SDT_KH",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDon_nhanVien_maNhanVien",
                table: "hoaDon",
                column: "maNhanVien",
                principalTable: "nhanVien",
                principalColumn: "maNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiet_hoaDon_maHoaDon",
                table: "hoaDonChiTiet",
                column: "maHoaDon",
                principalTable: "hoaDon",
                principalColumn: "maHD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiet_sanPhamChiTiet_maSanPhamChiTiet",
                table: "hoaDonChiTiet",
                column: "maSanPhamChiTiet",
                principalTable: "sanPhamChiTiet",
                principalColumn: "maSanPhamChiTiet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nhanVien_chucVu_maChucVu",
                table: "nhanVien",
                column: "maChucVu",
                principalTable: "chucVu",
                principalColumn: "maChucVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_chatLieu_maChatLieu",
                table: "sanPhamChiTiet",
                column: "maChatLieu",
                principalTable: "chatLieu",
                principalColumn: "maChatLieu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_hangSX_maHangSX",
                table: "sanPhamChiTiet",
                column: "maHangSX",
                principalTable: "hangSX",
                principalColumn: "maHangSX",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_mauSac_maMauSac",
                table: "sanPhamChiTiet",
                column: "maMauSac",
                principalTable: "mauSac",
                principalColumn: "maMauSac",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_Sanpham_maSanPham",
                table: "sanPhamChiTiet",
                column: "maSanPham",
                principalTable: "Sanpham",
                principalColumn: "maSanPham",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_size_maSize",
                table: "sanPhamChiTiet",
                column: "maSize",
                principalTable: "size",
                principalColumn: "maSize",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDon_khachHang_SDT_KH",
                table: "hoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDon_nhanVien_maNhanVien",
                table: "hoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiet_hoaDon_maHoaDon",
                table: "hoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiet_sanPhamChiTiet_maSanPhamChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_nhanVien_chucVu_maChucVu",
                table: "nhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_chatLieu_maChatLieu",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_hangSX_maHangSX",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_mauSac_maMauSac",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_Sanpham_maSanPham",
                table: "sanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_sanPhamChiTiet_size_maSize",
                table: "sanPhamChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_size",
                table: "size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sanPhamChiTiet",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_maChatLieu",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_maHangSX",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_maMauSac",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_maSanPham",
                table: "sanPhamChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_sanPhamChiTiet_maSize",
                table: "sanPhamChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sanpham",
                table: "Sanpham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nhanVien",
                table: "nhanVien");

            migrationBuilder.DropIndex(
                name: "IX_nhanVien_maChucVu",
                table: "nhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mauSac",
                table: "mauSac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_khachHang",
                table: "khachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_hoaDonChiTiet_maSanPhamChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDon",
                table: "hoaDon");

            migrationBuilder.DropIndex(
                name: "IX_hoaDon_maNhanVien",
                table: "hoaDon");

            migrationBuilder.DropIndex(
                name: "IX_hoaDon_SDT_KH",
                table: "hoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hangSX",
                table: "hangSX");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chucVu",
                table: "chucVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chatLieu",
                table: "chatLieu");

            migrationBuilder.DropColumn(
                name: "maSize",
                table: "size");

            migrationBuilder.DropColumn(
                name: "maSanPhamChiTiet",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "maChatLieu",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "maHangSX",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "maMauSac",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "maSanPham",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "maSize",
                table: "sanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "maSanPham",
                table: "Sanpham");

            migrationBuilder.DropColumn(
                name: "maNhanVien",
                table: "nhanVien");

            migrationBuilder.DropColumn(
                name: "maChucVu",
                table: "nhanVien");

            migrationBuilder.DropColumn(
                name: "maMauSac",
                table: "mauSac");

            migrationBuilder.DropColumn(
                name: "maHoaDon",
                table: "hoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "maSanPhamChiTiet",
                table: "hoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "maHD",
                table: "hoaDon");

            migrationBuilder.DropColumn(
                name: "SDT_KH",
                table: "hoaDon");

            migrationBuilder.DropColumn(
                name: "maNhanVien",
                table: "hoaDon");

            migrationBuilder.DropColumn(
                name: "maHangSX",
                table: "hangSX");

            migrationBuilder.DropColumn(
                name: "maChucVu",
                table: "chucVu");

            migrationBuilder.DropColumn(
                name: "maChatLieu",
                table: "chatLieu");

            migrationBuilder.RenameColumn(
                name: "IdSanPhamChiTiet",
                table: "sanPhamChiTiet",
                newName: "IdSize");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPhamChiTiet",
                table: "sanPhamChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdChatLieu",
                table: "sanPhamChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdHangSX",
                table: "sanPhamChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdMauSac",
                table: "sanPhamChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdSP",
                table: "sanPhamChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IDchucVu",
                table: "nhanVien",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdHD",
                table: "hoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdPhamChiTiet",
                table: "hoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdKhachHang",
                table: "hoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdNV",
                table: "hoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_size",
                table: "size",
                column: "IdSize");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sanPhamChiTiet",
                table: "sanPhamChiTiet",
                column: "IdPhamChiTiet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sanpham",
                table: "Sanpham",
                column: "IdSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nhanVien",
                table: "nhanVien",
                column: "IdNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mauSac",
                table: "mauSac",
                column: "IdMauSac");

            migrationBuilder.AddPrimaryKey(
                name: "PK_khachHang",
                table: "khachHang",
                column: "IdKhachHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonChiTiet",
                table: "hoaDonChiTiet",
                columns: new[] { "IdHD", "IdPhamChiTiet" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDon",
                table: "hoaDon",
                column: "IdHD");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hangSX",
                table: "hangSX",
                column: "IdHangSX");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chucVu",
                table: "chucVu",
                column: "IDchucVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chatLieu",
                table: "chatLieu",
                column: "IdChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IdChatLieu",
                table: "sanPhamChiTiet",
                column: "IdChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IdHangSX",
                table: "sanPhamChiTiet",
                column: "IdHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IdMauSac",
                table: "sanPhamChiTiet",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IdSize",
                table: "sanPhamChiTiet",
                column: "IdSize");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IdSP",
                table: "sanPhamChiTiet",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_IDchucVu",
                table: "nhanVien",
                column: "IDchucVu");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiet_IdPhamChiTiet",
                table: "hoaDonChiTiet",
                column: "IdPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_IdKhachHang",
                table: "hoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_IdNV",
                table: "hoaDon",
                column: "IdNV");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDon_khachHang_IdKhachHang",
                table: "hoaDon",
                column: "IdKhachHang",
                principalTable: "khachHang",
                principalColumn: "IdKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDon_nhanVien_IdNV",
                table: "hoaDon",
                column: "IdNV",
                principalTable: "nhanVien",
                principalColumn: "IdNV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiet_hoaDon_IdHD",
                table: "hoaDonChiTiet",
                column: "IdHD",
                principalTable: "hoaDon",
                principalColumn: "IdHD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiet_sanPhamChiTiet_IdPhamChiTiet",
                table: "hoaDonChiTiet",
                column: "IdPhamChiTiet",
                principalTable: "sanPhamChiTiet",
                principalColumn: "IdPhamChiTiet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nhanVien_chucVu_IDchucVu",
                table: "nhanVien",
                column: "IDchucVu",
                principalTable: "chucVu",
                principalColumn: "IDchucVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_chatLieu_IdChatLieu",
                table: "sanPhamChiTiet",
                column: "IdChatLieu",
                principalTable: "chatLieu",
                principalColumn: "IdChatLieu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_hangSX_IdHangSX",
                table: "sanPhamChiTiet",
                column: "IdHangSX",
                principalTable: "hangSX",
                principalColumn: "IdHangSX",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_mauSac_IdMauSac",
                table: "sanPhamChiTiet",
                column: "IdMauSac",
                principalTable: "mauSac",
                principalColumn: "IdMauSac",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_Sanpham_IdSP",
                table: "sanPhamChiTiet",
                column: "IdSP",
                principalTable: "Sanpham",
                principalColumn: "IdSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhamChiTiet_size_IdSize",
                table: "sanPhamChiTiet",
                column: "IdSize",
                principalTable: "size",
                principalColumn: "IdSize",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
