using TechMaaCart.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TechMaaCart.AllRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private TechMaaCartContext context;
        private DbSet<T> table=null;

        public Repository()
        {
            this.context = new TechMaaCartContext();
            this.table = context.Set<T>();
        }
        public Repository(TechMaaCartContext context, DbSet<T> table)
        {
            this.context = context;
            this.table = table;
        }
        public void delete(int model)
        {
           T id= table.Find(model);
            table.Remove(id);

        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int model)
        {
            return table.Find(model);
        }

        public void save()
        {
            context.SaveChanges();
        }

        public void updateModel(T Model)
        {
            table.Attach(Model);
            context.Entry(Model).State = EntityState.Modified;
        }
    }
}