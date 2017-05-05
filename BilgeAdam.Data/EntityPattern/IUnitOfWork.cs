namespace BilgeAdam.Data.EntityPattern
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : class;

        int SaveChange();

    }
}
