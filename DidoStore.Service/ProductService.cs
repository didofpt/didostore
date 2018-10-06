﻿using DidoStore.Data.Infrastructure;
using DidoStore.Data.Repositories;
using DidoStore.Model.Models;
using System.Collections.Generic;

namespace DidoStore.Service
{

    public interface IProductService
    {
        Product Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByBranchPaging(int branchId, int pageIndex, int pageSize, out int totalRow);
        Product GetById(int id);
        void SaveChanges();
    }

    public class ProductService : IProductService
    {

        IProductRepository _productRepository;

        IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public Product Add(Product product)
        {
          return  _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] { "Branch" });
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllByBranchPaging(int branchId, int pageIndex, int pageSize, out int totalRow)
        {
            return _productRepository.GetAllByBranch(branchId, pageIndex, pageSize, out totalRow);
        }

        public Product GetById(int id)
        {


            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
