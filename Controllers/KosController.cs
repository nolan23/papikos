using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PapiKos.Models;

namespace PapiKos.Controllers
{
    public class KosController : Controller
    {
        private readonly PapiKosContext _context;

        public KosController(PapiKosContext context)
        {
            _context = context;
        }

        // GET: Kos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kos.ToListAsync());
        }

        // GET: Kos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kos = await _context.Kos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kos == null)
            {
                return NotFound();
            }

            return View(kos);
        }

        // GET: Kos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NamaKos,JumlahKamar,DeskripsiTambahan,Alamat")] Kos kos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kos);
        }

        // GET: Kos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kos = await _context.Kos.FindAsync(id);
            if (kos == null)
            {
                return NotFound();
            }
            return View(kos);
        }

        // POST: Kos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NamaKos,JumlahKamar,DeskripsiTambahan,Alamat")] Kos kos)
        {
            if (id != kos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KosExists(kos.Id))
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
            return View(kos);
        }

        // GET: Kos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kos = await _context.Kos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kos == null)
            {
                return NotFound();
            }

            return View(kos);
        }

        // POST: Kos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kos = await _context.Kos.FindAsync(id);
            _context.Kos.Remove(kos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KosExists(int id)
        {
            return _context.Kos.Any(e => e.Id == id);
        }
    }
}
