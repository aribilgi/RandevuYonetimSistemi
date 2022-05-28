namespace DAL.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "DatabaseContext";
        }

        protected override void Seed(DatabaseContext context)
        {
            if (!context.Kullanicilar.Any()) // Eðer veritabanýnda hiç kullanýcý yoksa
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
