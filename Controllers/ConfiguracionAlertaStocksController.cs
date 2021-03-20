using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADweb.Models;

namespace ADweb.Controllers
{
    public class ConfiguracionAlertaStocksController : Controller
    {
        private readonly ADDBContext _context;

        public ConfiguracionAlertaStocksController(ADDBContext context)
        {
            _context = context;
        }

        // GET: ConfiguracionAlertaStocks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ConfiguracionAlertaStock.ToListAsync());
        }

        // GET: ConfiguracionAlertaStocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionAlertaStock = await _context.ConfiguracionAlertaStock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configuracionAlertaStock == null)
            {
                return NotFound();
            }

            return View(configuracionAlertaStock);
        }

        // GET: ConfiguracionAlertaStocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConfiguracionAlertaStocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Valor")] ConfiguracionAlertaStock configuracionAlertaStock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(configuracionAlertaStock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(configuracionAlertaStock);
        }

        // GET: ConfiguracionAlertaStocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionAlertaStock = await _context.ConfiguracionAlertaStock.FindAsync(id);
            if (configuracionAlertaStock == null)
            {
                return NotFound();
            }
            return View(configuracionAlertaStock);
        }

        // POST: ConfiguracionAlertaStocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Valor")] ConfiguracionAlertaStock configuracionAlertaStock)
        {
            if (id != configuracionAlertaStock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && configuracionAlertaStock.Valor > 0)
            {
                try
                {
                    _context.Update(configuracionAlertaStock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfiguracionAlertaStockExists(configuracionAlertaStock.Id))
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
            return View(configuracionAlertaStock);
        }

        // GET: ConfiguracionAlertaStocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionAlertaStock = await _context.ConfiguracionAlertaStock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configuracionAlertaStock == null)
            {
                return NotFound();
            }

            return View(configuracionAlertaStock);
        }

        // POST: ConfiguracionAlertaStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var configuracionAlertaStock = await _context.ConfiguracionAlertaStock.FindAsync(id);
            _context.ConfiguracionAlertaStock.Remove(configuracionAlertaStock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Volver()
        {
            return RedirectToAction("Opciones", "ConfiguracionTipos");
        }

        private bool ConfiguracionAlertaStockExists(int id)
        {
            return _context.ConfiguracionAlertaStock.Any(e => e.Id == id);
        }
    }
}
