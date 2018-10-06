namespace DidoStore.Web.Models
{
    public class RatingViewModel
    {

        public int Id { set; get; }
   
        public int ProductId { set; get; }
    
        public int UserId { set; get; }

        public bool Status { set; get; }
   
        public int Mark { set; get; }

        public string Feedback { set; get; }

        public virtual ProductViewModel Product { set; get; }
    }
}