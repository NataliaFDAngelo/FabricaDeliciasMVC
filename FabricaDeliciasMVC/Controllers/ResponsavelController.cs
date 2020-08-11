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
    public class ResponsavelController : Controller
    {
        private FabricaDeliciasDB db = new FabricaDeliciasDB();

        // GET: Responsavel
        public ActionResult Index()
        {
            List<Responsavel> lResponsaveis = new List<Responsavel>();
            lResponsaveis = db.Responsaveis.ToList();

            return View(lResponsaveis);
        }

        // GET: Responsavel/Create
        public ActionResult Create()
        {
            @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();

            return View();
        }

        // POST: Responsavel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Responsavel responsavel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Responsaveis.Add(responsavel);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

                @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Responsavel/Edit/5
        public ActionResult Edit(int id)
        {
            if (id.Equals(0))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Responsavel responsavel = db.Responsaveis.Find(id);

            @ViewBag.Temas = RetornaSelecListItem.Responsaveis();

            return View(responsavel);
        }

        // POST: Responsavel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Responsavel responsavel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(responsavel).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(responsavel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Responsavel/Delete/5
        public ActionResult Delete(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Responsavel responsavel = db.Responsaveis.Find(id);
                
                db.Responsaveis.Remove(responsavel);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
