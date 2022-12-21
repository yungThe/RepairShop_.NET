using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repair_shop.Data;
using Repair_shop.Models;

namespace Repair_shop.Controllers
{
    public class HoaDonTamController : Controller
    {
        private readonly AppDBContext _context;

        public HoaDonTamController(AppDBContext context)
        {
            _context = context;
        }

        // GET: HoaDonTam
        public async Task<IActionResult> Index(string searchString)
        {
            if(_context.HoaDonTam == null)
            {
                return Problem("Entity set 'AppDBContext.HoaDonTam'  is null.");
            }
            var HDT = from h in _context.HoaDonTam.Include(x => x.khachhang).Include(y => y.xe) select h;
            if (!String.IsNullOrEmpty(searchString))
            {
                HDT = HDT.Where(s => s.id == Int32.Parse(searchString));
            }
            return View(await HDT.ToListAsync());
        }
        /*
        // GET: HoaDonTam/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HoaDonTam == null)
            {
                return NotFound();
            }
            var hoaDonTam = await _context.HoaDonTam.Include(x => x.hoaDonTamLinhKiens).ThenInclude(y => y.linhKien).Include(k => k.khachhang).Include(l => l.xe).SingleOrDefaultAsync(m => m.id == id);
            if (hoaDonTam == null)
            {
                return NotFound();
            }

            return View(hoaDonTam);
        }
        */
        private bool HoaDonTamExists(int id)
        {
          return (_context.HoaDonTam?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
