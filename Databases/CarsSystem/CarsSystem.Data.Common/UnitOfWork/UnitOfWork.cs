using System;
using System.Data.Entity;
using CarsSystem.Data.Common.UnitOfWork.Contracts;

namespace CarsSystem.Data.Common.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext context;

        public UnitOfWork(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
