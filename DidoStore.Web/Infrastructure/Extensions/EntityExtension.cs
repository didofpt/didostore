using DidoStore.Model.Models;
using DidoStore.Web.Models;

namespace DidoStore.Web.Infrastructure.Extensions
{
    public static class EntityExtension
    {
        public static void UpdateProduct(this Product product, ProductViewModel productVm)
        {

            //public int Id { set; get; }
            product.Id = productVm.Id;

            //public string Name { set; get; }
            product.Name = productVm.Name;

            //public string Alias { set; get; }
            product.Alias = productVm.Alias;

            //public int BranchId { set; get; }
            product.BranchId = productVm.BranchId;

            //public string Image { set; get; }
            product.Image = productVm.Image;

            //public string MoreImages { set; get; }
            product.MoreImages = productVm.MoreImages;

            //public string Description { set; get; }
            product.Description = productVm.Description;

            //public string Content { set; get; }
            product.Content = productVm.Content;

            //public decimal Price { set; get; }
            product.Price = productVm.Price;

            //public decimal? PromotionPrice { set; get; }
            product.PromotionPrice = productVm.PromotionPrice;

            //public DateTime CreatedDate { set; get; }
            product.CreatedDate = productVm.CreatedDate;

            //public DateTime UpdatedDate { set; get; }
            product.UpdatedDate = productVm.UpdatedDate;

            //public int? Quantity { set; get; }
            product.Quantity = productVm.Quantity;

            //public string CreatedBy { set; get; }
            product.CreatedBy = productVm.CreatedBy;

            //public string UpdatedBy { set; get; }
            product.UpdatedBy = productVm.UpdatedBy;

            //public int? Warranty { set; get; }
            product.Warranty = productVm.Warranty;

            //public bool Status { set; get; }
            product.Status = productVm.Status;

        }

        public static void UpdateBranch(this Branch branch, BranchViewModel branchVm)
        {
            //    public int Id { set; get; }
            branch.Id = branchVm.Id;

            //public string Name { set; get; }
            branch.Name = branchVm.Name;

            //public string Alias { set; get; }
            branch.Alias = branchVm.Alias;

            //public string Description { set; get; }
            branch.Description = branchVm.Description;

            //public DateTime CreatedDate { set; get; }
            branch.CreatedDate = branchVm.CreatedDate;

            //public DateTime UpdatedDate { set; get; }
            branch.UpdatedDate = branchVm.UpdatedDate;

            //public string CreatedBy { set; get; }
            branch.CreatedBy = branchVm.CreatedBy;

            //public string UpdatedBy { set; get; }
            branch.UpdatedBy = branchVm.UpdatedBy;

            //public string Image { set; get; }
            branch.Image = branchVm.Image;

            //public bool Status { set; get; }
            branch.Status = branchVm.Status;
        }

        public static void UpdateOrder(this Order order, OrderViewModel orderVm)
        {

            //public int Id { set; get; }
            order.Id = orderVm.Id;

            //public int UserId { set; get; }
            order.UserId = orderVm.UserId;

            //public string DestinationAddress { set; get; }
            order.DestinationAddress = orderVm.DestinationAddress;

            //public decimal Total { set; get; }
            order.Total = orderVm.Total;

            //public string Note { set; get; }
            order.Note = orderVm.Note;

            //public string PaymentMethod { set; get; }
            order.PaymentMethod = orderVm.PaymentMethod;

            //public DateTime? CreatedDate { set; get; }
            order.CreatedDate = orderVm.CreatedDate;

            //public bool? PaymentStatus { set; get; }
            order.PaymentStatus = orderVm.PaymentStatus;

            //public bool? Status { set; get; }
            order.Status = orderVm.Status;
        }

        public static void UpdateOrderDetail(this OrderDetail orderDetail, OrderDetailViewModel orderDetailVm)
        {
            //    public int OrderId { set; get; }
            orderDetail.OrderId = orderDetailVm.OrderId;

            //public int ProductId { set; get; }
            orderDetail.ProductId = orderDetailVm.ProductId;

            //public int Quantity { set; get; }
            orderDetail.Quantity = orderDetailVm.Quantity;

        }

        public static void UpdateComment(this Comment comment, CommentViewModel commentVm)
        {

            //public int Id { set; get; }
            comment.Id = commentVm.Id;

            //public int UserId { set; get; }
            comment.UserId = commentVm.UserId;

            //public int ProductId { set; get; }
            comment.ProductId = commentVm.ProductId;

        }

        public static void UpdateCommentDetail(this CommentDetail commentDetail, CommentDetailViewModel commentDetailVm)
        {

            //    public int Id { set; get; }
            commentDetail.Id = commentDetailVm.Id;

            //public int CommentId { set; get; }
            commentDetail.CommentId = commentDetailVm.CommentId;

            //public string Content { set; get; }
            commentDetail.Content = commentDetailVm.Content;

            //public DateTime CreatedDate { set; get; }
            commentDetail.CreatedDate = commentDetailVm.CreatedDate;

            //public bool Status { set; get; }
            commentDetail.Status = commentDetailVm.Status;

            //public int? ParentId { set; get; }
            commentDetail.ParentId = commentDetailVm.ParentId;

        }

        public static void UpdateRating(this Rating rating, RatingViewModel ratingVm)
        {
            //    public int Id { set; get; }
            rating.Id = ratingVm.Id;

            //public int ProductId { set; get; }
            rating.ProductId = ratingVm.ProductId;

            //public int UserId { set; get; }
            rating.UserId = ratingVm.UserId;

            //public bool Status { set; get; }
            rating.Status = ratingVm.Status;

            //public int Mark { set; get; }
            rating.Mark = ratingVm.Mark;

            //public string Feedback { set; get; }
            rating.Feedback = ratingVm.Feedback;

        }

    }
}