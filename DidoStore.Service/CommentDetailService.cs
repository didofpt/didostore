using DidoStore.Data.Infrastructure;
using DidoStore.Data.Repositories;
using DidoStore.Model.Models;
using System;
using System.Collections.Generic;

namespace DidoStore.Service
{
    public interface ICommentDetailService
    {
        void Add(CommentDetail commentDetail);
        void Delete(int id);
        void Update(CommentDetail commentDetail);
        IEnumerable<CommentDetail> GetAllByCommentId(int commentId);
        void SaveChange();
    }

    public class CommentDetailService : ICommentDetailService
    {
        ICommentDetailRepository _commentDetailRepository;
        IUnitOfWork _unitOfWork;

        public CommentDetailService(ICommentDetailRepository commentDetailRepository, IUnitOfWork unitOfWork)
        {
            _commentDetailRepository = commentDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(CommentDetail commentDetail)
        {
            _commentDetailRepository.Add(commentDetail);
        }

        public void Delete(int id)
        {
            _commentDetailRepository.Delete(id);
        }

        public IEnumerable<CommentDetail> GetAllByCommentId(int commentId)
        {
            return _commentDetailRepository.GetByCommentId(commentId);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(CommentDetail commentDetail)
        {
            _commentDetailRepository.Update(commentDetail); 
        }
    }
}
