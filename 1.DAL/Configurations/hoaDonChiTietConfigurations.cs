using _1.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class hoaDonChiTietConfigurations : IEntityTypeConfiguration<hoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<hoaDonChiTiet> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hoaDonChiTiet");
            // Set khóa chính
            builder.HasKey(x => new { x.maHoaDon, x.maSanPhamChiTiet });
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.Soluong).HasColumnName("Soluong")
                .IsRequired().HasColumnType("int");
            builder.Property(x => x.donGia).HasColumnName("donGia")
                .IsRequired().HasColumnType("int");
            builder.Property(x => x.Trangthai).HasColumnName("trangThai")
                .IsRequired().HasColumnType("bit");
            builder.HasOne(x => x.sanPhamChiTiet)
                .WithMany(x => x.hoaDonChiTiet).HasForeignKey(x => x.maSanPhamChiTiet);
            builder.HasOne(x => x.hoaDon)
                .WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.maHoaDon);
        }
    }
}
