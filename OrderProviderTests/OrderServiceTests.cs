using Moq;
using OrderProvider.Business.Interfaces;
using OrderProvider.Business.Services;
using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Models;
using System;
using System.Collections.Generic;
using Xunit;

public class OrderServiceTests
{
    private readonly OrderService _orderService;
    private readonly Mock<IOrderRepository> _orderRepositoryMock;

    public OrderServiceTests()
    {
        _orderRepositoryMock = new Mock<IOrderRepository>();
        _orderService = new OrderService(_orderRepositoryMock.Object);
    }

    [Fact]
    public void GetAllOrders_ShouldReturnAllOrdersWithCorrectDetails()
    {
        // Arrange
        var orders = new List<OrderEntity>
        {
           new OrderEntity { OrderId = "1", Status = "Bearbetas", TotalAmount = 100 },
            new OrderEntity { OrderId = "1", Status = "Skickad", TotalAmount = 150}
        };

     
        _orderRepositoryMock.Setup(s =>s.GetAllOrders()).Returns(orders);

        // Act
        var result = _orderService.GetAllOrders();

        // Assert
     
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);

    }
    [Fact]
    public void GetOrderByOrderId_ShouldReturnMatchingOrder()
    {
        // Arrange
        var orders = new List<OrderEntity>
     {
         new OrderEntity { OrderId = "1", Status = OrderStatus.Pending, TotalAmount = 100, CustomerName = "Customer A" },
         new OrderEntity { OrderId = "2", Status = OrderStatus.Shipped, TotalAmount = 150, CustomerName = "Customer B" }
     };

        _orderRepositoryMock.Setup(s => s.GetOrderById("1")).Returns(orders.FirstOrDefault(o => o.OrderId == "1"));

        // Act
        var result = _orderService.GetOrderById("1");

        // Assert
        Assert.NotNull(result);
        Assert.Equal("1", result.OrderId);
        Assert.Equal("Customer A", result.CustomerName);
        Assert.Equal(100, result.TotalAmount);
        Assert.Equal(OrderStatus.Pending, result.Status);
    }
}
