using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Alumnos.ToList());
            };
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Alumnos.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {
                using (DBMODELS context = new DBMODELS())
                {
                    context.Alumnos.Add(alumnos);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Alumnos.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumnos alumnos)
        {
            try
            {
                using (DBMODELS context = new DBMODELS())
                {
                    context.Entry(alumnos).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBMODELS context = new DBMODELS())
            {
                return View(context.Alumnos.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBMODELS context = new DBMODELS())
                {
                    Alumnos Alumnos = context.Alumnos.Where(x => x.id == id).FirstOrDefault();
                    context.Alumnos.Remove(Alumnos);
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
