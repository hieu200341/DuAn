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
    public class chucVuConfigurations : IEntityTypeConfiguration<chucVu>
    {
        public void Configure(EntityTypeBuilder<chucVu> builder)
        {
            // Đặt tên bảng
            builder.ToTable("chucVu");
            // Set khóa chính
            builder.HasKey(x => x.maChucVu);
            builder.Property(x => x.maChucVu).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenCV).HasColumnName("tenCV")
                .IsRequired().HasColumnType("nvarchar(100)");
        }
    }
}
