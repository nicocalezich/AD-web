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
    public class ConfiguracionTiposController : Controller
    {
        private readonly ADDBContext _context;

        public ConfiguracionTiposController(ADDBContext context)
        {
            _context = context;
        }

        // GET: ConfiguracionTipos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ConfiguracionTipos.ToListAsync());
        }

        public IActionResult Opciones()
        {
            return View();
        }

        // GET: ConfiguracionTipos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionTipos = await _context.ConfiguracionTipos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configuracionTipos == null)
            {
                return NotFound();
            }

            return View(configuracionTipos);
        }

        // GET: ConfiguracionTipos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConfiguracionTipos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipos")] ConfiguracionTipos configuracionTipos)
        {
            if (ModelState.IsValid && !TipoExiste(configuracionTipos.Tipos))
            {
                _context.Add(configuracionTipos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(configuracionTipos);
        }

        // GET: ConfiguracionTipos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionTipos = await _context.ConfiguracionTipos.FindAsync(id);
            if (configuracionTipos == null)
            {
                return NotFound();
            }
            return View(configuracionTipos);
        }

        // POST: ConfiguracionTipos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipos")] ConfiguracionTipos configuracionTipos)
        {
            if (id != configuracionTipos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(configuracionTipos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfiguracionTiposExists(configuracionTipos.Id))
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
            return View(configuracionTipos);
        }

        // GET: ConfiguracionTipos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configuracionTipos = await _context.ConfiguracionTipos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configuracionTipos == null)
            {
                return NotFound();
            }

            return View(configuracionTipos);
        }

        // POST: ConfiguracionTipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var configuracionTipos = await _context.ConfiguracionTipos.FindAsync(id);
            _context.ConfiguracionTipos.Remove(configuracionTipos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfiguracionTiposExists(int id)
        {
            return _context.ConfiguracionTipos.Any(e => e.Id == id);
        }

        private List<string> Tipos()
        {
            return (from n in _context.ConfiguracionTipos select n.Tipos).ToList();
        }

        private bool TipoExiste (string tipo){

           bool existe = false;

           for(int i = 0; i < Tipos().Count; i++)
            {
                if (Tipos()[i].Equals(tipo))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

    }
}
