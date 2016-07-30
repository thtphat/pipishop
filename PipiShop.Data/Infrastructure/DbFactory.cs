namespace PipiShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PipiShopDbContext dbContext;

        public PipiShopDbContext Init()
        {
            return dbContext ?? (dbContext = new PipiShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}