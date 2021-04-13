using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiet = new HashSet<HoaDonChiTiet>();
            PhieuBaoHanh = new HashSet<PhieuBaoHanh>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MaSP")]
        [StringLength(50)]
        public string MaSp { get; set; }
        [Column("TenSP")]
        [StringLength(100)]
        public string TenSp { get; set; }
        [StringLength(100)]
        public string ManHinh { get; set; }
        [Column("MotaSP")]
        [StringLength(255)]
        public string MotaSp { get; set; }
        [Column("TrongLuongSP", TypeName = "decimal(20, 0)")]
        public decimal? TrongLuongSp { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaNhap { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaBan { get; set; }
        public int? SoLuong { get; set; }
        [Column("IDDongSP")]
        public int? IddongSp { get; set; }
        [Column("IDThuongHieu")]
        public int? IdthuongHieu { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [ForeignKey(nameof(IddongSp))]
        [InverseProperty(nameof(DongSanPham.SanPham))]
        public virtual DongSanPham IddongSpNavigation { get; set; }
        [ForeignKey(nameof(IdthuongHieu))]
        [InverseProperty(nameof(ThuongHieu.SanPham))]
        public virtual ThuongHieu IdthuongHieuNavigation { get; set; }
        [InverseProperty("IdsanPhamNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        [InverseProperty("IdsanPhamNavigation")]
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanh { get; set; }
    }
}
