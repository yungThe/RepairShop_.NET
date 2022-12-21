using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class KhachHangXe
    {
        [Key]
        public int id { get; set; }
        //public int KHid { get; set; }
        public KhachHang khachHang { get; set; }
        public int Xeid { get; set; }
        public Xe Xe { get; set; }
        public KhachHangXe()
        {
        }
    }
}

