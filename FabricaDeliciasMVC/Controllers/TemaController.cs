﻿using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabricaDeliciasMVC.Controllers
{
    public class TemaController : Controller
    {
        // GET: Tema
        public ActionResult Index()
        {
            List<Tema> Temas = new List<Tema>();
            Temas.Add(new Tema()
            {
                IdTema = 1,
                Nome = "Dinossauro"
            });
            Temas.Add(new Tema()
            {
                IdTema = 2,
                Nome = "Moana"
            });
            return View(Temas);
        }

        // GET: Tema/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tema/Create
        public ActionResult Create()
        { 
            return View();
        }

        // POST: Tema/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tema/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tema/Edit/5
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
