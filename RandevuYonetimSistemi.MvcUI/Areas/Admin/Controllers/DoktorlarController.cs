using System.Web.Mvc;
using Entities;
using BL;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    [Authorize]
    public class DoktorlarController : Controller
    {
        DoktorManager manager = new DoktorManager();
        // GET: Admin/Doktorlar
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Doktorlar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Doktorlar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Doktorlar/Create
        [HttpPost]
        public ActionResult Create(Doktor doktor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    manager.Add(doktor);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(doktor);
        }

        // GET: Admin/Doktorlar/Edit/5
        public ActionResult Edit(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Doktorlar/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Doktor doktor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    manager.Update(doktor);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(doktor);
        }

        // GET: Admin/Doktorlar/Delete/5
        public ActionResult Delete(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Doktorlar/Delete/5
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
