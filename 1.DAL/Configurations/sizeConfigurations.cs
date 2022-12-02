using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _1.DAL.Configurations
{
    public class sizeConfigurations : IEntityTypeConfiguration<size>
    {
        public void Configure(EntityTypeBuilder<size> builder)
        {
            // Đặt tên bảng
            builder.ToTable("size");
            // Set khóa chính
            builder.HasKey(x => x.maSize);
            builder.Property(x => x.maSize).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.SiZe).HasColumnName("SiZe")
                .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.trangThai).HasColumnName("trangThai")
                .IsRequired().HasColumnType("bit");
        }
    }
}
