namespace PipiShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}