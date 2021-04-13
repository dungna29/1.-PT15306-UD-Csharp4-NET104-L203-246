using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class ThuongHieu
    {
        public ThuongHieu()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MaTH")]
        [StringLength(100)]
        public string MaTh { get; set; }
        [Column("TenTH")]
        [StringLength(100)]
        public string TenTh { get; set; }
        [StringLength(150)]
        public string Website { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [InverseProperty("IdthuongHieuNavigation")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
