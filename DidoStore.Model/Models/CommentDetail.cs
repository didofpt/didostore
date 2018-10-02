using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DidoStore.Model.Models
{
    [Table("CommentDetails")]
    public class CommentDetail
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ set; get; }

        [Required]
        public int CommentId { set; get; }

        [Required]
        [MaxLength(500)]
        public string Content { set; get; }


        public DateTime CreatedDate { set; get; }


        public bool Status { set; get; }


        public int ParentId { set; get; }

        [ForeignKey("CommentId")]
        public virtual Comment Comment { set; get; }

        [ForeignKey("ParentId")]
        public virtual CommentDetail CommentDetailSelf { set; get; }

        public virtual IEnumerable<CommentDetail> CommentDetails { set; get; }



        
    }
}
