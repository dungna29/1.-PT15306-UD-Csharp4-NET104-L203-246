using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_EF1__Entity_Framework_Core_Code_First.Models
{
    /// <summary>
    /// Cách thức xây dựng cơ sở dữ liệu từ trong code - tạo các Table
    /// </summary>

    [Table("Category")]//Đặt tên bảng
    public class Category
    {
        [Key]//Xác định khóa chính trong bảng - và các thuộc tính
        public Guid id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool disable { get; set; }
    }
}
