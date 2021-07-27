using System.Security.Cryptography.X509Certificates;
using CrudNetCore5.Data;
using CrudNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Libro> ListLibros = _context.Libros; 
            return View(ListLibros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Libro libro)
        {
            if(ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();

                TempData["Mensaje"] = "El libro se creo correctamente";

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if( id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libros.Find(id);

            if(libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        [HttpPost]
        public IActionResult Edit(Libro libro)
        {
            if(ModelState.IsValid)
            {
                _context.Libros.Update(libro);
                _context.SaveChanges();
                TempData["Mensaje"] = "El libro se actualizo correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
          var libro = _context.Libros.Find(id);

          if(libro == null)
          {
              return NotFound();
          }

          _context.Libros.Remove(libro);
          _context.SaveChanges();

          TempData["Mensaje"] = "El libro fue eliminado";

          return RedirectToAction("Index");
        }

    }
}