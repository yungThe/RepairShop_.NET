using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class ThanhVien
    {
        [Key]
        public int id { get; set; }
        public String userName { get; set; }
        public String pass { get; set; }
        public String name { get; set; }
        
        public String phone { get; set; }
        public ThanhVien()
        {
            
        }
    }
}

