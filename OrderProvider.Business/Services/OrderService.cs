using OrderProvider.Business.Interfaces;
using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Factories;
using OrderProvider.Domain.Models;

namespace OrderProvider.Business.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;



    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public ResponseResult<OrderResponse> Create(OrderRequest request)
    {
        var entity = OrderFactory.CreateOrderFromRequest(request);

        var product = OrderFactory.CreateResponseFromOrder(entity);

        return ResponseResultFactory.Success(product, message: "Created successfully");
    }


   //-----------------------------------------------------------
   //ChatGPT
    public ResponseResult<IEnumerable<OrderResponse>> GetAllOrders()
    {
        var allOrders = _orderRepository.GetAllOrders();

        if (allOrders == null)
        {
            return ResponseResultFactory.NotFound<IEnumerable<OrderResponse>>(null!, message: "No orders found");
        }

        var orderResponses = allOrders.Select(OrderFactory.CreateResponseFromOrder);
        return ResponseResultFactory.Success(orderResponses);
    }
    //___________________________________________________________
    public ResponseResult<OrderResponse> GetOrderById(string orderId)
    {
        var allOrders = _orderRepository.GetAllOrders();
        var result = allOrders.FirstOrDefault(o => o.OrderId == orderId);
        var product = OrderFactory.CreateResponseFromOrder(result!);
        return ResponseResultFactory.Success(product);
    }
 
    public ResponseResult<OrderResponse> GetOrdersByStatus(OrderStatus status)
    {
       
        var allOrders = _orderRepository.GetAllOrders();
        var result= allOrders.FirstOrDefault(s => s.Status == status);
        var product = OrderFactory.CreateResponseFromOrder(result!);
        return ResponseResultFactory.Success(product);
 }

    public ResponseResult RemoveOrderById(string id)
    {
        return _orderRepository.RemoveOrderById(id);
        
    }
}
