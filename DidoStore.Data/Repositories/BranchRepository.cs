using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidoStore.Data.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
        IEnumerable<Branch> GetByAlias(string alias);
    }

    public class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
        public BranchRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

        public IEnumerable<Branch> GetByAlias(string alias)
        {
            return this.DbContext.Branches.Where(i => i.Alias == alias);
        }
    }
}
