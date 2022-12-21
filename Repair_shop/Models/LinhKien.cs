using System;
using System.ComponentModel.DataAnnotations;

namespace Repair_shop.Models
{
    public class LinhKien
    {
        [Key]
        public String partID { get; set; }
        
        public String partName { get; set; }
        
        public int partInStock { get; set; }

        public String partDesc { get; set; }
        
        public int price { get; set; }

        //public virtual ICollection<HoaDonTam> HDT { get; set; }
        //public ICollection<HoaDonTamLinhKien> hoaDonTamLinhKiens { get; set; }
        //public virtual ICollection<Xe> Xe { get; set; }
        public ICollection<LinhKienXe> linhKienXes { get; set; }
        public LinhKien()
        {

        }
    }
}

