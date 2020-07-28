using FabricaDeliciasMVC.DataContext;
using FabricaDeliciasMVC.Helpers;
using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
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

        // GET: Responsavel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Responsavel/Create
        public ActionResult Create()
        {
            @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();

            return View();
        }

        // POST: Responsavel/Create
        [HttpPost]
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
            return View();
        }

        // POST: Responsavel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
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

        // POST: Responsavel/Delete/5
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
