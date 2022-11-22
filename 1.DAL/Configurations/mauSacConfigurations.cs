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
    public class mauSacConfigurations : IEntityTypeConfiguration<mauSac>
    {
        public void Configure(EntityTypeBuilder<mauSac> builder)
        {
            // Đặt tên bảng
            builder.ToTable("mauSac");
            builder.Property(x => x.IdMauSac).IsRequired();
            // Set khóa chính
            builder.HasKey(x => x.maMauSac);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenMau).HasColumnName("tenMau")
                .IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.trangThai).HasColumnName("trangThai")
                .IsRequired().HasColumnType("bit");
        }
    }
}
