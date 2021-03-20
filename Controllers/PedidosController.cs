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
    public class PedidosController : Controller
    {
        private readonly ADDBContext _context;
        private List<ProductosVendidos> lista;

        public PedidosController(ADDBContext context)
        {
            _context = context;
            lista = new List<ProductosVendidos>();
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pedidos.ToListAsync());
        }

        public IActionResult Cerrar(int? id)
        {

            Pedidos pedido = _context.Pedidos.Find(id);

            pedido.EstaEntregado = true;
            pedido.EstaPago = true;
            pedido.PedidoCerrado = true;
            _context.Update(pedido);
            _context.SaveChangesAsync();

            return RedirectToAction("Pendientes", "Pedidos");
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }         

            var pedidos = await _context.Pedidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return View(pedidos);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewBag.MyListClientes = ListarClientes();
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cliente,Fecha,EstaEntregado,EstaPago,PedidoCerrado,TotalCobrado")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                if (pedidos.EstaPago && pedidos.EstaEntregado)
                {
                    pedidos.PedidoCerrado = true;
                }
                else
                {
                    pedidos.PedidoCerrado = false;
                }
                _context.Add(pedidos);
                await _context.SaveChangesAsync();              
                foreach (ProductosVendidos item in lista)
                {
                    _context.ProductosVendidos.Add(item);
                    _context.SaveChanges();
                }
                return RedirectToAction("Create","ProductosVendidos");
            }
            return View(pedidos);
        }

        public IActionResult Productos(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = (from s in _context.ProductosVendidos where s.IdPedido == id select s);

            if (productos == null)
            {
                return NotFound();
            }
            return View(productos);
        }


        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos.FindAsync(id);
            if (pedidos == null)
            {
                return NotFound();
            }
            return View(pedidos);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Fecha,EstaEntregado,EstaPago,PedidoCerrado,TotalCobrado")] Pedidos pedidos)
        {
            if (id != pedidos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid )
            {
                try
                {
                    if (pedidos.EstaPago && pedidos.EstaEntregado)
                    {
                        pedidos.PedidoCerrado = true;
                    }
                    else
                    {
                        pedidos.PedidoCerrado = false;
                    }
                    _context.Update(pedidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidosExists(pedidos.Id))
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
            return View(pedidos);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return View(pedidos);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidos = await _context.Pedidos.FindAsync(id);
            _context.Pedidos.Remove(pedidos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Pendientes()
        {
            var pendientes = (from n in _context.Pedidos where n.PedidoCerrado == false select n).ToList();

            return View(pendientes);
        }

        private bool PedidosExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
        }

        private List<String> ListarProductos()
        {
            return (from s in _context.Productos where s.HayStock == true select s.Producto).ToList();
        }

        private List<String> ListarClientes()
        {
            return (from s in _context.Clientes select s.Nombre).ToList();
        }
        
        
     

    }
}
