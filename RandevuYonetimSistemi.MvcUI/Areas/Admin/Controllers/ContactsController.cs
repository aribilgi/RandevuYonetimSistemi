using System.Web.Mvc;
using BL;
using Entities;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    public class ContactsController : Controller
    {
        ContactManager manager = new ContactManager();

        // GET: Admin/Contacts
        public ActionResult Index()
        {
            return View(manager.GetAll()); // ön yüzdeki modele manager dan çektiğimiz veri listesini gönderiyoruz
        }

        // GET: Admin/Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contacts/Create
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

        // GET: Admin/Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contact contact)
        {
            if (ModelState.IsValid) // Eğer model kuralları geçerliyse
            {
                try
                {
                    // TODO: Add update logic here
                    manager.Update(contact); // parametreden gelen contact nesnesini güncelle
                    return RedirectToAction("Index"); // sayfayı index e yönlendir
                }
                catch // Eğer bir hata oluşursa
                {
                    ModelState.AddModelError("", "Hata Oluştu!"); // Ekrana mesaj yaz
                }
            }
            return View(contact); // Sayfadan gelen contact nesnesini sayfaya geri gönder
        }

        // GET: Admin/Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Contacts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var silinecekKayit = manager.Find(id); // parametreden gelen id ye ait kaydı db den buluyoruz
                manager.Delete(silinecekKayit); // bulduğumuz silinecek kaydı delete metoduna gönderip db den siliyoruz
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
