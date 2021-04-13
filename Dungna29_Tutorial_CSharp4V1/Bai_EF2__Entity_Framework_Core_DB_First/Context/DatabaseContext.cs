using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bai_EF2__Entity_Framework_Core_DB_First.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<CuaHang> CuaHang { get; set; }
        public virtual DbSet<DongSanPham> DongSanPham { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhieuBaoHanh> PhieuBaoHanh { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieu { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DUNGNAPC\\SQLEXPRESS;Initial Catalog=Dungna_FPTShopV2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.MaChucVu).IsUnicode(false);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaCh).IsUnicode(false);
            });

            modelBuilder.Entity<DongSanPham>(entity =>
            {
                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaDsp).IsUnicode(false);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.IdkhachHang).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnhanVien).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaHd).IsUnicode(false);

                entity.HasOne(d => d.IdkhachHangNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdkhachHang)
                    .HasConstraintName("FK_HoaDonKhachHang");

                entity.HasOne(d => d.IdnhanVienNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdnhanVien)
                    .HasConstraintName("FK_HoaDonNhanVIen");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdhoaDon, e.IdsanPham })
                    .HasName("PK__HoaDonCh__E25D31118CDCB5D7");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiet)
                    .HasForeignKey(d => d.IdhoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.HoaDonChiTiet)
                    .HasForeignKey(d => d.IdsanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasIndex(e => e.MaKh)
                    .HasName("UQ__KhachHan__2725CF1F518DBD6A")
                    .IsUnique();

                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaCty).IsUnicode(false);

                entity.Property(e => e.Mst).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.IdchucVu).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdcuaHang).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.LuongNv).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaNv).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.HasOne(d => d.IdchucVuNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdchucVu)
                    .HasConstraintName("FK_NhanVienChucVU");

                entity.HasOne(d => d.IdcuaHangNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdcuaHang)
                    .HasConstraintName("FK_NhanVienCuaHang");
            });

            modelBuilder.Entity<PhieuBaoHanh>(entity =>
            {
                entity.Property(e => e.IdhoaDon).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdsanPham).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Imei).IsUnicode(false);

                entity.Property(e => e.MaPhieu).IsUnicode(false);

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.PhieuBaoHanh)
                    .HasForeignKey(d => d.IdhoaDon)
                    .HasConstraintName("FK_BaoHanhHoaDon");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.PhieuBaoHanh)
                    .HasForeignKey(d => d.IdsanPham)
                    .HasConstraintName("FK_BaoHanhSanPham");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasIndex(e => e.MaSp)
                    .HasName("UQ__SanPham__2725081D2BFA8849")
                    .IsUnique();

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.IddongSp).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdthuongHieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaSp).IsUnicode(false);

                entity.Property(e => e.ManHinh).IsUnicode(false);

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TenSp).IsUnicode(false);

                entity.Property(e => e.TrongLuongSp).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IddongSpNavigation)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.IddongSp)
                    .HasConstraintName("FK_SanPhamDongSanPHam");

                entity.HasOne(d => d.IdthuongHieuNavigation)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.IdthuongHieu)
                    .HasConstraintName("FK_SanPhamThuongHieu");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.Property(e => e.IdtrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaTh).IsUnicode(false);

                entity.Property(e => e.Website).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
