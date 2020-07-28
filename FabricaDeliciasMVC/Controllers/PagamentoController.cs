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
    public class PagamentoController : Controller
    {
        private FabricaDeliciasDB db = new FabricaDeliciasDB();

        // GET: Pagamento
        public ActionResult Index()
        {
            List<Pagamento> lPagamentos = new List<Pagamento>();
            lPagamentos = db.Pagamentos.ToList();

            return View(lPagamentos);
        }

        // GET: Pagamento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pagamento/Create
        public ActionResult Create()
        {
            @ViewBag.Pagamentos = RetornaSelecListItem.Pagamentos();

            return View();
        }

        // POST: Pagamento/Create
        [HttpPost]
        public ActionResult Create(Pagamento pagamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Pagamentos.Add(pagamento);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

                @ViewBag.Pagamentos = RetornaSelecListItem.Pagamentos();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pagamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pagamento/Edit/5
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

        // GET: Pagamento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pagamento/Delete/5
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
