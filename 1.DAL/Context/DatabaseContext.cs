using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<chucVu> chucVus { get; set; }
        public DbSet<hangSX> hangSXes { get; set; }
        public DbSet<hoaDon> hoaDons { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<hoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<mauSac> mauSacs { get; set; }
        public DbSet<nhanVien> nhanViens { get; set; }
        public DbSet<khachHang> khachHangs { get; set; }
        public DbSet<size> Sizes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.

                //; User ID = daonvph18705; Password = 123
                UseSqlServer("Data Source=DESKTOP-733UBE0\\SQLEXPRESS;Initial Catalog=DuA;Integrated Security=True"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
