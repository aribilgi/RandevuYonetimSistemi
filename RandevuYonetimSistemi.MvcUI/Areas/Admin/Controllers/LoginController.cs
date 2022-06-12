using RandevuYonetimSistemi.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security; // Login işlemi için bu kütüphane kullanılıyor
using System.Web.Mvc;
using BL;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        LoginManager manager = new LoginManager();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdminLoginViewModel adminLoginViewModel, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var kullanici = manager.Get(u => u.KullaniciAdi == adminLoginViewModel.KullaniciAdi & u.Sifre == adminLoginViewModel.Sifre & u.Durum == true);
                if (kullanici != null) // eğer kullanıcı varsa
                {
                    FormsAuthentication.SetAuthCookie(kullanici.KullaniciAdi, true); // sisteme giriş yap
                    return ReturnUrl == null ? RedirectToAction("Index", "Default") : (ActionResult)Redirect(ReturnUrl);
                }
                else ModelState.AddModelError("", "Böyle Bir Kullanıcı Bulunamadı!");
            }
            return View(adminLoginViewModel);
        }
        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); // Oturumu kapat
            return RedirectToAction("Index","Login"); // kullanıcıyı login sayfasına yönlendir.
        }
    }
}