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
    public class sanPhamConfigurations : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("sanPham");
            builder.Property(x => x.IdSanPham).IsRequired();
            builder.HasKey(c => c.maSanPham);
            builder.Property(c => c.TenSP).IsRequired();
            builder.Property(c => c.Gianhap).HasColumnType("int").
                IsRequired();
            builder.Property(c => c.Giaban).HasColumnType("int").
                IsRequired();
            builder.Property(c => c.Soluong).HasColumnType("int").
                IsRequired();
            builder.Property(c => c.Trangthai).HasColumnType("bit").
                IsRequired();
            builder.HasOne(x => x.size)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.maSize);
            builder.HasOne(x => x.mauSac)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.maMauSac);
            builder.HasOne(x => x.chatLieu)
          .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.maChatLieu);
            builder.HasOne(x => x.hangSX)
          .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.maHangSX);
        }
    }
}
