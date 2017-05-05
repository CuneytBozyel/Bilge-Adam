using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BilgeAdam.Data.EntityPattern
{
    public interface IGenericRepository<T> where T : class
    {
        T Find(object EntityId);

        IQueryable<T> List(Expression<Func<T, bool>> filter = null);

        IQueryable<T> Where(Expression<Func<T, bool>> filter = null);

        T Add(T Entity);

        void Edit(T Entity);

        void Remove(object EntityId);

        void Remove(T Entity);

        void RemoveRange(IEnumerable<T> entities);

        bool Any(Expression<Func<T, bool>> filter = null);

    }
}
