using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsSystem.Data.Common.Repository.Contracts;
using CatsSystem.Models;

namespace CarsSystem.Data.Common
{
    public class CarsDataProvider
    {
        private IRepository<Car> cars;

        public CarsDataProvider(IRepository<Car> cars)
        {
            this.cars = cars;
        }
    }
}
