using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Desenvolvedor_DiscursivaEspecifica_3.Data;
using Desenvolvedor_DiscursivaEspecifica_3.Models;

namespace Desenvolvedor_DiscursivaEspecifica_3.Controllers
{
    public class BlocoController : Controller
    {
        private readonly Desenvolvedor_DiscursivaEspecifica_3Context _context;

        public BlocoController(Desenvolvedor_DiscursivaEspecifica_3Context context)
        {
            _context = context;
        }

        // GET: Bloco
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bloco.ToListAsync());
        }

        // GET: Bloco/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloco = await _context.Bloco
                .FirstOrDefaultAsync(m => m.BlocoId == id);
            if (bloco == null)
            {
                return NotFound();
            }

            return View(bloco);
        }

        // GET: Bloco/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bloco/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlocoId,Nome")] Bloco bloco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloco);
        }

        // GET: Bloco/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloco = await _context.Bloco.FindAsync(id);
            if (bloco == null)
            {
                return NotFound();
            }
            return View(bloco);
        }

        // POST: Bloco/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlocoId,Nome")] Bloco bloco)
        {
            if (id != bloco.BlocoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlocoExists(bloco.BlocoId))
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
            return View(bloco);
        }

        // GET: Bloco/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloco = await _context.Bloco
                .FirstOrDefaultAsync(m => m.BlocoId == id);
            if (bloco == null)
            {
                return NotFound();
            }

            return View(bloco);
        }

        // POST: Bloco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloco = await _context.Bloco.FindAsync(id);
            _context.Bloco.Remove(bloco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlocoExists(int id)
        {
            return _context.Bloco.Any(e => e.BlocoId == id);
        }
    }
}
