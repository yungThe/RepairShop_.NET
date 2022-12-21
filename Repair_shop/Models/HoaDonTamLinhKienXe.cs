using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class HoaDonTamLinhKienXe
    {
        public HoaDonTamLinhKienXe()
        {
        }
        [Key]
        public int id { get; set; }
        public HoaDonTam hoaDonTam { get; set; }
        public LinhKienXe linhKienXe { get; set; }
    }
}

