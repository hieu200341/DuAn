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
    public class khachHangConfigurations : IEntityTypeConfiguration<khachHang>
    {
        public void Configure(EntityTypeBuilder<khachHang> builder)
        {
            // Đặt tên bảng
            builder.ToTable("khachHang");
            // Set khóa chính
            builder.HasKey(x => x.SDT_KH);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.TenKH).HasColumnName("TenKH")
               .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.diaChi).HasColumnName("diaChi")
               .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.trangThai).HasColumnName("trangThai")
              .IsRequired().HasColumnType("bit");
            builder.Property(x => x.gioiTinh).HasColumnName("gioiTinh")
                .IsRequired().HasColumnType("bit");
        }
    }
}
