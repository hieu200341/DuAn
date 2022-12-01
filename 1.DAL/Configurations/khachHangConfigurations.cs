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
            builder.Property(x => x.TenKH).IsRequired();
            builder.Property(x => x.diaChi).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
            builder.Property(x => x.gioiTinh).IsRequired();
        }
    }
}
