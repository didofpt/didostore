using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DidoStore.Model.Models;

namespace DidoStore.Model.Models
{

    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        public int UserId { set; get; }


        [Required]
        [MaxLength(250)]
        public string DestinationAddress { set; get; }

        [Required]
        public decimal Total { set; get; }

        public string Note { set; get; }

        [Required]
        [MaxLength(250)]
        public string PaymentMethod { set; get; }

        public DateTime CreatedDate { set; get; }

        public bool PaymentStatus { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

    }
}
