using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace DidoStore.Data.Repositories
{

    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByAlias(string alias);

        IEnumerable<Product> GetAllByBranch(int branchId, int pageIndex, int pageSize, out int totalRow);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {

        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Product> GetAllByBranch(int branchId, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Products
                        join br in DbContext.Branches
                        on p.BranchId equals br.Id
                        where br.Id == branchId && p.Status
                        orderby p.CreatedDate descending
                        select p;

            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }

        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.Products.Where(x => x.Alias == alias);
        }
    }
}
