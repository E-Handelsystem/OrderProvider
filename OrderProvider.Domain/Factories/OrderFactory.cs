using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProvider.Domain.Factories;

public class OrderFactory
{
    public static OrderEntity CreateOrderFromRequest(OrderRequest request)
    {
        return new OrderEntity
        {
            OrderId = Guid.NewGuid().ToString(),
            CustomerName = request.CustomerName, 
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending,
            TotalAmount = request.TotalAmount,
            ProductList = new List<OrderProduct>(request.Products), //ChatGPT_40
            DeliveryAddress = request.DeliveryAddress
        };
    }
    public static OrderResponse CreateResponseFromOrder(OrderEntity order)
    {
        return new OrderResponse
        {
            OrderID = order.OrderId!,
            EstimatedDeliveryDate = DateTime.Now.AddDays(5), //ChatGpt-40
            OrderDetails = order
        };
    }

}

// behöver skapa en till mdel for att dta emote en order spara den idatat base med hjälp av entety och när jag skickar infor so skicar jag status med, 
//så jga behöver skapa en model med status och och skicka info när status ändras , 
//en model some kommer in en ta emote formallen, en for entety som jag redan har , en när jag skickar info.