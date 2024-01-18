namespace FinalWebApi.Migrations
{
    using FinalWebApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalWebApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FinalWebApi.Models.ApplicationDbContext context)
        {
            Product p1 = new Product() { Name = "Samsung Monitor", Price = 3000 };
            Product p2 = new Product() { Name = "Sony Monitor", Price = 2000 };
            Product p3 = new Product() { Name = "Lg Monitor", Price = 1000 };

            context.Products.AddOrUpdate(x => x.Name, p1, p2, p3);
        }
    }
}
