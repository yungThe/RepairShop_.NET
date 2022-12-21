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
    public class LinhKienController : Controller
    {
        private readonly AppDBContext _context;

        public LinhKienController(AppDBContext context)
        {
            _context = context;
        }

        // GET: LinhKien
        public async Task<IActionResult> Index()
        {
              return _context.LinhKien != null ? 
                          View(await _context.LinhKien.ToListAsync()) :
                          Problem("Entity set 'AppDBContext.LinhKien'  is null.");
        }

        // GET: LinhKien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.LinhKien == null)
            {
                return NotFound();
            }

            var linhKien = await _context.LinhKien
                .FirstOrDefaultAsync(m => m.partID == id);
            if (linhKien == null)
            {
                return NotFound();
            }

            return View(linhKien);
        }

        // GET: LinhKien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LinhKien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("partID,partName,partInStock,partDesc,price")] LinhKien linhKien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linhKien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linhKien);
        }

        // GET: LinhKien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.LinhKien == null)
            {
                return NotFound();
            }

            var linhKien = await _context.LinhKien.FindAsync(id);
            if (linhKien == null)
            {
                return NotFound();
            }
            return View(linhKien);
        }

        // POST: LinhKien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("partID,partName,partInStock,partDesc,price")] LinhKien linhKien)
        {
            if (id != linhKien.partID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linhKien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinhKienExists(linhKien.partID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(linhKien);
        }

        public async void UpdateLKEntity(LinhKien lk, LinhKien lk2)
        {
            await DeleteConfirmed(lk.partID);
            await Create(lk2);
        }

        // GET: LinhKien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.LinhKien == null)
            {
                return NotFound();
            }

            var linhKien = await _context.LinhKien
                .FirstOrDefaultAsync(m => m.partID == id);
            if (linhKien == null)
            {
                return NotFound();
            }

            return View(linhKien);
        }

        // POST: LinhKien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.LinhKien == null)
            {
                return Problem("Entity set 'AppDBContext.LinhKien'  is null.");
            }
            var linhKien = await _context.LinhKien.FindAsync(id);
            if (linhKien != null)
            {
                _context.LinhKien.Remove(linhKien);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinhKienExists(string id)
        {
          return (_context.LinhKien?.Any(e => e.partID == id)).GetValueOrDefault();
        }
    }
}
