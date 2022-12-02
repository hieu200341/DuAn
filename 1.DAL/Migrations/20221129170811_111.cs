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
                name: "chucVu",
                columns: table => new
                {
                    maChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    maHangSX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
<<<<<<<< HEAD:1.DAL/Migrations/20221202185526_1111.cs
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false),
                    diem = table.Column<int>(type: "int", nullable: false)
========
                    diaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
>>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3:1.DAL/Migrations/20221129170811_111.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHang", x => x.SDT_KH);
                });

            migrationBuilder.CreateTable(
                name: "mauSac",
                columns: table => new
                {
                    maMauSac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenMau = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSac", x => x.maMauSac);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    maSize = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    maNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maChucVu = table.Column<int>(type: "int", nullable: false),
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
                name: "sanPham",
                columns: table => new
                {
                    maSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maMauSac = table.Column<int>(type: "int", nullable: false),
                    maSize = table.Column<int>(type: "int", nullable: false),
                    maHangSX = table.Column<int>(type: "int", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<<< HEAD:1.DAL/Migrations/20221202185526_1111.cs
                    maSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gianhap = table.Column<float>(type: "real", nullable: false),
                    Giaban = table.Column<float>(type: "real", nullable: false),
========
                    Gianhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Giaban = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
>>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3:1.DAL/Migrations/20221129170811_111.cs
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    linkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham", x => x.maSanPham);
                    table.ForeignKey(
                        name: "FK_sanPham_hangSX_maHangSX",
                        column: x => x.maHangSX,
                        principalTable: "hangSX",
                        principalColumn: "maHangSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPham_mauSac_maMauSac",
                        column: x => x.maMauSac,
                        principalTable: "mauSac",
                        principalColumn: "maMauSac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPham_size_maSize",
                        column: x => x.maSize,
                        principalTable: "size",
                        principalColumn: "maSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDon",
                columns: table => new
                {
                    maHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<<< HEAD:1.DAL/Migrations/20221202185526_1111.cs
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    tongTien = table.Column<float>(type: "real", nullable: false),
                    ngayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
========
                    maNhanVien = table.Column<int>(type: "int", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayBan = table.Column<DateTime>(type: "date", nullable: false),
                    ngayTT = table.Column<DateTime>(type: "date", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
>>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3:1.DAL/Migrations/20221129170811_111.cs
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
                    maHoaDon = table.Column<int>(type: "int", nullable: false),
                    maSanPham = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
<<<<<<<< HEAD:1.DAL/Migrations/20221202185526_1111.cs
                    donGia = table.Column<float>(type: "real", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
========
                    donGia = table.Column<int>(type: "int", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
>>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3:1.DAL/Migrations/20221129170811_111.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiet", x => new { x.maHoaDon, x.maSanPham });
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_hoaDon_maHoaDon",
                        column: x => x.maHoaDon,
                        principalTable: "hoaDon",
                        principalColumn: "maHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_sanPham_maSanPham",
                        column: x => x.maSanPham,
                        principalTable: "sanPham",
                        principalColumn: "maSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "chucVu",
                columns: new[] { "maChucVu", "tenCV" },
                values: new object[,]
                {
                    { 1, "Quản lý" },
                    { 2, "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "hangSX",
                columns: new[] { "maHangSX", "tenHangSX", "trangThai" },
                values: new object[,]
                {
                    { 1, "Sao Vàng", true },
                    { 2, "Sahara", true },
                    { 3, "Tỷ Xuân", true }
                });

            migrationBuilder.InsertData(
                table: "khachHang",
                columns: new[] { "SDT_KH", "TenKH", "diaChi", "diem", "gioiTinh", "trangThai" },
                values: new object[,]
                {
                    { "0123456567", "Nguyễn Văn B", "Hải Phòng", 10000, false, true },
                    { "0123456678", "Nguyễn Văn C", "Lạng Sơn", 10000, true, true },
                    { "0123456789", "Nguyễn Văn A", "Hà Nội", 10000, true, true }
                });

            migrationBuilder.InsertData(
                table: "mauSac",
                columns: new[] { "maMauSac", "tenMau", "trangThai" },
                values: new object[,]
                {
                    { 1, "Xanh", true },
                    { 2, "Đỏ", true },
                    { 3, "Trắng", true }
                });

            migrationBuilder.InsertData(
                table: "size",
                columns: new[] { "maSize", "SiZe", "trangThai" },
                values: new object[,]
                {
                    { 1, "M", true },
                    { 2, "L", true },
                    { 3, "XL", true }
                });

            migrationBuilder.InsertData(
                table: "nhanVien",
                columns: new[] { "maNhanVien", "SDT", "TenNV", "diaChi", "email", "maChucVu", "matKhau", "tinhTrang" },
                values: new object[,]
                {
                    { 1, "0379702133", "Nguyễn Văn Đạo", "Tuyên Quang", "daonvph18705@gmail.com", 1, "123", true },
                    { 2, "0379702144", "Nguyễn Văn B", "Hà Nội", "baaa@gmail.com", 2, "123", true }
                });

            migrationBuilder.InsertData(
                table: "sanPham",
                columns: new[] { "maSanPham", "Giaban", "Gianhap", "Soluong", "TenSP", "Trangthai", "linkAnh", "maHangSX", "maMauSac", "maSize" },
                values: new object[,]
                {
<<<<<<<< HEAD:1.DAL/Migrations/20221202185526_1111.cs
                    { 1, 1500f, 1000f, 1, 1, 1, 1000, "Lacoste", true, "", "SP01" },
                    { 2, 2000f, 1500f, 2, 2, 2, 1200, "Gucci", true, "", "SP02" },
                    { 3, 1700f, 1200f, 3, 3, 3, 1300, "ADLV", true, "", "SP03" },
                    { 4, 2100f, 1600f, 2, 3, 1, 1400, "Uniqlo", true, "", "SP04" }
========
                    { 1, 1500m, 1000m, 1000, "Lacoste", true, "", 1, 1, 1 },
                    { 2, 2000m, 1500m, 1200, "Gucci", true, "", 2, 2, 2 },
                    { 3, 1700m, 1200m, 1300, "ADLV", true, "", 3, 3, 3 },
                    { 4, 2100m, 1600m, 1400, "Uniqlo", true, "", 2, 3, 1 }
>>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3:1.DAL/Migrations/20221129170811_111.cs
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
                name: "IX_hoaDonChiTiet_maSanPham",
                table: "hoaDonChiTiet",
                column: "maSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_maChucVu",
                table: "nhanVien",
                column: "maChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPham_maHangSX",
                table: "sanPham",
                column: "maHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_sanPham_maMauSac",
                table: "sanPham",
                column: "maMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_sanPham_maSize",
                table: "sanPham",
                column: "maSize");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "hoaDon");

            migrationBuilder.DropTable(
                name: "sanPham");

            migrationBuilder.DropTable(
                name: "khachHang");

            migrationBuilder.DropTable(
                name: "nhanVien");

            migrationBuilder.DropTable(
                name: "hangSX");

            migrationBuilder.DropTable(
                name: "mauSac");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "chucVu");
        }
    }
}
