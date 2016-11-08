using System.Data.Entity;
using CarsSystem.Data;
using CarsSystem.Data.Common.Repository.Base;
using CarsSystem.Data.Common.Repository.Contracts;
using CarsSystem.Data.Common.UnitOfWork;
using CarsSystem.Data.Common.UnitOfWork.Contracts;
using Ninject;
using Ninject.Modules;
using System;

namespace CarsSystem.ConsoleClient.NinjectConfiguration
{
    public class NinjectConfiguration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<CarsSystemDbContext>().InSingletonScope();
            this.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));   
            this.Bind<Func<IUnitOfWork>>().ToMethod(ctx => () => ctx.Kernel.Get<UnitOfWork>());    
            this.Bind<IUnitOfWork>().To<UnitOfWork>();            
        }
    }
}
