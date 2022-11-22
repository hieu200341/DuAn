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
    public class hangSXConfigurations : IEntityTypeConfiguration<hangSX>
    {
        public void Configure(EntityTypeBuilder<hangSX> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hangSX");
            builder.Property(x => x.IdHangSX).IsRequired();
            // Set khóa chính
            builder.HasKey(x => x.maHangSX);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenHangSX).HasColumnName("tenHangSX")
                .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.trangThai).HasColumnName("trangThai")
                .IsRequired().HasColumnType("bit");
        }
    }
}
