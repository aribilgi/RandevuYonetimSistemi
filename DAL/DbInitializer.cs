using System;
using Entities;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    class DbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //Seed metodu ef code first ile veritabanı oluşturulduktan sonra çalışan bir metottur
            if (!context.Kullanicilar.Any()) // Eğer veritabanında hiç kullanıcı yoksa
            {
                Kullanici kullanici = new Kullanici()
                {
                    Adi = "Admin",
                    Durum = true,
                    KayitTarihi = DateTime.Now,
                    KullaniciAdi = "admin",
                    Sifre = "Admin123"
                };
                context.Kullanicilar.Add(kullanici);
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
