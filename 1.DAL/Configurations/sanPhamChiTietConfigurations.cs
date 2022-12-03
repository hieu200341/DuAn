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
            builder.HasKey(c => c.IDSanPhamChiTiet);
            builder.Property(x => x.IDSanPhamChiTiet).UseIdentityColumn(1, 1);
            builder.Property(c => c.maSP).IsRequired();
            builder.Property(c => c.TenSP).IsRequired();
            builder.Property(c => c.Gianhap).IsRequired();
            builder.Property(c => c.Giaban).IsRequired();
            builder.Property(c => c.Soluong).IsRequired();
            builder.Property(c => c.Trangthai).IsRequired();
            builder.Property(c => c.linkAnh).IsRequired();
            builder.HasOne(x => x.size)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDSize);
            builder.HasOne(x => x.sanPham1)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDsanPham);
            builder.HasOne(x => x.mauSac)
           .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDMauSac);
            builder.HasOne(x => x.hangSX)
          .WithMany(g => g.SanphamChitietss).HasForeignKey(p => p.IDHangSX);
        }
    }
}
