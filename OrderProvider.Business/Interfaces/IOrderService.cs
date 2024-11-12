

using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;

namespace OrderProvider.Business.Interfaces;

public interface IOrderService
{
    ResponseResult<OrderResponse> Create(OrderRequest request);
    List<OrderEntity> GetAllOrders();
    OrderEntity GetOrderById(string id);
    bool RemoveOrderById(string id);
    List<OrderEntity> GetOrdersByStatus(OrderStatus status);

   
}


