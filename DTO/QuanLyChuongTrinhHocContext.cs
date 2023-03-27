using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DTO
{
    public partial class QuanLyChuongTrinhHocContext : DbContext
    {
        public QuanLyChuongTrinhHocContext()
            : base("name=QuanLyChuongTrinhHocContext")
        {
        }

        public virtual DbSet<ChuongTrinh> ChuongTrinhs { get; set; }
        public virtual DbSet<ChuongTrinhMonHoc> ChuongTrinhMonHocs { get; set; }
        public virtual DbSet<DamNhiemMon> DamNhiemMons { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<KhoaHocMon> KhoaHocMons { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuongTrinh>()
                .Property(e => e.MaBacHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChuongTrinh>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<ChuongTrinh>()
                .Property(e => e.MaGiaoVien_GiamDocCT)
                .IsUnicode(false);

            modelBuilder.Entity<ChuongTrinh>()
                .HasMany(e => e.ChuongTrinhMonHocs)
                .WithRequired(e => e.ChuongTrinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuongTrinh>()
                .HasMany(e => e.DamNhiemMons)
                .WithRequired(e => e.ChuongTrinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuongTrinh>()
                .HasMany(e => e.KhoaHocs)
                .WithRequired(e => e.ChuongTrinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DamNhiemMon>()
                .Property(e => e.MaGiaoVien)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.MaGiaoVien)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.ChuongTrinhs)
                .WithRequired(e => e.GiaoVien)
                .HasForeignKey(e => e.MaGiaoVien_GiamDocCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.DamNhiemMons)
                .WithRequired(e => e.GiaoVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.KhoaHocMons)
                .WithRequired(e => e.GiaoVien)
                .HasForeignKey(e => e.MaGiaoVien_day)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.ChuongTrinhs)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.GiaoViens)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoaHoc>()
                .HasMany(e => e.KhoaHocMons)
                .WithRequired(e => e.KhoaHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoaHocMon>()
                .Property(e => e.MaGiaoVien_day)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaHocMon>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaHocMon>()
                .Property(e => e.MaThu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.ChuongTrinhMonHocs)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.DamNhiemMons)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.KhoaHocMons)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
