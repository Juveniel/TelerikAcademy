using CarsSystem.Data.Common.Repository.Contracts;
using CatsSystem.Models;
using CarsSystem.Data.Common.UnitOfWork.Contracts;
using System;

namespace CarsSystem.Data.Common.Repository
{
    public class CitiesRepository
    {
        public IRepository<City> cities;
        public Func<IUnitOfWork> unitOfWork;
    
        public CitiesRepository(Func<IUnitOfWork> unitOfWork, IRepository<City> cities)
        {
            this.unitOfWork = unitOfWork;
            this.cities = cities;
        }
    }
}
