namespace Repair_shop.Tests;
using Repair_shop.Models;
using Repair_shop.Controllers;
using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repair_shop.Data;

public class UnitTest1
{
    public static DbContextOptions<AppDBContext> TestDbContextOptions()
    {
        // Create a new service provider to create a new in-memory database.
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        // Create a new options instance using an in-memory database and 
        // IServiceProvider that the context should resolve all of its 
        // services from.
        var builder = new DbContextOptionsBuilder<AppDBContext>()
            .UseInMemoryDatabase("InMemoryDb")
            .UseInternalServiceProvider(serviceProvider);

        return builder.Options;
    }

    [Fact]
    public void LinhKienController_CanChangePrice()
    {
        var lk = new LinhKien
        {
            partID = "90",
            partName = "Test",
            partInStock = 90,
            partDesc = "test",
            price = 1500000
        };
        lk.price = 12000;
        Assert.Equal(12000, lk.price);
    }

    [Fact]
    public void LinhKienController_CanChangeName()
    {
        var lk = new LinhKien
        {
            partID = "90",
            partName = "Test",
            partInStock = 90,
            partDesc = "test",
            price = 1500000
        };
        lk.partName = "Yung";
        Assert.Equal("Yung", lk.partName);
    }

    [Fact]
    public void LinhKienController_CanChangeStockNum()
    {
        var lk = new LinhKien
        {
            partID = "90",
            partName = "Test",
            partInStock = 90,
            partDesc = "test",
            price = 1500000
        };
        lk.partInStock = 10;
        Assert.Equal(10, lk.partInStock);
    }

    [Fact]
    public void LinhKienController_CanChangeDescription()
    {
        var lk = new LinhKien
        {
            partID = "90",
            partName = "Test",
            partInStock = 90,
            partDesc = "test",
            price = 1500000
        };
        lk.partDesc = "a";
        Assert.Equal("a", lk.partDesc);
    }

    [Fact]
    public async Task LinhKienController_CanGetLinhKien()
    {
        using (var db = new AppDBContext(TestDbContextOptions()))
        {
            var lk = new LinhKien
            {
                partID = "90",
                partName = "Test",
                partInStock = 90,
                partDesc = "test",
                price = 1500000
            };
            await db.LinhKien.AddRangeAsync(lk);
            await db.SaveChangesAsync();
            var actuallk = await db.LinhKien.ToListAsync();
            Assert.Equal(lk, actuallk.SingleOrDefault(m => m.partID == "90"));
        }
    }

    [Fact]
    public async Task LinhKienController_CanGetLinhKienByID()
    {
        using (var db = new AppDBContext(TestDbContextOptions()))
        {
            var lk = new LinhKien
            {
                partID = "90",
                partName = "Test",
                partInStock = 90,
                partDesc = "test",
                price = 1500000
            };
            await db.LinhKien.AddRangeAsync(lk);
            await db.SaveChangesAsync();
            var actuallk = await db.LinhKien.ToListAsync();
            Assert.Equal(lk, actuallk.SingleOrDefault(m => m.partID == "90"));
        }
    }

    [Fact]
    public async Task HoaDonTamController_CanGetHoaDonTam()
    {
        using(var db = new AppDBContext(TestDbContextOptions()))
        {
            var kh = new KhachHang
            {
                id = 1,
                firstName = "Dung",
                lastName = "Nguyen",
                phone = "0986432970"
            };
            var x = new Xe
            {
                id = 1,
                hangXe = "a",
                tenXe = "b"
            };
            var hdt = new HoaDonTam
            {
                id = 1,
                khachhang = kh,
                xe = x
            };
            await db.HoaDonTam.AddRangeAsync(hdt);
            await db.SaveChangesAsync();
            var actualhdt = await db.HoaDonTam.ToListAsync();
            Assert.Equal(hdt, actualhdt.SingleOrDefault(m => m.id == 1));
        }
    }

    [Fact]
    public async Task HoaDonTamController_CanSearch()
    {
        using (var db = new AppDBContext(TestDbContextOptions()))
        {
            var kh = new KhachHang
            {
                id = 1,
                firstName = "Dung",
                lastName = "Nguyen",
                phone = "0986432970"
            };
            var x = new Xe
            {
                id = 1,
                hangXe = "a",
                tenXe = "b"
            };
            var hdt = new HoaDonTam
            {
                id = 1,
                khachhang = kh,
                xe = x
            };
            await db.HoaDonTam.AddRangeAsync(hdt);
            await db.SaveChangesAsync();
            var actualhdt = await db.HoaDonTam.ToListAsync();
            Assert.Equal(hdt, actualhdt.SingleOrDefault(m => m.id == 1));
        }
    }

    [Fact]
    public async Task HoaDonGiaoController_CanGetHoaDonGiao()
    {
        using (var db = new AppDBContext(TestDbContextOptions()))
        {
            var kh = new KhachHang
            {
                id = 1,
                firstName = "Dung",
                lastName = "Nguyen",
                phone = "0986432970"
            };
            var x = new Xe
            {
                id = 1,
                hangXe = "a",
                tenXe = "b"
            };
            var hdt = new HoaDonTam
            {
                id = 1,
                khachhang = kh,
                xe = x
            };
            var hdg = new HoaDonGiao
            {
                id = 1,
                HDT = hdt,
                status = 1
            };
            await db.HoaDonGiao.AddRangeAsync(hdg);
            await db.SaveChangesAsync();
            var actualhdg = await db.HoaDonGiao.ToListAsync();
            Assert.Equal(hdg, actualhdg.SingleOrDefault(m => m.id == 1));
        }
    }

    [Fact]
    public async Task HoaDonGiaoController_CanGetHoaDonGiaoByID()
    {
        using (var db = new AppDBContext(TestDbContextOptions()))
        {
            var kh = new KhachHang
            {
                id = 1,
                firstName = "Dung",
                lastName = "Nguyen",
                phone = "0986432970"
            };
            var x = new Xe
            {
                id = 1,
                hangXe = "a",
                tenXe = "b"
            };
            var hdt = new HoaDonTam
            {
                id = 1,
                khachhang = kh,
                xe = x
            };
            var hdg = new HoaDonGiao
            {
                id = 1,
                HDT = hdt,
                status = 1
            };
            await db.HoaDonGiao.AddRangeAsync(hdg);
            await db.SaveChangesAsync();
            var actualhdg = await db.HoaDonGiao.ToListAsync();
            Assert.Equal(hdg, actualhdg.SingleOrDefault(m => m.id == 1));
        }
    }

    [Fact]
    public async Task HoaDonGiaoController_CanSaveHoaDonGiao()
    {
        using (var db = new AppDBContext(TestDbContextOptions()))
        {
            var kh = new KhachHang
            {
                id = 1,
                firstName = "Dung",
                lastName = "Nguyen",
                phone = "0986432970"
            };
            var x = new Xe
            {
                id = 1,
                hangXe = "a",
                tenXe = "b"
            };
            var hdt = new HoaDonTam
            {
                id = 1,
                khachhang = kh,
                xe = x
            };
            var hdg = new HoaDonGiao
            {
                id = 1,
                HDT = hdt,
                status = 1
            };
            await db.HoaDonGiao.AddRangeAsync(hdg);
            await db.SaveChangesAsync();
            var actualhdg = await db.HoaDonGiao.ToListAsync();
            Assert.Equal(hdg, actualhdg.SingleOrDefault(m => m.id == 1));
        }
    }
}
