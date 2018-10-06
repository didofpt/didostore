using System;
using System.Collections.Generic;

namespace DidoStore.Web.Models
{
    public class CommentDetailViewModel
    {

        public int Id { set; get; }

        public int CommentId { set; get; }


        public string Content { set; get; }


        public DateTime CreatedDate { set; get; }


        public bool Status { set; get; }


        public int? ParentId { set; get; }


        public virtual CommentViewModel Comment { set; get; }


        public virtual CommentDetailViewModel CommentDetailSelf { set; get; }

        public virtual IEnumerable<CommentDetailViewModel> CommentDetails { set; get; }
    }
}