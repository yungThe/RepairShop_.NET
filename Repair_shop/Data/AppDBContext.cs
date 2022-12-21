using System;
using Microsoft.EntityFrameworkCore;
//using Repair_shop.Model;
using Repair_shop.Models;

namespace Repair_shop.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
        
        public DbSet<Repair_shop.Models.LinhKien>? LinhKien { get; set; }
        public DbSet<Repair_shop.Models.HoaDonTam>? HoaDonTam { get; set; }
        public DbSet<Repair_shop.Models.HoaDonGiao>? HoaDonGiao { get; set; }
        public DbSet<Repair_shop.Models.KhachHang>? KhachHang { get; set; }
        public DbSet<Repair_shop.Models.ThanhVien>? ThanhVien { get; set; }
        public DbSet<Repair_shop.Models.NVKho>? NVKho { get; set; }
        public DbSet<Repair_shop.Models.NVKT>? NVKT { get; set; }
        public DbSet<Repair_shop.Models.Xe>? Xe { get; set; }
        public DbSet<Repair_shop.Models.LinhKienXe>? linhKienXes { get; set; }
        public DbSet<Repair_shop.Models.HoaDonTamLinhKienXe>? hoaDonTamLinhKienxes { get; set; }
        public DbSet<Repair_shop.Models.KhachHangXe>? KhachHangXes { get; set; }






        //public DbSet<Repair_shop.Models.HoaDon>? HoaDon { get; set; }
    }
}

