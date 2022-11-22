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
    public class sanPhamConfigurations : IEntityTypeConfiguration<sanPham>
    {
        public void Configure(EntityTypeBuilder<sanPham> builder)
        {
            // Đặt tên bảng
            builder.ToTable("Sanpham");
            builder.Property(x => x.IdSP).IsRequired();
            // Set khóa chính
            builder.HasKey(x => x.maSanPham);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.TenSP).HasColumnName("TenSP")
                .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.trangThai).HasColumnName("Trangthai")
                .IsRequired().HasColumnType("bit");
        }
    }
}
