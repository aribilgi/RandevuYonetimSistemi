using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandevuYonetimSistemi.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        ContactManager contactManager = new ContactManager();
        public ActionResult Index()
        {
            ViewBag.Title = "Ana Sayfa";

            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(Contact contact)
        {
            return View();
        }
    }
}
