using System.Web.Mvc;
using BL;
using Entities;


namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    [Authorize]
    public class LogsController : Controller
    {
        LogManager manager = new LogManager();
        // GET: Admin/Logs
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/Logs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Logs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Logs/Create
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

        // GET: Admin/Logs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Logs/Edit/5
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

        // GET: Admin/Logs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Logs/Delete/5
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
