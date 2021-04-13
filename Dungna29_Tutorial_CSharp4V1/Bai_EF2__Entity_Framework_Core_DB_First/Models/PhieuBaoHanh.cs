using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class PhieuBaoHanh
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(100)]
        public string MaPhieu { get; set; }
        [Column("IDSanPham")]
        public int? IdsanPham { get; set; }
        [Column("IDHoaDon")]
        public int? IdhoaDon { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }
        [StringLength(255)]
        public string MoTa { get; set; }
        [Column("IMEI")]
        [StringLength(255)]
        public string Imei { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [ForeignKey(nameof(IdhoaDon))]
        [InverseProperty(nameof(HoaDon.PhieuBaoHanh))]
        public virtual HoaDon IdhoaDonNavigation { get; set; }
        [ForeignKey(nameof(IdsanPham))]
        [InverseProperty(nameof(SanPham.PhieuBaoHanh))]
        public virtual SanPham IdsanPhamNavigation { get; set; }
    }
}
