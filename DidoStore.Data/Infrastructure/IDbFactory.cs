using System;

namespace DidoStore.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DidoStoreDbContext Init();
    }
}
