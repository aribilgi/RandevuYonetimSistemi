using System;
using System.Web.Mvc;
using BL;
using Entities;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    public class RandevularController : Controller
    {
        RandevuManager manager = new RandevuManager();
        LogManager logManager = new LogManager();
        DoktorManager doktorManager = new DoktorManager();
        HastaManager hastaManager = new HastaManager();
        KullaniciManager kullaniciManager = new KullaniciManager();

        // GET: Admin/Randevular
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Randevular/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Randevular/Create
        public ActionResult Create()
        {
            ViewBag.KullaniciId = new SelectList(kullaniciManager.GetAll(), "Id", "Adi");
            ViewBag.HastaId = new SelectList(hastaManager.GetAll(), "Id", "Adi");
            ViewBag.DoktorId = new SelectList(doktorManager.GetAll(), "Id", "Adi"); // Ön yüz view sayfasındaki dropdown list e bu şekilde ViewBag ile veri gönderiyoruz
            return View();
        }

        // POST: Admin/Randevular/Create
        [HttpPost]
        public ActionResult Create(Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    manager.Add(randevu);
                    return RedirectToAction("Index");
                }
                catch (Exception hata)
                {
                    logManager.Add(new Log
                    {
                        CreateDate = DateTime.Now,
                        Error = hata.Message,
                        HataBilgi = "Admin Randevu Create"
                    });
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.KullaniciId = new SelectList(kullaniciManager.GetAll(), "Id", "Adi");
            ViewBag.HastaId = new SelectList(hastaManager.GetAll(), "Id", "Adi");
            ViewBag.DoktorId = new SelectList(doktorManager.GetAll(), "Id", "Adi");
            return View(randevu);
        }

        // GET: Admin/Randevular/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.KullaniciId = new SelectList(kullaniciManager.GetAll(), "Id", "Adi");
            ViewBag.HastaId = new SelectList(hastaManager.GetAll(), "Id", "Adi");
            ViewBag.DoktorId = new SelectList(doktorManager.GetAll(), "Id", "Adi");
            return View(manager.Find(id));
        }

        // POST: Admin/Randevular/Edit/5
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

        // GET: Admin/Randevular/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Randevular/Delete/5
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
