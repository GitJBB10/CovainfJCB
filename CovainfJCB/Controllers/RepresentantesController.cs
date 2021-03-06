using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CovainfJCB.Data;
using CovainfJCB.Models;
using Microsoft.AspNetCore.Identity;
using CovainfJCB.Views.ViewModels;

namespace CovainfJCB.Controllers
{

    public class RepresentantesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public RepresentantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Representantes
        public async Task<IActionResult> Index()
        {
            var usuario = @User.Identity.Name;
            ModeloIndex mri = new ModeloIndex();
            mri.Representante = await _context.Representantes.FirstOrDefaultAsync(m => m.Correo == usuario);
            mri.ListInfante = await _context.Infantes.ToListAsync();

            return View(mri);
            
            //return View(await _context.Representantes.ToListAsync());
        }

        // GET: Representantes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var representante = await _context.Representantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (representante == null)
            {
                return NotFound();
            }

            return View(representante);
        }

        // GET: Representantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Representantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombres,Apellidos,FechaNacimiento,Correo,Celular,Direccion")] Representante representante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(representante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(representante);
        }

        // GET: Representantes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var representante = await _context.Representantes.FindAsync(id);
            if (representante == null)
            {
                return NotFound();
            }
            return View(representante);
        }

        // POST: Representantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nombres,Apellidos,FechaNacimiento,Correo,Celular,Direccion")] Representante representante)
        {
            if (id != representante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(representante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepresentanteExists(representante.Id))
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
            return View(representante);
        }

        // GET: Representantes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var representante = await _context.Representantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (representante == null)
            {
                return NotFound();
            }

            return View(representante);
        }

        // POST: Representantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var representante = await _context.Representantes.FindAsync(id);
            _context.Representantes.Remove(representante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepresentanteExists(string id)
        {
            return _context.Representantes.Any(e => e.Id == id);
        }

       
    }
}
