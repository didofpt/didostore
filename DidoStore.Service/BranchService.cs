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

    public interface IBranchService
    {
        void Add(Branch branch);
        void Update(Branch branch);
        void Delete(int id);
        IEnumerable<Branch> GetAll();
        IEnumerable<Branch> GetAllPaging(int page, int pageSize, out int totalRow);
        Branch GetById(int id);
        void SaveChanges();
    }

    public class BranchService : IBranchService
    {

        IBranchRepository _branchRepository;
        IUnitOfWork _unitOfWork;

        public BranchService(IBranchRepository branchRepository, IUnitOfWork unitOfWork )
        {
            _branchRepository = branchRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Branch branch)
        {
            _branchRepository.Add(branch);
        }

        public void Delete(int id)
        {
            _branchRepository.Delete(id);
        }

        public IEnumerable<Branch> GetAll()
        {
            return _branchRepository.GetAll();
        }

        public IEnumerable<Branch> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _branchRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Branch GetById(int id)
        {
            return _branchRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Branch branch)
        {
            _branchRepository.Update(branch);
        }
    }
}
