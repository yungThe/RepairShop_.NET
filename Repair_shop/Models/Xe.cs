using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class Xe
    {
        [Key]
        public int id { get; set; }
        public String hangXe { get; set; }
        public String tenXe { get; set; }
        //public virtual ICollection<KhachHang> khachhang { get; set; }
        public ICollection<KhachHangXe> khachHangXes { get; set; }
        //public virtual ICollection<LinhKien> linhKiens { get; set; }
        public ICollection<LinhKienXe> linhKienXes { get; set; }
        public ICollection<HoaDonTam> hoaDonTams { get; set; }
        public Xe()
        {
        }
    }
}

