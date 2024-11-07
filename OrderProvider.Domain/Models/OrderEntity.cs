using OrderProvider.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProvider.Domain.Models
{
    public class OrderEntity
    {
        public string? OrderId { get; set; }   
        public string? CustomerName { get; set; } 
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderProduct> ProductList { get; set; } = null!;
        public string DeliveryAddress { get; set; } = null!;
    }

}
