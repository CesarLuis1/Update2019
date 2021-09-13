using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class NovaTransController : Controller
    {
        private readonly SalesWebMVCContext _context;

        public NovaTransController(SalesWebMVCContext context)
        {
            _context = context;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transacao.ToListAsync());
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novaTrans = await _context.Transacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (novaTrans == null)
            {
                return NotFound();
            }

            return View(novaTrans);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name, NumTransacao")] NovaTrans novaTrans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(novaTrans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(novaTrans);
        }

        // GET: Departments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novaTrans = await _context.Transacao.FindAsync(id);
            if (novaTrans == null)
            {
                return NotFound();
            }
            return View(novaTrans);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name, NumTransacao")] NovaTrans novaTrans)
        {
            if (id != novaTrans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(novaTrans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!novaTransExists(novaTrans.Id))
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
            return View(novaTrans);
        }

        // GET: Departments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novaTrans = await _context.Transacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (novaTrans == null)
            {
                return NotFound();
            }

            return View(novaTrans);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var novaTrans = await _context.Transacao.FindAsync(id);
            _context.Transacao.Remove(novaTrans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool novaTransExists(int id)
        {
            return _context.Transacao.Any(e => e.Id == id);
        }
    }
}
