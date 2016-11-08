using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarsSystem.Data.Common.Repository.Contracts;

namespace CarsSystem.Data.Common.Repository.Base
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        private readonly IDbSet<TEntity> dbSet;

        public GenericRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }               

        ICollection<TEntity> IRepository<TEntity>.GetAll()
        {
            var entitySet = this.GetDbSet();
            var allItems = entitySet.ToList();

            return allItems;
        }

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var entitySet = this.GetDbSet();
            entitySet.Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            var entitySet = this.GetDbSet();
            TEntity entityToDelete = entitySet.Find(id);
            Delete(entityToDelete);
        }

        TEntity IRepository<TEntity>.GetById(object id)
        {
            var entitySet = this.GetDbSet();
            var item = entitySet.Find(id);

            return item;
        }

        private DbSet<TEntity> GetDbSet()
        {
            var set = this.context.Set<TEntity>();
            return set;
        }
    }
}
