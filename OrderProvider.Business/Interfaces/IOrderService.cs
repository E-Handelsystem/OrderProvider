

using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Models;

namespace OrderProvider.Business.Interfaces;

public interface IOrderService
{
    ResponseResult<OrderResponse> Create(OrderRequest request);
    ResponseResult<IEnumerable<OrderResponse>> GetAllOrders();
    ResponseResult<OrderResponse> GetOrderById(string orderId);
    ResponseResult<OrderResponse> GetOrdersByStatus(OrderStatus status);
    public ResponseResult RemoveOrderById(string id);



}


