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
    public class HoaDonGiaoController : Controller
    {
        private readonly AppDBContext _context;

        public HoaDonGiaoController(AppDBContext context)
        {
            _context = context;
        }
        
        // GET: HoaDonGiao
        public async Task<IActionResult> Index()
        {
            if (_context.HoaDonGiao == null)
            {
                return Problem("Entity set 'AppDBContext.HoaDonGiao'  is null.");
            }
            var HDG = from h in _context.HoaDonGiao.Include(x => x.HDT) select h;
            return View(await HDG.ToListAsync());

        }

        // GET: HoaDonGiao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HoaDonGiao == null)
            {
                return NotFound();
            }

            var hoaDonGiao = await _context.HoaDonGiao.Include(x => x.HDT).Include(y => y.HDT.khachhang).Include(h => h.HDT.xe)
                
                .SingleOrDefaultAsync(m => m.id == id);
            if (hoaDonGiao == null)
            {
                return NotFound();
            }

            return View(hoaDonGiao);
        }

        // POST: HoaDonGiao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,HDTid,status")] HoaDonGiao hoaDonGiao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDonGiao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hoaDonGiao);
        }

        //SaveHoaDonGiao()
        public async Task<IActionResult> Success(int? id)
        {
            if (id == null || _context.HoaDonTam == null)
            {
                return NotFound();
            }

            
            var hoaDonTam = await _context.HoaDonTam.SingleOrDefaultAsync(m => m.id == id);
            var hdg = new HoaDonGiao
            {
                HDT = hoaDonTam,
                status = 1
            };
            
            await Create(hdg);
            if (hoaDonTam == null)
            {
                return NotFound();
            }

            return View(hoaDonTam);

        }

        // GET: HoaDonGiao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HoaDonGiao == null)
            {
                return NotFound();
            }

            var hoaDonGiao = await _context.HoaDonGiao
                .FirstOrDefaultAsync(m => m.id == id);
            if (hoaDonGiao == null)
            {
                return NotFound();
            }

            return View(hoaDonGiao);
        }

        // POST: HoaDonGiao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HoaDonGiao == null)
            {
                return Problem("Entity set 'AppDBContext.HoaDonGiao'  is null.");
            }
            var hoaDonGiao = await _context.HoaDonGiao.FindAsync(id);
            if (hoaDonGiao != null)
            {
                _context.HoaDonGiao.Remove(hoaDonGiao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonGiaoExists(int id)
        {
          return (_context.HoaDonGiao?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
