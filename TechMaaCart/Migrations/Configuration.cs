namespace TechMaaCart.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : CreateDatabaseIfNotExists<Models.TechMaaCartContext>//DbMigrationsConfiguration<TechMaaCart.Models.TechMaaCartContext>,
    {
        //public Configuration()
        //{
        //    AutomaticMigrationsEnabled = true;
        //    ContextKey = "TechMaaCart.Models.TechMaaCartContext";
        //    AutomaticMigrationDataLossAllowed = true;
        //}

        protected override void Seed(TechMaaCart.Models.TechMaaCartContext context)
        {
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
