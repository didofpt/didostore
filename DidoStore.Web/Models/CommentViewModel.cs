namespace DidoStore.Web.Models
{
    public class CommentViewModel
    {



        public int Id { set; get; }



        public int UserId { set; get; }



        public int ProductId { set; get; }


        public virtual ProductViewModel Product { set; get; }

    }
}