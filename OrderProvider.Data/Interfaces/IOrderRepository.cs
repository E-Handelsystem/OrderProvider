
using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;
using System.Collections.Generic;

namespace OrderProvider.Data.Interfaces;



public interface IOrderRepository
{

    ResponseResult<OrderResponse> Create(OrderRequest order);
    OrderEntity GetOrderById(string orderId);
    void UpdateOrder(OrderEntity order);
    List<OrderEntity> GetAllOrders();
    List<OrderEntity> GetOrdersByStatus(OrderStatus status);
    ResponseResult RemoveOrderById(string id);
}
