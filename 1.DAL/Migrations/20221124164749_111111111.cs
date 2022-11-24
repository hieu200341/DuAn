using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _111111111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sanPham_chatLieu_maChatLieu",
                table: "sanPham");

            migrationBuilder.DropTable(
                name: "chatLieu");

            migrationBuilder.DropIndex(
                name: "IX_sanPham_maChatLieu",
                table: "sanPham");

            migrationBuilder.AlterColumn<string>(
                name: "maChatLieu",
                table: "sanPham",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "maChatLieu",
                table: "sanPham",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_sanPham_maChatLieu",
                table: "sanPham",
                column: "maChatLieu");

            migrationBuilder.AddForeignKey(
                name: "FK_sanPham_chatLieu_maChatLieu",
                table: "sanPham",
                column: "maChatLieu",
                principalTable: "chatLieu",
                principalColumn: "maChatLieu",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
