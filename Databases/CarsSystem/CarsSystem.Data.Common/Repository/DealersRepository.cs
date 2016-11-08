using System.Data.Entity;
using CarsSystem.Data.Common.Repository.Base;
using CatsSystem.Models;

namespace CarsSystem.Data.Common.Repository
{
    public class DealersRepository : GenericRepository<Dealer>
    {
        public DealersRepository(DbContext context)
            : base(context)
        {
        }
    }
}
