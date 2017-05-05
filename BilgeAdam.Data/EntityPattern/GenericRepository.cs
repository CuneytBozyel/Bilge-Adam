using BilgeAdam.Data.Entitiy;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BilgeAdam.Data.EntityPattern
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private BilgeAdamEntities _dataContext;

        private DbSet<T> _dbSet;

        public GenericRepository(BilgeAdamEntities dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<T>();
        }

        public void Edit(T entity)
        {
            _dbSet.Attach(entity);
            _dataContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public T Find(object entityId)
        {
            return _dbSet.Find(entityId);
        }

        public T Add(T entity)
        {
            return _dbSet.Add(entity);
        }

        public IQueryable<T> List(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
                return _dbSet.Where(filter);

            return _dbSet;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
                return _dbSet.Where(filter);

            return _dbSet;
        }
        public void Remove(T entity)
        {
            if (_dataContext.Entry(entity).State == System.Data.Entity.EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public void Remove(object entityId)
        {
            T entityToDelete = _dbSet.Find(entityId);
            Remove(entityToDelete);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            if (!entities.Any()) return;

            foreach (var entity in entities)
                Remove(entity);

        }

        public bool Any(Expression<Func<T, bool>> filter = null)
        {
            return _dbSet.Any(filter);
        }
    }
}
