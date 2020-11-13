using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;
using WebApplication1.context;

namespace WebApplication1.Controllers
{
    public class tiendaEmpleadosController : Controller
    {
        private readonly AppDBContext _context;

        public tiendaEmpleadosController(AppDBContext context)
        {
            _context = context;
        }

        // GET: tiendaEmpleados
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.tiendaEmpleados.Include(t => t.empleados).Include(t => t.tiendas);
            return View(await appDBContext.ToListAsync());
        }

        // GET: tiendaEmpleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiendaEmpleado = await _context.tiendaEmpleados
                .Include(t => t.empleados)
                .Include(t => t.tiendas)
                .FirstOrDefaultAsync(m => m.empleadoId == id);
            if (tiendaEmpleado == null)
            {
                return NotFound();
            }

            return View(tiendaEmpleado);
        }

        // GET: tiendaEmpleados/Create
        public IActionResult Create()
        {
            ViewData["empleadoId"] = new SelectList(_context.empleado, "empleadoId", "empleadoId");
            ViewData["tiendaId"] = new SelectList(_context.tienda, "tiendaId", "tiendaId");
            return View();
        }

        // POST: tiendaEmpleados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("empleadoId,tiendaId,fecha")] tiendaEmpleado tiendaEmpleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiendaEmpleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["empleadoId"] = new SelectList(_context.empleado, "empleadoId", "empleadoId", tiendaEmpleado.empleadoId);
            ViewData["tiendaId"] = new SelectList(_context.tienda, "tiendaId", "tiendaId", tiendaEmpleado.tiendaId);
            return View(tiendaEmpleado);
        }

        // GET: tiendaEmpleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiendaEmpleado = await _context.tiendaEmpleados.FindAsync(id);
            if (tiendaEmpleado == null)
            {
                return NotFound();
            }
            ViewData["empleadoId"] = new SelectList(_context.empleado, "empleadoId", "empleadoId", tiendaEmpleado.empleadoId);
            ViewData["tiendaId"] = new SelectList(_context.tienda, "tiendaId", "tiendaId", tiendaEmpleado.tiendaId);
            return View(tiendaEmpleado);
        }

        // POST: tiendaEmpleados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("empleadoId,tiendaId,fecha")] tiendaEmpleado tiendaEmpleado)
        {
            if (id != tiendaEmpleado.empleadoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiendaEmpleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tiendaEmpleadoExists(tiendaEmpleado.empleadoId))
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
            ViewData["empleadoId"] = new SelectList(_context.empleado, "empleadoId", "empleadoId", tiendaEmpleado.empleadoId);
            ViewData["tiendaId"] = new SelectList(_context.tienda, "tiendaId", "tiendaId", tiendaEmpleado.tiendaId);
            return View(tiendaEmpleado);
        }

        // GET: tiendaEmpleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiendaEmpleado = await _context.tiendaEmpleados
                .Include(t => t.empleados)
                .Include(t => t.tiendas)
                .FirstOrDefaultAsync(m => m.empleadoId == id);
            if (tiendaEmpleado == null)
            {
                return NotFound();
            }

            return View(tiendaEmpleado);
        }

        // POST: tiendaEmpleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tiendaEmpleado = await _context.tiendaEmpleados.FindAsync(id);
            _context.tiendaEmpleados.Remove(tiendaEmpleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tiendaEmpleadoExists(int id)
        {
            return _context.tiendaEmpleados.Any(e => e.empleadoId == id);
        }
    }
}
