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
    public class RegDefController : Controller
    {
        private readonly SisdefContext _context;

        public RegDefController(SisdefContext context)
        {
            _context = context;
        }

        // GET: RegDef
        public async Task<IActionResult> Index()
        {
            var sisdefContext = _context.RegistroDefeito.Include(r => r.Equipamento).Include(r => r.TipoDefeito);
            return View(await sisdefContext.ToListAsync());
        }

        // GET: RegDef/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroDefeito = await _context.RegistroDefeito
                .Include(r => r.Equipamento)
                .Include(r => r.TipoDefeito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroDefeito == null)
            {
                return NotFound();
            }

            return View(registroDefeito);
        }

        // GET: RegDef/Create
        public IActionResult Create()
        {
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "Id", "Id");
            ViewData["TipoDefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome");
            return View();
        }

        // POST: RegDef/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataDefeito,EquipamentoId,TipoDefeitoId,HoraInicial,HoraFinal")] RegistroDefeito registroDefeito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroDefeito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "Id", "Id", registroDefeito.EquipamentoId);
            ViewData["TipoDefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.TipoDefeitoId);
            return View(registroDefeito);
        }

        // GET: RegDef/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroDefeito = await _context.RegistroDefeito.FindAsync(id);
            if (registroDefeito == null)
            {
                return NotFound();
            }
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "Id", "Id", registroDefeito.EquipamentoId);
            ViewData["TipoDefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.TipoDefeitoId);
            return View(registroDefeito);
        }

        // POST: RegDef/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataDefeito,EquipamentoId,TipoDefeitoId,HoraInicial,HoraFinal")] RegistroDefeito registroDefeito)
        {
            if (id != registroDefeito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroDefeito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroDefeitoExists(registroDefeito.Id))
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
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "Id", "Id", registroDefeito.EquipamentoId);
            ViewData["TipoDefeitoId"] = new SelectList(_context.Defeito, "Id", "Nome", registroDefeito.TipoDefeitoId);
            return View(registroDefeito);
        }

        // GET: RegDef/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroDefeito = await _context.RegistroDefeito
                .Include(r => r.Equipamento)
                .Include(r => r.TipoDefeito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroDefeito == null)
            {
                return NotFound();
            }

            return View(registroDefeito);
        }

        // POST: RegDef/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroDefeito = await _context.RegistroDefeito.FindAsync(id);
            _context.RegistroDefeito.Remove(registroDefeito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroDefeitoExists(int id)
        {
            return _context.RegistroDefeito.Any(e => e.Id == id);
        }
    }
}
