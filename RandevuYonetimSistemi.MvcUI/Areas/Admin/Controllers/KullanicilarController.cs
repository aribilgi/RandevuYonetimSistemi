using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BL;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    public class KullanicilarController : Controller
    {
        KullaniciManager manager = new KullaniciManager();
        // GET: Admin/Kullanicilar
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Kullanicilar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Kullanicilar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Kullanicilar/Create
        [HttpPost]
        public ActionResult Create(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    kullanici.KayitTarihi = DateTime.Now;
                    manager.Add(kullanici);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(kullanici);
        }

        // GET: Admin/Kullanicilar/Edit/5
        public ActionResult Edit(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Kullanicilar/Edit/5
        [HttpPost]
        public ActionResult Edit(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    manager.Update(kullanici);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(kullanici);
        }

        // GET: Admin/Kullanicilar/Delete/5
        public ActionResult Delete(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Kullanicilar/Delete/5
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
