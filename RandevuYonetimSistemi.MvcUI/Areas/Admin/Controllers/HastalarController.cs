using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BL;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    public class HastalarController : Controller
    {
        HastaManager manager = new HastaManager();
        // GET: Admin/Hastalar
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Hastalar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Hastalar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Hastalar/Create
        [HttpPost]
        public ActionResult Create(Hasta hasta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    hasta.KayitTarihi = DateTime.Now;
                    manager.Add(hasta);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(hasta);
        }

        // GET: Admin/Hastalar/Edit/5
        public ActionResult Edit(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Hastalar/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Hasta hasta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    manager.Update(hasta);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(hasta);
        }

        // GET: Admin/Hastalar/Delete/5
        public ActionResult Delete(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Hastalar/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                manager.Delete(manager.Find(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
