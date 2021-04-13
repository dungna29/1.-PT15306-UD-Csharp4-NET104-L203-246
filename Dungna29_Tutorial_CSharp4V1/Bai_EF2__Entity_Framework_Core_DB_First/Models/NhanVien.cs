using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDCuaHang")]
        public int? IdcuaHang { get; set; }
        [Column("MaNV")]
        [StringLength(50)]
        public string MaNv { get; set; }
        [Column("TenNV")]
        [StringLength(50)]
        public string TenNv { get; set; }
        [Column("HoNV")]
        [StringLength(50)]
        public string HoNv { get; set; }
        [Column("TenDemNV")]
        [StringLength(50)]
        public string TenDemNv { get; set; }
        [StringLength(10)]
        public string GioiTinh { get; set; }
        [StringLength(255)]
        public string DiaChi { get; set; }
        [Column("LuongNV", TypeName = "decimal(20, 0)")]
        public decimal? LuongNv { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Column("IDChucVu")]
        public int? IdchucVu { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [ForeignKey(nameof(IdchucVu))]
        [InverseProperty(nameof(ChucVu.NhanVien))]
        public virtual ChucVu IdchucVuNavigation { get; set; }
        [ForeignKey(nameof(IdcuaHang))]
        [InverseProperty(nameof(CuaHang.NhanVien))]
        public virtual CuaHang IdcuaHangNavigation { get; set; }
        [InverseProperty("IdnhanVienNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
