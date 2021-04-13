using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_EF1__Entity_Framework_Core_Code_First.Models
{
    [Table("Product")]//Tạo tên bảng
    public class Product
    {
        [Key]//Đặt khóa chính
        public Guid id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public float discount { get; set; }
        public int quantity { get; set; }
        public int shop { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime publishedAt { get; set; }
        public DateTime startsAt { get; set; }
        public string content { get; set; }
        public bool disable { get; set; }
       

    }
}
