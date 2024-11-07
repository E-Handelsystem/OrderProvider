using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProvider.Domain.Models
{
    public class OrderRequest
    {

        [Required(ErrorMessage ="you must enter a product")]
        public List<OrderProduct> Products { get; set; } = null!;

        [Required(ErrorMessage = "you must enter a delivery Adress")]
        public string DeliveryAddress { get; set; } = null!;

        public decimal TotalAmount {  get; set; }

        [Required(ErrorMessage = "you must enter your name")]
        public string? CustomerName { get; set; }
    }
}
