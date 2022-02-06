using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovainfJCB.Models;
using CovainfJCB.Data;

namespace CovainfJCB.Controllers
{
    public class InfantesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public InfantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InfantesController
        public ActionResult Index()
        {
            IEnumerable<Infante> listInfantes = _context.Infantes;
            return View(listInfantes);
        }

        // GET: InfantesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<  CREAR >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        
        // GET: InfantesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfantesController/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Infante infante )  // IFormCollection collection
        {
            if (ModelState.IsValid)
            {
                _context.Infantes.Add(infante);
                _context.SaveChanges();
            }
            return View(infante);

            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }


        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<  EDITAR >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
       
        // GET: InfantesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InfantesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InfantesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InfantesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
