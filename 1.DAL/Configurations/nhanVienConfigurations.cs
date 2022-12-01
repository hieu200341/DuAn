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
            builder.HasKey(x => x.IDNhanVien);
            builder.Property(x => x.IDNhanVien).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.TenNV).IsRequired();
            builder.Property(x => x.SDT).IsRequired();
            builder.Property(x => x.email).IsRequired();
            builder.Property(x => x.matKhau).IsRequired();
            builder.Property(x => x.tinhTrang).IsRequired();
            builder.HasOne(x => x.chucVu)
          .WithMany(g => g.NhanViens).HasForeignKey(p => p.IDChucVu);
        }
    }
}
