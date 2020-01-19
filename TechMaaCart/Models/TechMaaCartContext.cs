using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TechMaaCart.Models
{
    public class TechMaaCartContext : DbContext
    {

        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TechMaaCartContext() : base("name=MaaCartContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TechMaaCartContext, TechMaaCart.Migrations.Configuration>());
            Database.SetInitializer<TechMaaCartContext>(new CreateDatabaseIfNotExists<TechMaaCartContext>());
 
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());

        }

        public System.Data.Entity.DbSet<TechMaaCart.Models.Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<TechMaaCart.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<TechMaaCart.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<TechMaaCart.Models.OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
