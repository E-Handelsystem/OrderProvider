using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Factories;
using OrderProvider.Domain.Models;

namespace OrderProvider.Data.Repositories;


public class OrderRepository : IOrderRepository
{
    public ResponseResult<OrderResponse> Create(OrderRequest order)
    {
        var entity = OrderFactory.CreateOrderFromRequest(order);

        var product = OrderFactory.CreateResponseFromOrder(entity);

        return ResponseResultFactory.Success(product, message: "Created successfully");
    }
   
    public List<OrderEntity> GetAllOrders()
    {
        throw new NotImplementedException();
    }

    public OrderEntity GetOrderById(string orderId)
    {
        throw new NotImplementedException();
    }

    public List<OrderEntity> GetOrdersByStatus(OrderStatus status)
    {
        var allOrders =GetAllOrders();
        return allOrders.Where(o => o.Status == status).ToList();
    }

    public bool RemoveOrderById(string orderId)
    {
        throw new NotImplementedException();
    }

    public void UpdateOrder(OrderEntity order)
    {
        throw new NotImplementedException();
    }
}
