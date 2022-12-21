using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class NVKT
    {
        [Key]
        public int id { get; set; }
        public ThanhVien thanhvien {get; set; }
        public NVKT() 
        {
        }
    }
}

