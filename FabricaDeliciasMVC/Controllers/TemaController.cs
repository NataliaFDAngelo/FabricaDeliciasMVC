using FabricaDeliciasMVC.DataContext;
using FabricaDeliciasMVC.Helpers;
using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FabricaDeliciasMVC.Controllers
{
    public class TemaController : Controller
    {
        private FabricaDeliciasDB db = new FabricaDeliciasDB();
        // GET: Tema
        public ActionResult Index()
        {

            List<Tema> lTemas = new List<Tema>();
            lTemas = db.Temas.ToList();

            return View(lTemas);
        }

        // GET: Tema/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tema/Create
        public ActionResult Create()
        {
            @ViewBag.Temas = RetornaSelecListItem.Temas();

            return View();
        }

        // POST: Tema/Create
        [HttpPost]
        public ActionResult Create(Tema tema)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Temas.Add(tema);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

                @ViewBag.Temas = RetornaSelecListItem.Temas();

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Tema/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id.Equals(0))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Tema tema = db.Temas.Find(id);

            @ViewBag.Temas = RetornaSelecListItem.Temas();

            return View(tema);
        }

        // POST: Tema/Edit/5
        [HttpPost]
        public ActionResult Edit(Tema tema)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tema).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                @ViewBag.Temas = RetornaSelecListItem.Temas();

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Tema/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tema/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
