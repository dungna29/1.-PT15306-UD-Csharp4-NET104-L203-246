using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class DongSanPham
    {
        public DongSanPham()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MaDSP")]
        [StringLength(10)]
        public string MaDsp { get; set; }
        [Column("TenDSP")]
        [StringLength(50)]
        public string TenDsp { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [InverseProperty("IddongSpNavigation")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
