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
    public class sanPhamChiTietConfigurations : IEntityTypeConfiguration<sanPhamChiTiet>
    {
        public void Configure(EntityTypeBuilder<sanPhamChiTiet> builder)
        {
            builder.ToTable("sanPhamChiTiet");
            builder.HasKey(c => c.IdPhamChiTiet);
            builder.Property(c => c.Gianhap).HasColumnType("int").
                IsRequired();
            builder.Property(c => c.Giaban).HasColumnType("int").
                IsRequired();
            builder.Property(c => c.Soluong).HasColumnType("int").
                IsRequired();
            builder.Property(c => c.Trangthai).HasColumnType("bit").
                IsRequired();
            builder.HasOne(x => x.sanPham)
            .WithMany(g => g.sanPhamChiTiets).HasForeignKey(p => p.IdSP);
            builder.HasOne(x => x.size)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IdSize);
            builder.HasOne(x => x.mauSac)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IdMauSac);
            builder.HasOne(x => x.chatLieu)
          .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IdChatLieu);
            builder.HasOne(x => x.hangSX)
          .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IdHangSX);
        }
    }
}
