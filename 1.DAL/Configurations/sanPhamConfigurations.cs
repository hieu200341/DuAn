using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class sanPhamConfigurations : IEntityTypeConfiguration<sanPham1>
    {
        public void Configure(EntityTypeBuilder<sanPham1> builder)
        {
            // Đặt tên bảng
            builder.ToTable("sanPham");
            // Set khóa chính
            builder.HasKey(x => x.IDsanPham);
            builder.Property(x => x.IDsanPham).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenLoaiHang).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
