using Entities;
using System.Data.Entity;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DbInitializer()); // EF Database.SetInitializer metoduna kendi yaptýðýmýz DbInitializer sýnýfýný yolladýk
        }
        //DbSetler veritabaný tablolarýmýzý temsil eden yapýlardýr
        public virtual DbSet<Doktor> Doktorlar { get; set; }
        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Randevu> Randevular { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
    }
}