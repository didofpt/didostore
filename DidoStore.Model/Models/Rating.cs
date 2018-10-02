using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidoStore.Model.Models
{
    [Table("Ratings")]
    public class Rating
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        public int ProductId { set; get; }

        [Required]
        public int UserId { set; get;}

        public bool Status { set; get; }

        [Required]
        public int Mark { set; get; }

        [MaxLength(250)]
        public string Feedback { set; get; }


        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}
