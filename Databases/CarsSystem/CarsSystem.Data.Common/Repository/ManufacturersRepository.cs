using System.Data.Entity;
using CarsSystem.Data.Common.Repository.Base;
using CatsSystem.Models;

namespace CarsSystem.Data.Common.Repository
{
    public class ManufacturersRepository : GenericRepository<Manufacturer>
    {
        public ManufacturersRepository(DbContext context)
            : base(context)
        {
        }
    }
}
