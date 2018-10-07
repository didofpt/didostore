using AutoMapper;
using DidoStore.Model.Models;
using DidoStore.Web.Models;

namespace DidoStore.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductViewModel>().MaxDepth(2);
                cfg.CreateMap<Branch, BranchViewModel>().MaxDepth(2);
                cfg.CreateMap<Order, OrderViewModel>().MaxDepth(2);
                cfg.CreateMap<OrderDetail, OrderDetailViewModel>().MaxDepth(2);
                cfg.CreateMap<Comment, CommentViewModel>().MaxDepth(2);
                cfg.CreateMap<CommentDetail, CommentDetailViewModel>().MaxDepth(2);
                cfg.CreateMap<Rating, RatingViewModel>().MaxDepth(2);


            });
        }
    }
}