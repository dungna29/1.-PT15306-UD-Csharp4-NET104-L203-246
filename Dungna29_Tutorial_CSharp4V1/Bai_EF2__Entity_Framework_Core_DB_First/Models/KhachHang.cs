using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MaKH")]
        [StringLength(100)]
        public string MaKh { get; set; }
        [Column("TenKH")]
        [StringLength(100)]
        public string TenKh { get; set; }
        [Column("TenDemKH")]
        [StringLength(100)]
        public string TenDemKh { get; set; }
        [Column("HoKH")]
        [StringLength(100)]
        public string HoKh { get; set; }
        [StringLength(5)]
        public string GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string ThanhPho { get; set; }
        [StringLength(50)]
        public string MaCty { get; set; }
        [StringLength(100)]
        public string TenCty { get; set; }
        [StringLength(100)]
        public string Mst { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [InverseProperty("IdkhachHangNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
