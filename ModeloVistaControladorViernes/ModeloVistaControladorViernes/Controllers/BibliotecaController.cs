using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModeloVistaControladorViernes.Models;

namespace ModeloVistaControladorViernes.Controllers
{
    
    
    public class BibliotecaController : Controller
    {   //Creamos la clase 
        static Biblioteca MyBiblioteca = new Biblioteca();

        // GET: Biblioteca
        public ActionResult Index()
        {
            return View(MyBiblioteca.Libros.ToList());
            
        }

        // GET: Biblioteca/Details/5
        public ActionResult Details(int id)
        {
            return View(MyBiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // GET: Biblioteca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                MyBiblioteca.Libros.Add(new Libro
                {
                    Isbn=(MyBiblioteca.Libros.Count()+1).ToString(),
                    Titulo=collection["Titulo"],
                    TipoLibro= collection["TipoLibro"],
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Edit/5
        public ActionResult Edit(int id)
        {
            return View(MyBiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {foreach (Libro l in MyBiblioteca.Libros)
            {
                if (l.Isbn == id.ToString())
                {
                    l.Titulo = collection["Titulo"];
                    l.TipoLibro = collection["TipoLibro"];
                }

            }
            return RedirectToAction("Index");
        }

        // GET: Biblioteca/Delete/5
        public ActionResult Delete(int id)
        {
            return View(MyBiblioteca.ObtenerPorIsbn(id.ToString()));
        }

        // POST: Biblioteca/Delete/5
        [HttpPost]
        public ActionResult Delete(int  id, FormCollection collection)
        {
            try
            {
               foreach (Libro l in MyBiblioteca.Libros)
                {
                    if (l.Isbn == id.ToString()) MyBiblioteca.Libros.Remove(l);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
