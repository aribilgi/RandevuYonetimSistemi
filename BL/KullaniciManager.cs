using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KullaniciManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<Kullanici> GetAll()
        {
            return context.Kullanicilar.ToList();
        }
        public Kullanici Find(int id)
        {
            return context.Kullanicilar.Find(id); // find metodu geriye parametreden aldığı id ye sahip 
        }
        public int Add(Kullanici kullanici)
        {
            context.Kullanicilar.Add(kullanici);
            return context.SaveChanges(); // geriye etkilenen kayıt sayısını döner
        }
        public int Update(Kullanici kullanici)
        {
            context.Kullanicilar.AddOrUpdate(kullanici);
            return context.SaveChanges(); // geriye etkilenen kayıt sayısını döner
        }
        public int Delete(Kullanici kullanici)
        {
            context.Kullanicilar.Remove(kullanici);
            return context.SaveChanges(); // geriye etkilenen kayıt sayısını döner
        }
    }
}
