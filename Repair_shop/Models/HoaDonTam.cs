using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repair_shop.Models
{
    public class HoaDonTam
    {
        [Key]
        public int id { get; set; }
        public KhachHang khachhang { get; set; }
        public Xe xe { get; set; }
        public int status { get; set; }
        public ICollection<HoaDonTamLinhKienXe> hoaDonTamLinhKienXes { get; set; }
        public HoaDonTam()
        {
        }
    }
}

