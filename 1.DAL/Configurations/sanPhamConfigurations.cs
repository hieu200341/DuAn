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
            builder.HasKey(c => c.IDSanPham);
            builder.Property(x => x.IDSanPham).UseIdentityColumn(1, 1);
            builder.Property(c => c.maSP).IsRequired();
            builder.Property(c => c.TenSP).IsRequired();
            builder.Property(c => c.Gianhap).IsRequired();
            builder.Property(c => c.Giaban).IsRequired();
            builder.Property(c => c.Soluong).IsRequired();
            builder.Property(c => c.Trangthai).IsRequired();
            builder.Property(c => c.linkAnh).IsRequired();
            builder.HasOne(x => x.size)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDSize);
            builder.HasOne(x => x.mauSac)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDMauSac);
            builder.HasOne(x => x.hangSX)
          .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDHangSX);
        }
    }
}
