using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class LinhKienXe
    {
        [Key]
        public int id { get; set; }
        public LinhKien linhKiens { get; set; }
        public Xe xe { get; set; }
        public LinhKienXe()
        {
        }
    }
}

