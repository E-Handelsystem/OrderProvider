
using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;
using System.Collections.Generic;

namespace OrderProvider.Data.Interfaces;



public interface IOrderRepository
{
    OrderEntity GetOrderById(string orderId);
    void UpdateOrder(OrderEntity order);
    List<OrderEntity> GetAllOrders();

    List<OrderEntity> GetOrdersByStatus(OrderStatus status);
   bool RemoveOrderById(string id);
}
