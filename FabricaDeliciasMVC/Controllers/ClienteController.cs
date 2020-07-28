using FabricaDeliciasMVC.DataContext;
using FabricaDeliciasMVC.Helpers;
using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FabricaDeliciasMVC.Controllers
{
    public class ClienteController : Controller
    {
        private FabricaDeliciasDB db = new FabricaDeliciasDB();

        // GET: Cliente
        public ActionResult Index()
        {
            List<Cliente> lClientes = new List<Cliente>();
            lClientes = db.Clientes.ToList();

            return View(lClientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            @ViewBag.Responsaveis = RetornaSelecListItem.Responsaveis();

            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Clientes.Add(cliente);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

                @ViewBag.Clientes = RetornaSelecListItem.Clientes();

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
