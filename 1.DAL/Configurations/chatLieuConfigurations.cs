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
    public class chatLieuConfigurations : IEntityTypeConfiguration<chatLieu>
    {
        public void Configure(EntityTypeBuilder<chatLieu> builder)
        {
            // Đặt tên bảng
            builder.ToTable("chatLieu");
            builder.Property(x => x.IdChatLieu).IsRequired();
            // Set khóa chính
            builder.HasKey(x => x.maChatLieu);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenCL).HasColumnName("tenCL")
                .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.trangThai).HasColumnName("trangThai")
                .IsRequired().HasColumnType("bit");
        }
    }
}
