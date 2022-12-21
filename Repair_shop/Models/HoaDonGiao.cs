using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repair_shop.Models
{
    public class HoaDonGiao
    {
        [Key]
        public int id { get; set; }
        public HoaDonTam HDT { get; set; }
        public int status { get; set; }
        public HoaDonGiao()
        {
        }
    }
}

