using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class NVKho
    {
        [Key]
        public int id { get; set; }
        public ThanhVien thanhVien { get; set; }
        public NVKho()
        {
        }
    }
}

