using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class duan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 1,
                column: "tenLoaiHang",
                value: "Cổ tròn");

            migrationBuilder.UpdateData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 2,
                column: "tenLoaiHang",
                value: "Cổ tim");

            migrationBuilder.UpdateData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 3,
                column: "tenLoaiHang",
                value: "Oversize");

            migrationBuilder.InsertData(
                table: "sanPham",
                columns: new[] { "IDsanPham", "tenLoaiHang", "trangThai" },
                values: new object[,]
                {
                    { 4, "Ba lỗ", true },
                    { 5, "Cổ chữ V", true },
                    { 6, "Polo", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 1,
                column: "tenLoaiHang",
                value: "Áo ba lỗ");

            migrationBuilder.UpdateData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 2,
                column: "tenLoaiHang",
                value: "Áo Phông");

            migrationBuilder.UpdateData(
                table: "sanPham",
                keyColumn: "IDsanPham",
                keyValue: 3,
                column: "tenLoaiHang",
                value: "Áo Phông 2");
        }
    }
}
