using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_9_LamViecVoiForm.Models
{
    public class ProductEditModel
    {
        public int Id { get; set; }
        [Display(Name="Tên")]
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }
    }
}
