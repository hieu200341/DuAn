using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chatLieu",
                columns: table => new
                {
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenCL = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatLieu", x => x.IdChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "chucVu",
                columns: table => new
                {
                    IDchucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenCV = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVu", x => x.IDchucVu);
                });

            migrationBuilder.CreateTable(
                name: "hangSX",
                columns: table => new
                {
                    IdHangSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenHangSX = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSX", x => x.IdHangSX);
                });

            migrationBuilder.CreateTable(
                name: "khachHang",
                columns: table => new
                {
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHang", x => x.IdKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "mauSac",
                columns: table => new
                {
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenMau = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSac", x => x.IdMauSac);
                });

            migrationBuilder.CreateTable(
                name: "Sanpham",
                columns: table => new
                {
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanpham", x => x.IdSP);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiZe = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.IdSize);
                });

            migrationBuilder.CreateTable(
                name: "nhanVien",
                columns: table => new
                {
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDchucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanVien", x => x.IdNV);
                    table.ForeignKey(
                        name: "FK_nhanVien_chucVu_IDchucVu",
                        column: x => x.IDchucVu,
                        principalTable: "chucVu",
                        principalColumn: "IDchucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTiet",
                columns: table => new
                {
                    IdPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gianhap = table.Column<int>(type: "int", nullable: false),
                    Giaban = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTiet", x => x.IdPhamChiTiet);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_chatLieu_IdChatLieu",
                        column: x => x.IdChatLieu,
                        principalTable: "chatLieu",
                        principalColumn: "IdChatLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_hangSX_IdHangSX",
                        column: x => x.IdHangSX,
                        principalTable: "hangSX",
                        principalColumn: "IdHangSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_mauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "mauSac",
                        principalColumn: "IdMauSac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_Sanpham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "Sanpham",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "size",
                        principalColumn: "IdSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDon",
                columns: table => new
                {
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ngayBan = table.Column<DateTime>(type: "date", nullable: false),
                    ngayTT = table.Column<DateTime>(type: "date", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDon", x => x.IdHD);
                    table.ForeignKey(
                        name: "FK_hoaDon_khachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "khachHang",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDon_nhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "nhanVien",
                        principalColumn: "IdNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiet",
                columns: table => new
                {
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<int>(type: "int", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiet", x => new { x.IdHD, x.IdPhamChiTiet });
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_hoaDon_IdHD",
                        column: x => x.IdHD,
                        principalTable: "hoaDon",
                        principalColumn: "IdHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_sanPhamChiTiet_IdPhamChiTiet",
                        column: x => x.IdPhamChiTiet,
                        principalTable: "sanPhamChiTiet",
                        principalColumn: "IdPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_IdKhachHang",
                table: "hoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_IdNV",
                table: "hoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiet_IdPhamChiTiet",
                table: "hoaDonChiTiet",
                column: "IdPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_IDchucVu",
                table: "nhanVien",
                column: "IDchucVu");

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
