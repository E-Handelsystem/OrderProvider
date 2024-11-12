using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Factories;
using OrderProvider.Domain.Models;

namespace OrderProvider.Data.Repositories;


public class OrderRepository : IOrderRepository
{
    public ResponseResult<OrderResponse> Create(OrderRequest order)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public ResponseResult RemoveOrderById(string id)
    {
        throw new NotImplementedException();
    }

    public void UpdateOrder(OrderEntity order)
    {
        throw new NotImplementedException();
    }
}
