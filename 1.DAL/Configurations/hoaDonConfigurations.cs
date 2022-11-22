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
    public class hoaDonConfigurations : IEntityTypeConfiguration<hoaDon>
    {
        public void Configure(EntityTypeBuilder<hoaDon> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hoaDon");
            builder.Property(x => x.IdHD).IsRequired();
            // Set khóa chính
            builder.HasKey(x => x.maHoaDon);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.ngayBan).HasColumnName("ngayBan")
                .IsRequired().HasColumnType("date");
            builder.Property(x => x.ngayTT).HasColumnName("ngayTT")
                .IsRequired().HasColumnType("date");
            builder.Property(x => x.trangThai).HasColumnName("Trangthai")
               .IsRequired().HasColumnType("bit");
            builder.HasOne(x => x.khachHang)
        .WithMany(g => g.HoaDons).HasForeignKey(p => p.SDT_KH);
            builder.HasOne(x => x.nhanVien)
        .WithMany(g => g.HoaDons).HasForeignKey(p => p.maNhanVien);
        }
    }
}
