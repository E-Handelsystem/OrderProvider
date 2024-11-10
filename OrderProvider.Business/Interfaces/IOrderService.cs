

using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;

namespace OrderProvider.Business.Interfaces;

public interface IOrderService
{
    List<OrderEntity> GetAllOrders();
    OrderEntity GetOrderById(string id);

    bool RemoveOrderById(string id);
    List<OrderEntity> GetOrdersByStatus(OrderStatus status);

   
}


