using OrderProvider.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProvider.Domain.Models
{
    public class OrderEntity:OrderBase
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }

}
