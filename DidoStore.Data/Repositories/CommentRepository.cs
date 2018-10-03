using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;

namespace DidoStore.Data.Repositories
{

    public interface ICommentRepository : IRepository<Comment>
    {

    }

    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
