using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF2__Entity_Framework_Core_DB_First.Models
{
    public partial class CuaHang
    {
        public CuaHang()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MaCH")]
        [StringLength(100)]
        public string MaCh { get; set; }
        [Column("TenCH")]
        [StringLength(100)]
        public string TenCh { get; set; }
        [StringLength(255)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string ThanhPho { get; set; }
        [StringLength(50)]
        public string QuocGia { get; set; }
        [Column("IDTrangThai")]
        public int? IdtrangThai { get; set; }

        [InverseProperty("IdcuaHangNavigation")]
        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
