using System.Web;
using System.Web.Mvc;
using Entities;
using BL;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        PageManager manager = new PageManager();
        // GET: Admin/Pages
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Pages/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Pages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Pages/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Page page, HttpPostedFileBase Image) // Mvc resim yükleme için
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Image != null)
                    {
                        Image.SaveAs(Server.MapPath("/Images/" + Image.FileName)); // resmi sunucudaki Images klasörüne kaydet
                        page.Image = Image.FileName;
                    }
                    manager.Add(page);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(page);
        }

        // GET: Admin/Pages/Edit/5
        public ActionResult Edit(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Pages/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Page page, HttpPostedFileBase Image, bool cbResmiSil = false)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (cbResmiSil == true)
                    {
                        page.Image = string.Empty;
                    }
                    if (Image != null)
                    {
                        Image.SaveAs(Server.MapPath("/Images/" + Image.FileName)); // resmi sunucudaki Images klasörüne kaydet
                        page.Image = Image.FileName;
                    }
                    manager.Update(page);
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(page);
        }

        // GET: Admin/Pages/Delete/5
        public ActionResult Delete(int id)
        {
            return View(manager.Find(id));
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var kayit = manager.Find(id);
                manager.Delete(kayit);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
