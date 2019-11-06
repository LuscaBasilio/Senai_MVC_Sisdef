using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Senai.SAEP.Sisdef.Contextos;
using Senai.SAEP.Sisdef.Domains;

namespace Senai.SAEP.Sisdef.Controllers
{
    public class DefeitoController : Controller
    {
        private readonly SisdefContext _context;

        public DefeitoController(SisdefContext context)
        {
            _context = context;
        }

        // GET: Defeito
        public async Task<IActionResult> Index()
        {
            return View(await _context.Defeito.ToListAsync());
        }

        // GET: Defeito/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defeito = await _context.Defeito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (defeito == null)
            {
                return NotFound();
            }

            return View(defeito);
        }

        // GET: Defeito/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Defeito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Defeito defeito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(defeito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(defeito);
        }

        // GET: Defeito/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defeito = await _context.Defeito.FindAsync(id);
            if (defeito == null)
            {
                return NotFound();
            }
            return View(defeito);
        }

        // POST: Defeito/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Defeito defeito)
        {
            if (id != defeito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(defeito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DefeitoExists(defeito.Id))
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
            return View(defeito);
        }

        // GET: Defeito/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defeito = await _context.Defeito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (defeito == null)
            {
                return NotFound();
            }

            return View(defeito);
        }

        // POST: Defeito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var defeito = await _context.Defeito.FindAsync(id);
            _context.Defeito.Remove(defeito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DefeitoExists(int id)
        {
            return _context.Defeito.Any(e => e.Id == id);
        }
    }
}
