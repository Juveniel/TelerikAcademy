using System.Collections.Generic;

namespace CarsSystem.Data.Common.Repository.Contracts
{
    public interface IRepository<TEntity>
        where TEntity: class
    {
        ICollection<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(object id);

        TEntity GetById(object id);
    }
}