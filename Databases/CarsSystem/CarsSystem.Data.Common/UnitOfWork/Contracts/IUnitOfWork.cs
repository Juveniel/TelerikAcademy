using System;

namespace CarsSystem.Data.Common.UnitOfWork.Contracts
{ 
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}