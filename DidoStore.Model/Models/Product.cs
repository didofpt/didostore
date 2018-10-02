using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DidoStore.Model.Models
{
    [Table("Products")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [Required]
        public int BranchId { set; get; }

        public string Image { set; get; }


        [Column(TypeName = "xml")]
        public string MoreImages { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }

        [Required]
        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public DateTime CreatedDate { set; get; }

        public DateTime UpdatedDate { set; get; }

        public int? Quantity { set; get; }


        [MaxLength(100)]
        public string CreatedBy { set; get; }

        [MaxLength(100)]
        public string UpdatedBy { set; get; }

        public int? Warranty { set; get; }

        public bool Status { set; get; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { set; get; }


        public virtual IEquatable<Comment> Comments { set; get; }

        public virtual IEquatable<Rating> Ratings { set; get; }

    }
}
