namespace DidoStore.Web.Models
{
    public class OrderDetailViewModel
    {
        public int OrderId { set; get; }

 
        public int ProductId { set; get; }


        public int Quantity { set; get; }

    
        public virtual OrderViewModel Order { set; get; }


        public virtual ProductViewModel Product { set; get; }
    }
}