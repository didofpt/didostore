using DidoStore.Data.Infrastructure;
using DidoStore.Data.Repositories;
using DidoStore.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DidoStore.UnitTest.RepositoryTest
{
    [TestClass]
    public class ProductRepositoryTest
    {

        IProductRepository _productRepository;
        IDbFactory _dbFactory;
        IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _dbFactory = new DbFactory();
            _productRepository = new ProductRepository(_dbFactory);
            _unitOfWork = new UnitOfWork(_dbFactory);

        }


        [TestMethod]
        public void Product_Repository_GetAll()
        {
            var list = _productRepository.GetAll().ToList();

            Assert.AreEqual(2, list.Count);
        }


        [TestMethod]
        public void Product_Repository_Creat()
        {
            Product product = new Product
            {
                Name = "pro name",
                Alias = "pro-name",
                BranchId = 3,
                Price = 5,
                CreatedDate = DateTime.Today,
                UpdatedDate = DateTime.Today,
                Status = true
            };


            var res = _productRepository.Add(product);
            _unitOfWork.Commit();

            Assert.IsNotNull(res);
            //Assert.AreEqual(1, res.Id);
        }

    }
}
