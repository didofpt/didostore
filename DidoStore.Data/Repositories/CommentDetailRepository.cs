using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace DidoStore.Data.Repositories
{

    public interface ICommentDetailRepository : IRepository<CommentDetail>
    {
        IEnumerable<CommentDetail> GetByCommentId(int commentId);
    }
    public class CommentDetailRepository : RepositoryBase<CommentDetail>, ICommentDetailRepository

    {
        public CommentDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<CommentDetail> GetByCommentId(int commentId)
        {
            var query = from cd in DbContext.CommentDetails
                        join c in DbContext.Comments
                        on cd.CommentId equals c.Id
                        where cd.ParentId == null
                        orderby cd.CreatedDate descending
                        select cd;

            return query;

        }
    }
}
