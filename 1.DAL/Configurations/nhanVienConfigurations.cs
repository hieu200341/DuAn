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
    public class nhanVienConfigurations : IEntityTypeConfiguration<nhanVien>
    {
        public void Configure(EntityTypeBuilder<nhanVien> builder)
        {
            // Đặt tên bảng
            builder.ToTable("nhanVien");
            // Set khóa chính
            builder.HasKey(x => x.maNhanVien);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.TenNV).HasColumnName("TenNV")
                .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.SDT).HasColumnName("SDT")
               .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.email).HasColumnName("email")
               .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.matKhau).HasColumnName("matKhau")
              .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.tinhTrang).HasColumnName("tinhTrang")
                .IsRequired().HasColumnType("bit");
            builder.HasOne(x => x.chucVu)
          .WithMany(g => g.NhanViens).HasForeignKey(p => p.maChucVu);
        }
    }
}
