using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using System.Data.Entity;


namespace WebApp.Controllers
{
    public class CursosController : Controller
    {
        // GET: Cursos
        public ActionResult Index()
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Cursos.ToList());
            }
            
        }

        // GET: Cursos/Details/5
        public ActionResult Details(int id)
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Cursos.Where(x => x.id == id));
            }
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {                     
               return View();          
        }

        // POST: Cursos/Create
        [HttpPost]
        public ActionResult Create(Cursos cursos)
        {
            try
            {
                using (DBMODELS context = new DBMODELS())
                {
                    context.Cursos.Add(cursos);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Cursos.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Cursos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cursos cursos)
        {
            try
            {
                using (DBMODELS context = new DBMODELS())
                {
                    context.Entry(cursos).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Cursos.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Cursos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBMODELS context = new DBMODELS())
                {
                    Cursos cursos = context.Cursos.Where(x => x.id == id).FirstOrDefault();
                    context.Cursos.Remove(cursos);
                    context.SaveChanges();
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
