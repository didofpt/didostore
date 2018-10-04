namespace DidoStore.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {

        private DidoStoreDbContext dbContext;

        public DidoStoreDbContext Init()
        {
            return dbContext ?? (dbContext = new DidoStoreDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
