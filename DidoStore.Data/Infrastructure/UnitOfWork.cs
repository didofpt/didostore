using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidoStore.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly IDbFactory dbFactory;

        private DidoStoreDbContext dbContext;

        public UnitOfWork (IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DidoStoreDbContext DbContext {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        
    }
}
