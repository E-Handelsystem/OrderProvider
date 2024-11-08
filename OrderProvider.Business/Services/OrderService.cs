using OrderProvider.Business.Interfaces;
using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Enum;
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
    public OrderEntity GetOrderById(string orderId)
    {
        return _orderRepository.GetOrderById(orderId);
    }

    public List<OrderEntity> GetOrdersByStatus(OrderStatus status)
    {
        var allOrders = _orderRepository.GetAllOrders();
        return allOrders.Where(o => o.Status == status).ToList();
    }
}
