using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(30)]
        public string MaChucVu { get; set; }
        [StringLength(30)]
        public string TenChucVu { get; set; }

        [InverseProperty("IdchucVuNavigation")]
        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
