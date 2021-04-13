using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_9_LamViecVoiForm.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Trường này không được để null")]//Thuộc tính bắt buộc phải nhập
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime NgayTao { get; set; } 
    }
}
