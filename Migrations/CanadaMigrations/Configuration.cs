namespace CanadaLab.Migrations.CanadaMigrations
{
    using Models.Canada;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CanadaLab.Data.CanadaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\CanadaMigrations";
        }

        protected override void Seed(CanadaLab.Data.CanadaContext context)
        {
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
            context.Provinces.AddOrUpdate(
            new Province() { ProvinceCode = "BC", ProvinceName = "British Columbia" },
                  new Province() { ProvinceCode = "QC", ProvinceName = "Quebec" },
                  new Province() { ProvinceCode = "NO", ProvinceName = "Ontario" }
            );

            context.Cities.AddOrUpdate(
                  //NO
                  new City()
                  {
                      CityName = "Toronto",
                      Popuation = 5132794,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "Ontario"),
                      //"NO",
                  },
                  new City()
                  {
                      CityName = "Ottawa",
                      Popuation = 697267,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "Ontario"),
                  },
                  new City()
                  {
                      CityName = "Hamilton",
                      Popuation = 670580,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "Ontario"),
                  },

                  //BC
                  new City()
                  {
                      CityName = "Vancouver",
                      Popuation = 2135201,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "British Columbia"),
                  },
                  new City()
                  {
                      CityName = "Victoria",
                      Popuation = 316327,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "British Columbia"),
                  },
                  new City()
                  {
                      CityName = "Nanaimo",
                      Popuation = 88799,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "British Columbia"),
                  },

                  //QC
                  new City()
                  {
                      CityName = "Montreal",
                      Popuation = 3260508,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "Quebec"),
                  },
                  new City()
                  {
                      CityName = "Quebec",
                      Popuation = 696946,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "Quebec"),
                  },
                  new City()
                  {
                      CityName = "Sherbrooke",
                      Popuation = 140628,
                      Province = context.Provinces.FirstOrDefault(h => h.ProvinceName == "Quebec"),
                  }
            );
        }
    }
}
