

using OrderProvider.Domain.Models;

namespace OrderProvider.Business.Interfaces;

public interface IOrderService
{
    List<OrderEntity> GetAllOrders();
 
}
