using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst1.Models
{
    public partial class QLSach : DbContext
    {
        public QLSach()
            : base("name=QLSach")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DanhMucSach> DanhMucSaches { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomSach> NhomSaches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.SoLuong)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DanhMucSach>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucSach>()
                .Property(e => e.MaNhom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucSach>()
                .Property(e => e.DonGia)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DanhMucSach>()
                .Property(e => e.SLTon)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DanhMucSach>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.DanhMucSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhomSach>()
                .Property(e => e.MaNhom)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
