using AutoMapper;
using DidoStore.Model.Models;
using DidoStore.Service;
using DidoStore.Web.Infrastructure.Core;
using DidoStore.Web.Infrastructure.Extensions;
using DidoStore.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DidoStore.Web.Api
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {

        IProductService _productService;

        public ProductController(IErrorService errorService, IProductService productService)
            : base(errorService)
        {
            this._productService = productService;
        }


        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, ProductViewModel productVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(ModelState.IsValid)
                {
                    request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    Product newProduct = new Product();
                    newProduct.UpdateProduct(productVm);
                    var returnProduct = _productService.Add(newProduct);
                    _productService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, newProduct);
                }
                return response;
            });
        }


        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, ProductViewModel productVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(ModelState.IsValid)
                {
                    request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {

                    var productDb = _productService.GetById(productVm.Id);
                    productDb.UpdateProduct(productVm);
                    _productService.Update(productDb);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(ModelState.IsValid)
                {
                    request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _productService.Delete(id);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listProduct = _productService.GetAll();

                var listProductVm = Mapper.Map<List<ProductViewModel>>(listProduct);

                return request.CreateResponse(HttpStatusCode.OK, listProductVm); ;
            });
        }


    }
}