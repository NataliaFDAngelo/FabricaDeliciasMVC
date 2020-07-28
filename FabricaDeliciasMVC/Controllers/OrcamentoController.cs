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
    public class OrcamentoController : Controller
    {
        private FabricaDeliciasDB db = new FabricaDeliciasDB();
        // GET: Orcamento
        public ActionResult Index()
        {
            List<Orcamento> lOrcamentos = new List<Orcamento>();
            lOrcamentos = db.Orcamentos.ToList();

            return View(lOrcamentos);
        }

        // GET: Orcamento/Details/5
        public ActionResult Details()
        {
            List<Orcamento> orcamento = db.Orcamentos.ToList();
            return View(orcamento);
        }

        // GET: Orcamento/Create
        public ActionResult Create()
        {
            @ViewBag.Clientes = RetornaSelecListItem.Clientes();
            @ViewBag.Temas = RetornaSelecListItem.Temas();
            @ViewBag.Pagamentos = RetornaSelecListItem.Pagamentos();
            @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();

            return View();
        }

        // POST: Orcamento/Create
        [HttpPost]
        public ActionResult Create(Orcamento orcamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Orcamentos.Add(orcamento);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                @ViewBag.Clientes = RetornaSelecListItem.Clientes();
                @ViewBag.Temas = RetornaSelecListItem.Temas();
                @ViewBag.Pagamentos = RetornaSelecListItem.Pagamentos();
                @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Orcamento/Edit/5
        public ActionResult Edit(int id)
        {
            if(id.Equals(0))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Orcamento orcamento = db.Orcamentos.Find(id);

            @ViewBag.Clientes = RetornaSelecListItem.Clientes();
            @ViewBag.Temas = RetornaSelecListItem.Temas();
            @ViewBag.Pagamentos = RetornaSelecListItem.Pagamentos();
            @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();

            return View(orcamento);
        }

        // POST: Orcamento/Edit/5
        [HttpPost]
        public ActionResult Edit(Orcamento orcamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(orcamento).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                @ViewBag.Clientes = RetornaSelecListItem.Clientes();
                @ViewBag.Temas = RetornaSelecListItem.Temas();
                @ViewBag.Pagamentos = RetornaSelecListItem.Pagamentos();
                @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();
                
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Orcamento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orcamento/Delete/5
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
