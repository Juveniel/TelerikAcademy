using System.Data.Entity;
using CarsSystem.Data.Migrations;
using CatsSystem.Models;

namespace CarsSystem.Data
{
    public class CarsSystemDbContext : DbContext
    {
        public CarsSystemDbContext() 
            :base("CarsSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsSystemDbContext, Configuration>());
        }

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<Dealer> Dealers { get; set; }

        public virtual IDbSet<Manufacturer> Manufacturers { get; set; }

        public virtual IDbSet<City> Cities { get; set; }
    }
}
