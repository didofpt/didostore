﻿using DidoStore.Data.Infrastructure;
using DidoStore.Model.Models;

namespace DidoStore.Data.Repositories
{

    public interface ICommentDetailRepository
    {

    }
    public class CommentDetailRepository : RepositoryBase<CommentDetail>, ICommentDetailRepository

    {
        public CommentDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
