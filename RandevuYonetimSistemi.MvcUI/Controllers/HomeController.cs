using BL;
using Entities;
using System;
using System.Web.Mvc;

namespace RandevuYonetimSistemi.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        ContactManager contactManager = new ContactManager();
        HastaManager hastaManager = new HastaManager();
        LogManager logManager = new LogManager();
        PageManager pageManager = new PageManager();

        public ActionResult Index()
        {
            ViewBag.Title = "Ana Sayfa";

            return View();
        }

        [Route("iletisim")] // adres çubuğundan iletisim yazılınca home/contactus sayfasını çalıştır
        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost, Route("iletisim")]
        public ActionResult ContactUs(Contact contact)
        {
            if (ModelState.IsValid) // Eğer model property kuralları geçerliyse(boş geçilemez vb)
            {
                contact.CreateDate = DateTime.Now;
                var sonuc = contactManager.Add(contact); // Sayfa ön yüzünden gönderilen içi dolu model nesnemizi add metoduna gönderdik
                try
                {
                    if (sonuc > 0)
                    {
                        TempData["Mesaj"] = @"<div class='alert alert-success'>
                        Teşekkürler. Mesajınız Bize Ulaşmıştır!</div>";
                        return RedirectToAction("ContactUs");
                    }
                    else TempData["Mesaj"] = @"<div class='alert alert-info'>
                        İşlem Başarısız. Mesajınız Gönderilemedi!</div>";
                }
                catch (Exception)
                {
                    TempData["Mesaj"] = @"<div class='alert alert-info'>
                        Hata Oluştu. Mesajınız Gönderilemedi!</div>";
                }
            }
            return View(contact);
        }

        [Route("SignIn")]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost, Route("SignIn")]
        public ActionResult SignIn(string email, string password)
        {
            var kayit = hastaManager.Get(h => h.Email == email && h.Password == password);
            if (kayit != null) // eğer bilgileri girilen hasta kayıtlıysa
            {
                // Giriş başarılı
            }
            else TempData["Mesaj"] = "<div class='alert alert-danger'>Giriş Başarısız! Kullanıcı Bulunamadı!</div>";
            return View();
        }

        [Route("SignUp")]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost, Route("SignUp")]
        public ActionResult SignUp(Hasta hasta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var sonuc = hastaManager.Add(hasta);
                    if (sonuc > 0)
                    {
                        TempData["Mesaj"] = "<h3>Teşekkürler..</h3><div class='alert alert-success'>Kaydınız Başarıyla Tamamlanmıştır.</div>";
                        return RedirectToAction("SignUp");
                    }
                }
                catch (Exception hata)
                {
                    TempData["Mesaj"] = "<h3>Hata Oluştu..</h3><div class='alert alert-danger'>Kaydınız Tamamlanamadı!</div>";
                    logManager.Add(new Log
                    {
                        CreateDate = DateTime.Now,
                        Error = hata.Message,
                        HataBilgi = "Hasta kayıt formu, Önyüz Ekle metodu"
                    });
                }
            }
            return View(hasta);
        }

        public ActionResult _PartialMenu()
        {
            return PartialView(pageManager.GetAll(p => p.IsActive == true & p.IsTopMenu == true)); // Geriye partial view dön
        }
        public ActionResult Page(int id)
        {
            return View(pageManager.Find(id));
        }
    }
}
