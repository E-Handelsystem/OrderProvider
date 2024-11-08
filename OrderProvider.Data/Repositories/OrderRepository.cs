using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Models;

namespace OrderProvider.Data.Repositories;

//test kommentar
public class OrderRepository : IOrderRepository
{
    public List<OrderEntity> GetAllOrders()
    {
        throw new NotImplementedException();
    }

    public OrderEntity GetOrderById(string orderId)
    {
        throw new NotImplementedException();
    }

    public void UpdateOrder(OrderEntity order)
    {
        throw new NotImplementedException();
    }
}
