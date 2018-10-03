using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;

namespace DidoStore.Data.Repositories
{

    public interface IOrderRepository : IRepository<Order>
    {

    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
