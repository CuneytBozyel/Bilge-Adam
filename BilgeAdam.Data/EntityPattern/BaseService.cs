namespace BilgeAdam.Data.EntityPattern
{
    public abstract class BaseService<T> where T : class
    {
        protected IUnitOfWork Uow { get; private set; }
        protected IGenericRepository<T> Repo { get; private set; }

        private BaseService(IUnitOfWork unitOfWork)
        {
            Uow = unitOfWork;
            Repo = unitOfWork.Repository<T>();
        }
        protected BaseService()
            : this(new UnitOfWork())
        {

        }
    }
}
