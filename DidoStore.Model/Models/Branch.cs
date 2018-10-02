using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DidoStore.Model.Models
{

    [Table("Branches")]
    public class Branch
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

        public string Description { set; get; }

        public DateTime CreatedDate { set; get; }

        public DateTime UpdatedDate { set; get; }

        [MaxLength(250)]
        public string CreatedBy { set; get; }

        [MaxLength(250)]
        public string UpdatedBy { set; get; }

        public string Image { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }

    }
}
