using System;
using System.Collections.Generic;

namespace DidoStore.Web.Models
{
    public class BranchViewModel
    {
   
        public int Id { set; get; }
     
        public string Name { set; get; }
      
        public string Alias { set; get; }

        public string Description { set; get; }

        public DateTime CreatedDate { set; get; }

        public DateTime UpdatedDate { set; get; }


        public string CreatedBy { set; get; }

  
        public string UpdatedBy { set; get; }

        public string Image { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}