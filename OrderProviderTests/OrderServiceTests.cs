﻿using Moq;

using OrderProvider.Business.Services;
using OrderProvider.Data.Interfaces;
using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Factories;
using OrderProvider.Domain.Models;

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
    public void GetAllOrders__Should_ReturnAll_Orders()
    {
        // Arrange
        var orders = new List<OrderEntity>
        {
           new OrderEntity { OrderId = "1", Status = OrderProvider.Domain.Enum.OrderStatus.Pending, TotalAmount = 100 },
            new OrderEntity { OrderId = "2", Status = OrderProvider.Domain.Enum.OrderStatus.Shipped, TotalAmount = 150}
        };
        _orderRepositoryMock.Setup(s =>s.GetAllOrders()).Returns(orders);

        // Act
        var result = _orderService.GetAllOrders();

        // Assert
     
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);

    }
    [Fact]

    public void GetOrdersByStatus_ShouldReturnOnlyOrdersWithSpecifiedStatus()
    {
        // Arrange
        var orders = new List<OrderEntity>
    {
        new OrderEntity { OrderId = "1", Status = OrderStatus.Pending , TotalAmount = 100 },
        new OrderEntity { OrderId = "2", Status = OrderStatus.Shipped, TotalAmount = 150 },
        new OrderEntity { OrderId = "3", Status = OrderStatus.Confirmed, TotalAmount = 200 }
    };

        _orderRepositoryMock.Setup(s => s.GetAllOrders()).Returns(orders);

        // Act
        var result = _orderService.GetOrdersByStatus(OrderStatus.Shipped);

        // Assert
        
        Assert.NotNull(result);
        Assert.Single(result);
        
    }






}
