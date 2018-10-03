using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;

namespace DidoStore.Data.Repositories
{
    public interface IRatingRepository : IRepository<Rating>
    {

    }

    public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        public RatingRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
