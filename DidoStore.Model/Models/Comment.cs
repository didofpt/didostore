using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DidoStore.Model.Models
{
    [Table("Comments")]
    public class Comment
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }


        [Required]
        public int UserId { set; get; }


        [Required]
        public int ProductId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}
