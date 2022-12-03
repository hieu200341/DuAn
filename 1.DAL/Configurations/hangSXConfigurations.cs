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
    public class hangSXConfigurations : IEntityTypeConfiguration<hangSX>
    {
        public void Configure(EntityTypeBuilder<hangSX> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hangSX");
            // Set khóa chính
            builder.HasKey(x => x.IDHangSX);
            builder.Property(x => x.IDHangSX).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenHangSX).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
