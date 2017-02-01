using CanadaLab.Models.Canada;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanadaLab.Data
{
    public class CanadaContext : DbContext
    {
        public CanadaContext()
            : base("DefaultConnection")
        { }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}