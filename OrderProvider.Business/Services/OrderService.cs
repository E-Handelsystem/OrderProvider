using OrderProvider.Business.Interfaces;
using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Models;

namespace OrderProvider.Business.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public List<OrderEntity> GetAllOrders()
    {
        return _orderRepository.GetAllOrders();
    }

}
