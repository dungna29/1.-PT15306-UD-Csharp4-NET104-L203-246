using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class HoaDonChiTiet
    {
        [Key]
        [Column("IDHoaDon")]
        public int IdhoaDon { get; set; }
        [Key]
        [Column("IDSanPham")]
        public int IdsanPham { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? DonGia { get; set; }

        [ForeignKey(nameof(IdhoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiet))]
        public virtual HoaDon IdhoaDonNavigation { get; set; }
        [ForeignKey(nameof(IdsanPham))]
        [InverseProperty(nameof(SanPham.HoaDonChiTiet))]
        public virtual SanPham IdsanPhamNavigation { get; set; }
    }
}
