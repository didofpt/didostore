using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;

namespace DidoStore.Data.Repositories
{

    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {

    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
