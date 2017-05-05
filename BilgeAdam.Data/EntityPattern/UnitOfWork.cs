using BilgeAdam.Data.Entitiy;
using System;

namespace BilgeAdam.Data.EntityPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private BilgeAdamEntities _dataContext;
        public UnitOfWork(BilgeAdamEntities dataContext)
        {
            if (dataContext == null)
                throw new ArgumentNullException();

            _dataContext = dataContext;
        }
        public UnitOfWork()
            : this(new BilgeAdamEntities())
        {

        }
        public IGenericRepository<T> Repository<T>() where T : class
        {
            return new GenericRepository<T>(_dataContext);
        }
        public int SaveChange()
        {
            try
            {
                return _dataContext.SaveChanges();
            }
            catch (Exception)
            {
                //TODO : Logging metodu eklenir. 
                throw;
            }
        }
    }
}
