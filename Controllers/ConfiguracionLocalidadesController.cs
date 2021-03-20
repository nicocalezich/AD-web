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
    public class ConfiguracionLocalidadesController : Controller
    {
        private readonly ADDBContext _context;

        public ConfiguracionLocalidadesController(ADDBContext context)
        {
            _context = context;
        }

        // GET: ConfiguracionLocalidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.ConfiguracionLocalidades.ToListAsync());
        }

        // GET: ConfiguracionLocalidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionLocalidades = await _context.ConfiguracionLocalidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configuracionLocalidades == null)
            {
                return NotFound();
            }

            return View(configuracionLocalidades);
        }

        // GET: ConfiguracionLocalidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConfiguracionLocalidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Localidades")] ConfiguracionLocalidades configuracionLocalidades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(configuracionLocalidades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(configuracionLocalidades);
        }

        // GET: ConfiguracionLocalidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionLocalidades = await _context.ConfiguracionLocalidades.FindAsync(id);
            if (configuracionLocalidades == null)
            {
                return NotFound();
            }
            return View(configuracionLocalidades);
        }

        // POST: ConfiguracionLocalidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Localidades")] ConfiguracionLocalidades configuracionLocalidades)
        {
            if (id != configuracionLocalidades.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(configuracionLocalidades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfiguracionLocalidadesExists(configuracionLocalidades.Id))
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
            return View(configuracionLocalidades);
        }

        // GET: ConfiguracionLocalidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionLocalidades = await _context.ConfiguracionLocalidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configuracionLocalidades == null)
            {
                return NotFound();
            }

            return View(configuracionLocalidades);
        }

        // POST: ConfiguracionLocalidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var configuracionLocalidades = await _context.ConfiguracionLocalidades.FindAsync(id);
            _context.ConfiguracionLocalidades.Remove(configuracionLocalidades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Volver()
        {
            return RedirectToAction("Opciones", "ConfiguracionTipos");
        }

        private bool ConfiguracionLocalidadesExists(int id)
        {
            return _context.ConfiguracionLocalidades.Any(e => e.Id == id);
        }
    }
}
