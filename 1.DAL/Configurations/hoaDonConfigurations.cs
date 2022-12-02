﻿using _1.DAL.Models;
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
            // Set khóa chính
            builder.HasKey(x => x.maHoaDon);
            builder.Property(x => x.maHoaDon).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
<<<<<<< HEAD
            builder.Property(x => x.ngayBan).IsRequired();
            builder.Property(x => x.tongTien).IsRequired();
            builder.Property(x => x.ghiChu).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
=======
            builder.Property(x => x.ngayBan).HasColumnName("ngayBan")
                .IsRequired().HasColumnType("date");
            builder.Property(x => x.ngayTT).HasColumnName("ngayTT")
                .IsRequired().HasColumnType("date");
            builder.Property(x => x.trangThai).HasColumnName("Trangthai")
               .IsRequired().HasColumnType("bit");
>>>>>>> 1710443d32302164027f53c3117c1f3cc70e67a3
            builder.HasOne(x => x.khachHang)
        .WithMany(g => g.HoaDons).HasForeignKey(p => p.SDT_KH);
            builder.HasOne(x => x.nhanVien)
        .WithMany(g => g.HoaDons).HasForeignKey(p => p.maNhanVien);
        }
    }
}
