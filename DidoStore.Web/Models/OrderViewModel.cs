using System;
using System.Collections.Generic;

namespace DidoStore.Web.Models
{
    public class OrderViewModel
    {

    
        public int Id { set; get; }

    
        public int UserId { set; get; }


       
        public string DestinationAddress { set; get; }

 
        public decimal Total { set; get; }

        public string Note { set; get; }

     
        public string PaymentMethod { set; get; }


        public DateTime? CreatedDate { set; get; }

        public bool? PaymentStatus { set; get; }

        public bool? Status { set; get; }

        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { set; get; }

    }
}