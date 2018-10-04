using DidoStore.Data.Infrastructure;
using DidoStore.Data.Repositories;
using DidoStore.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidoStore.Service
{
    public interface ICommentService
    {
        void Add(Comment commment);
        void Update(Comment comment);
        void Delete(int id);
        void SaveChange();
        IEnumerable<Comment> GetAllByProductId(int productId);
    }

    public class CommentService : ICommentService
    {
        ICommentRepository _commentRepository;
        IUnitOfWork _unitOfWork;

        public CommentService(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Comment commment)
        {
            _commentRepository.Add(commment);
        }

        public void Delete(int id)
        {
            _commentRepository.Delete(id);
        }

        public IEnumerable<Comment> GetAllByProductId(int productId)
        {
            return _commentRepository.GetMulti(x => x.ProductId == productId);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Comment comment)
        {
            _commentRepository.Update(comment);
        }
    }
}
