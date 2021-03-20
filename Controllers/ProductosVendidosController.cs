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
    public class ProductosVendidosController : Controller
    {
        private readonly ADDBContext _context;

        public ProductosVendidosController(ADDBContext context)
        {
            _context = context;
        }

        // GET: ProductosVendidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductosVendidos.ToListAsync());
        }

        // GET: ProductosVendidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productosVendidos = await _context.ProductosVendidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productosVendidos == null)
            {
                return NotFound();
            }

            return View(productosVendidos);
        }

        // GET: ProductosVendidos/Create
        public IActionResult Create()
        {
            ViewBag.idPedido = UltimoId();
            ViewBag.MyList = ListarProductos();
            return View();
        }

        // POST: ProductosVendidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Producto,Cantidad")] ProductosVendidos productosVendidos)
        {
            if (ModelState.IsValid)
            {
                if (CantidadDisponible(productosVendidos.Producto)[0] >= productosVendidos.Cantidad) { 
                    productosVendidos.IdPedido = UltimoId();
                    _context.Add(productosVendidos);
                    RestarStock(productosVendidos.Producto, productosVendidos.Cantidad);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    return RedirectToAction(nameof(Create));
                }
            }
            return View(productosVendidos);
        }

        public IActionResult IndexPedidos()
        {
            return RedirectToAction("Index", "Pedidos");
        }

        // GET: ProductosVendidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productosVendidos = await _context.ProductosVendidos.FindAsync(id);
            if (productosVendidos == null)
            {
                return NotFound();
            }
            return View(productosVendidos);
        }

        // POST: ProductosVendidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPedido,Producto,Cantidad")] ProductosVendidos productosVendidos)
        {
            if (id != productosVendidos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productosVendidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductosVendidosExists(productosVendidos.Id))
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
            return View(productosVendidos);
        }

        // GET: ProductosVendidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productosVendidos = await _context.ProductosVendidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productosVendidos == null)
            {
                return NotFound();
            }

            return View(productosVendidos);
        }

        // POST: ProductosVendidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productosVendidos = await _context.ProductosVendidos.FindAsync(id);
            _context.ProductosVendidos.Remove(productosVendidos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductosVendidosExists(int id)
        {
            return _context.ProductosVendidos.Any(e => e.Id == id);
        }

        private List<String> ListarProductos()
        {
            return (from s in _context.Productos where s.HayStock == true select s.Producto).ToList();
        }

        private int UltimoId()
        {
            return (_context.Pedidos.Last().Id);
        }

        private List<Double> CantidadDisponible(string producto)
        {
            return (from s in _context.Productos where s.Producto == producto select s.CantidadDisponible).ToList();

        }

        private void RestarStock(string Producto, double Cantidad)
        {
            var listaProductos = _context.Productos.ToList<Productos>();

            double nuevaCantidad = CantidadDisponible(Producto)[0] - Cantidad;

            Productos ProductoActualizado = listaProductos.Where(s =>s.Producto == Producto).FirstOrDefault<Productos>();
            ProductoActualizado.CantidadDisponible = nuevaCantidad;

            if (nuevaCantidad == 0)
            {
                ProductoActualizado.HayStock = false;
            }
            _context.SaveChanges();
        }

    }
}
