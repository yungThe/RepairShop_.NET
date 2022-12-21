using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repair_shop.Models
{
    public class KhachHang
    {
        [Key]
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phone { get; set; }
        //public virtual ICollection<Xe> Xe { get; set; }
        public ICollection<KhachHangXe> khachHangXes { get; set; }
        public ICollection<HoaDonTam> hoaDonTams { get; set; }
        public KhachHang()
        {
        }
    }
}

