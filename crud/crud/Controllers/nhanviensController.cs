using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using crud.Models;

namespace crud.Controllers
{
    public class nhanviensController : Controller
    {
        private readonly mydbcontext _context;

        public nhanviensController(mydbcontext context)
        {
            _context = context;
        }

        // GET: nhanviens
        public async Task<IActionResult> Index()
        {
            return View(await _context.nhanviens.ToListAsync());
        }

        // GET: nhanviens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.nhanviens
                .FirstOrDefaultAsync(m => m.id == id);
            if (nhanvien == null)
            {
                return NotFound();
            }

            return View(nhanvien);
        }

        // GET: nhanviens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: nhanviens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ten,vitri,luong")] nhanvien nhanvien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanvien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhanvien);
        }

        // GET: nhanviens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.nhanviens.FindAsync(id);
            if (nhanvien == null)
            {
                return NotFound();
            }
            return View(nhanvien);
        }

        // POST: nhanviens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ten,vitri,luong")] nhanvien nhanvien)
        {
            if (id != nhanvien.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanvien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!nhanvienExists(nhanvien.id))
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
            return View(nhanvien);
        }

        // GET: nhanviens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.nhanviens
                .FirstOrDefaultAsync(m => m.id == id);
            if (nhanvien == null)
            {
                return NotFound();
            }

            return View(nhanvien);
        }

        // POST: nhanviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhanvien = await _context.nhanviens.FindAsync(id);
            _context.nhanviens.Remove(nhanvien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool nhanvienExists(int id)
        {
            return _context.nhanviens.Any(e => e.id == id);
        }
    }
}
