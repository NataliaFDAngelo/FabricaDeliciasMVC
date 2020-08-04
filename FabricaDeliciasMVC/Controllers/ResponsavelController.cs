using FabricaDeliciasMVC.DataContext;
using FabricaDeliciasMVC.Helpers;
using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            Responsavel responsavel = db.Responsaveis.Find(id);

            if(responsavel.IdResponsavel == null)
            {
                return HttpNotFound();
            }

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
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, Responsavel responsaveis)
        {
            try
            {
                Responsavel responsavel = db.Responsaveis.Find(id);
                db.Responsaveis.Attach(responsavel);
                db.Responsaveis.Remove(responsavel);
                db.SaveChanges();

                return Content("Responsável removida com sucesso");
            }
            catch
            {
                return View();
            }
        }
    }
}
