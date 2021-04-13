using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiet = new HashSet<HoaDonChiTiet>();
            PhieuBaoHanh = new HashSet<PhieuBaoHanh>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDKhachHang")]
        public int? IdkhachHang { get; set; }
        [Column("IDNhanVien")]
        public int? IdnhanVien { get; set; }
        [Column("MaHD")]
        [StringLength(100)]
        public string MaHd { get; set; }
        [Column("NgayTaoHD", TypeName = "date")]
        public DateTime? NgayTaoHd { get; set; }
        [Column("NgayThanhToanHD", TypeName = "date")]
        public DateTime? NgayThanhToanHd { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayShipHang { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhanHang { get; set; }
        [StringLength(255)]
        public string DiachiGiaoHang { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [ForeignKey(nameof(IdkhachHang))]
        [InverseProperty(nameof(KhachHang.HoaDon))]
        public virtual KhachHang IdkhachHangNavigation { get; set; }
        [ForeignKey(nameof(IdnhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDon))]
        public virtual NhanVien IdnhanVienNavigation { get; set; }
        [InverseProperty("IdhoaDonNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        [InverseProperty("IdhoaDonNavigation")]
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanh { get; set; }
    }
}
