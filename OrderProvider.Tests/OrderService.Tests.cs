

using OrderProvider.Business.Interfaces;

namespace OrderProvider.Tests;

public class OrderService
{
    private readonly IOrderService _orderService;

    public OrderService(IOrderService orderService)
    {
        _orderService = orderService;
    }
    [Fact]

}
