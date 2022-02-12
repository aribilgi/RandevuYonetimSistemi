namespace DAL.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DAL.DatabaseContext";
        }

        protected override void Seed(DAL.DatabaseContext context)
        {
            if (!context.Kullanicilar.Any()) // E�er veritaban�nda hi� kullan�c� yoksa
            {
                Kullanici kullanici = new Kullanici()
                {
                    Adi = "Admin",
                    Soyadi = "User",
                    Durum = true,
                    KayitTarihi = DateTime.Now,
                    KullaniciAdi = "admin",
                    Sifre = "Admin123"
                };
                context.Kullanicilar.Add(kullanici);
                context.SaveChanges();
            }
        }
    }
}
