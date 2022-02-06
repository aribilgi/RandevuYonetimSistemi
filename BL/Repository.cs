using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new() //  where T : class, IEntity, new() nin anlamı > Bu repository e gelecek olan T nesnesi bir class olmalı, Ientity ile işaretlediğimiz interface ten kalıtım almalı ve new lenebilir bir class olmalı yani string olmamalı!
    {
        DatabaseContext context;
        DbSet<T> _objectSet;
        public Repository()
        {
            if (context == null) // Eğer context nesnemiz boşsa
            {
                context = new DatabaseContext(); // yeni bir DatabaseContext nesnesi oluştur
                _objectSet = context.Set<T>(); // _objectSet i de bu contexte gelen classa ayarla
            }
        }
        public int Add(T entity)
        {
            _objectSet.Add(entity);
            return SaveChanges();
        }

        public int Delete(T entity)
        {
            _objectSet.Remove(entity);
            return SaveChanges();
        }

        public T Find(int id)
        {
            return _objectSet.Find(id);
        }

        public T Get()
        {
            return _objectSet.FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public int Update(T entity)
        {
            _objectSet.AddOrUpdate(entity);
            return SaveChanges();
        }
    }
}
