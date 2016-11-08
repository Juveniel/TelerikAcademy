using System.Data.Entity;
using CarsSystem.Data.Common.Repository.Base;
using CatsSystem.Models;

namespace CarsSystem.Data.Common.Repository
{
    public class CarsRepository : GenericRepository<Car>
    {
        public CarsRepository(DbContext context)
            : base(context)
        {
        }
    }
}
