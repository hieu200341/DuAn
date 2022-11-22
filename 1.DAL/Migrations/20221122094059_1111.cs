using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chatLieu",
                columns: table => new
                {
                    maChatLieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenCL = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatLieu", x => x.maChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "chucVu",
                columns: table => new
                {
                    maChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IDchucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenCV = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVu", x => x.maChucVu);
                });

            migrationBuilder.CreateTable(
                name: "hangSX",
                columns: table => new
                {
                    maHangSX = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdHangSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenHangSX = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSX", x => x.maHangSX);
                });

            migrationBuilder.CreateTable(
                name: "khachHang",
                columns: table => new
                {
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHang", x => x.SDT_KH);
                });

            migrationBuilder.CreateTable(
                name: "mauSac",
                columns: table => new
                {
                    maMauSac = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenMau = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSac", x => x.maMauSac);
                });

            migrationBuilder.CreateTable(
                name: "Sanpham",
                columns: table => new
                {
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanpham", x => x.maSanPham);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    maSize = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiZe = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.maSize);
                });

            migrationBuilder.CreateTable(
                name: "nhanVien",
                columns: table => new
                {
                    maNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanVien", x => x.maNhanVien);
                    table.ForeignKey(
                        name: "FK_nhanVien_chucVu_maChucVu",
                        column: x => x.maChucVu,
                        principalTable: "chucVu",
                        principalColumn: "maChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTiet",
                columns: table => new
                {
                    maSanPhamChiTiet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMauSac = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maChatLieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maSize = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHangSX = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gianhap = table.Column<int>(type: "int", nullable: false),
                    Giaban = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTiet", x => x.maSanPhamChiTiet);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_chatLieu_maChatLieu",
                        column: x => x.maChatLieu,
                        principalTable: "chatLieu",
                        principalColumn: "maChatLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_hangSX_maHangSX",
                        column: x => x.maHangSX,
                        principalTable: "hangSX",
                        principalColumn: "maHangSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_mauSac_maMauSac",
                        column: x => x.maMauSac,
                        principalTable: "mauSac",
                        principalColumn: "maMauSac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_Sanpham_maSanPham",
                        column: x => x.maSanPham,
                        principalTable: "Sanpham",
                        principalColumn: "maSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_size_maSize",
                        column: x => x.maSize,
                        principalTable: "size",
                        principalColumn: "maSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDon",
                columns: table => new
                {
                    maHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayBan = table.Column<DateTime>(type: "date", nullable: false),
                    ngayTT = table.Column<DateTime>(type: "date", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDon", x => x.maHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDon_khachHang_SDT_KH",
                        column: x => x.SDT_KH,
                        principalTable: "khachHang",
                        principalColumn: "SDT_KH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDon_nhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "nhanVien",
                        principalColumn: "maNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiet",
                columns: table => new
                {
                    maHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maSanPhamChiTiet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<int>(type: "int", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiet", x => new { x.maHoaDon, x.maSanPhamChiTiet });
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_hoaDon_maHoaDon",
                        column: x => x.maHoaDon,
                        principalTable: "hoaDon",
                        principalColumn: "maHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_sanPhamChiTiet_maSanPhamChiTiet",
                        column: x => x.maSanPhamChiTiet,
                        principalTable: "sanPhamChiTiet",
                        principalColumn: "maSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_maNhanVien",
                table: "hoaDon",
                column: "maNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_SDT_KH",
                table: "hoaDon",
                column: "SDT_KH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiet_maSanPhamChiTiet",
                table: "hoaDonChiTiet",
                column: "maSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_maChucVu",
                table: "nhanVien",
                column: "maChucVu");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "hoaDon");

            migrationBuilder.DropTable(
                name: "sanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "khachHang");

            migrationBuilder.DropTable(
                name: "nhanVien");

            migrationBuilder.DropTable(
                name: "chatLieu");

            migrationBuilder.DropTable(
                name: "hangSX");

            migrationBuilder.DropTable(
                name: "mauSac");

            migrationBuilder.DropTable(
                name: "Sanpham");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "chucVu");
        }
    }
}
