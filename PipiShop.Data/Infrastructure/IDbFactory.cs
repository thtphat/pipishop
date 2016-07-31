using System;

namespace PipiShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PipiShopDbContext Init();
    }
}