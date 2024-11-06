using OrderProvider.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProvider.Domain.Factories;

public class OrderFactory
{
    public static OrderEntity CreatOrder(string customerName, string orderId, DateTime dateTime , string status , decimal toralAmount)
    {
        return new OrderEntity
        {
            OrderId = Guid.NewGuid().ToString(),
            CustomerName = customerName,
            OrderDate = dateTime,
            Status = status,
            TotalAmount = toralAmount
        };
    }
}
