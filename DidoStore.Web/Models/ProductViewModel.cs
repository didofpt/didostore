using System;

namespace DidoStore.Web.Models
{
    public class ProductViewModel
    {
        public int Id { set; get; }


        public string Name { set; get; }

 
        public string Alias { set; get; }


        public int BranchId { set; get; }

        public string Image { set; get; }


        public string MoreImages { set; get; }


        public string Description { set; get; }

        public string Content { set; get; }


        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public DateTime CreatedDate { set; get; }

        public DateTime UpdatedDate { set; get; }

        public int? Quantity { set; get; }



        public string CreatedBy { set; get; }


        public string UpdatedBy { set; get; }

        public int? Warranty { set; get; }

        public bool Status { set; get; }


        public virtual BranchViewModel Branch { set; get; }


        public virtual IEquatable<CommentViewModel> Comments { set; get; }

        public virtual IEquatable<RatingViewModel> Ratings { set; get; }
    }
}