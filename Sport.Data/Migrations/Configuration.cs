namespace Sport.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sport.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sport.Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            Manufacturer[] manufacturers = {

                new Manufacturer { id =1, Name = "Andrew Peters", Country="RF" },
                new Manufacturer { id =2, Name = "Brice Lambson", Country = "USA" },
                new Manufacturer { id =3, Name = "Rowan Miller", Country = "RF"}
            };

            context.Manufacturers.AddOrUpdate(
              p => new { p.id, p.Name, p.Country }, manufacturers);
             
           
            context.SaveChanges();
            //
        }
    }
}
