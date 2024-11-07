using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProvider.Domain.Models
{
    
    public class OrderResponse
    {
        public string OrderID { get; set; } = null!;                           
        public DateTime EstimatedDeliveryDate { get; set; }
        public OrderEntity OrderDetails { get; set; } = null!;       
    }
}
//Kan anvönda här StatusMessage String.