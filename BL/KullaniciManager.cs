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
        public Kullanici Get(string kullaniciAdi, string sifre)
        {
            return context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi & k.Sifre == sifre); // FirstOrDefault metodu geriye parametreden aldığı kullaniciAdi ve sifre ile eşleşen kaydı döndürür, bulamazsa null döner
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
