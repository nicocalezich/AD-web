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
    public class ProductosController : Controller
    {
        private readonly ADDBContext _context;

        public ProductosController(ADDBContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            ViewBag.alerta = AlertaStock()[0];
            ViewBag.tipos = Tipos();
            ViewBag.valorStock = ValorStock();
            return View(await _context.Productos.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await _context.Productos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewBag.tipos = Tipos();
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Producto,Tipo,UnidadUsada,PrecioKgUnidad,CantidadDisponible")] Productos productos)
        {
            if (ModelState.IsValid && numeroValido(productos.PrecioKgUnidad) && numeroValido(productos.CantidadDisponible) && productos.Producto != null)
            {
                if(productos.CantidadDisponible == 0)
                {
                    productos.HayStock = false;
                }
                else
                {
                    productos.HayStock = true;
                }
                _context.Add(productos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productos);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await _context.Productos.FindAsync(id);
            if (productos == null)
            {
                return NotFound();
            }
            ViewBag.tipos = Tipos();
            return View(productos);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Producto,Tipo,HayStock,UnidadUsada,PrecioKgUnidad,CantidadDisponible")] Productos productos)
        {
            if (id != productos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && numeroValido(productos.PrecioKgUnidad) && numeroValido(productos.CantidadDisponible) && productos.Producto != null)
            {
                if (productos.CantidadDisponible == 0)
                {
                    productos.HayStock = false;
                }
                else
                {
                    productos.HayStock = true;
                }
                try
                {
                    _context.Update(productos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductosExists(productos.Id))
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
            return View(productos);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await _context.Productos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productos = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(productos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductosExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }

        [HttpPost]
        public  IActionResult Filtro(String selector)
        {
            ViewBag.alerta = AlertaStock()[0];
            ViewBag.tipos = Tipos();

            var tipo = (from s in _context.Productos where s.Tipo.Equals(selector) select s).ToList();

            ViewBag.opcion = selector;         

            if (!selector.Equals("Ver todo"))
            {     
                return View(tipo);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }          
        }

        public bool numeroValido(double num)
        {
            return num >= 0;
        }

        public double ValorStock()
        {
            double total = 0;

            var precio = (from s in _context.Productos where s.HayStock == true select s.PrecioKgUnidad).ToList();
            var cantidades = (from s in _context.Productos where s.HayStock == true select s.CantidadDisponible).ToList();

            for (int i = 0; i < precio.Count; i++)
            {
                double p = precio[i];
                double c = cantidades[i];
                total += p * c;
            }

            return total;
        }

        private List<string> Tipos()
        {
            return (from n in _context.ConfiguracionTipos select n.Tipos).ToList();
        }

        private List<double> AlertaStock()
        {
            return (from n in _context.ConfiguracionAlertaStock select n.Valor).ToList();
        }


    }
}
