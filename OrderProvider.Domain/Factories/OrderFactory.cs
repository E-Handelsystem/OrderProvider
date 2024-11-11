using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;


namespace OrderProvider.Domain.Factories;

public class OrderFactory
{
    public static OrderEntity CreateOrderFromRequest(OrderRequest request)
    {
        return new OrderEntity
        {
            OrderId = Guid.NewGuid().ToString(),
            CategoryID = Guid.NewGuid().ToString(),
            CustomerName = request.CustomerName,
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending,
            TotalAmount = request.TotalAmount,
            ProductList = request.Products,
            DeliveryAddress = request.DeliveryAddress
        };
    }
    public static OrderResponse CreateResponseFromOrder(OrderEntity order)
    {
        return new OrderResponse
        {
            EstimatedDeliveryDate = DateTime.Now.AddDays(5), //ChatGpt-40
            OrderId = order.OrderId,
            CustomerName = order.CustomerName,
            OrderDate = order.OrderDate,
            Status = order.Status,
            TotalAmount = order.TotalAmount,
            ProductList =order.ProductList,
            DeliveryAddress = order.DeliveryAddress,


        };
    }

}
