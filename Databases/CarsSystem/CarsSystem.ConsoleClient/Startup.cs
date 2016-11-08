using System;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Reflection;
using CarsSystem.Data.Common.Repository;
using CatsSystem.Models;
using Ninject;

namespace CarsSystem.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var ct = kernel.Get<CitiesRepository>();

            try
            {
                using (var unitOfWork = ct.unitOfWork())
                {
                    ct.cities.Add(new City()
                    {
                        Name = "asdfgh"
                    });

                    //unitOfWork.Commit();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                
                    }
                }
            }              
        }
    }
}
