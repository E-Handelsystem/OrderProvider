﻿using OrderProvider.Domain.Enum;
using OrderProvider.Domain.Factories;
using OrderProvider.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProviderTests
{
    public class Factories
    {
        [Fact]
        public void CreateOrder_FromRequest__Shoud_Return_OrderEntity()
        {
            // Arrange
            var request = new OrderRequest
            {
                Products = new List<OrderProduct>
                {
                    new OrderProduct { ProductID = 10, Quantity = 3 },
                },
                DeliveryAddress = "Exempelgatan 1",
                CustomerName = "Jon"
            };
            // Act
            var orderEntity = OrderFactory.CreateOrderFromRequest(request);

            // Assert
            Assert.NotNull(orderEntity);
            Assert.Equal(request.DeliveryAddress, orderEntity.DeliveryAddress);
            Assert.Equal(request.CustomerName, orderEntity.CustomerName);
        }

        [Fact]
        public void CreateResponseFromOrder_ValidOrder_ReturnsOrderResponse()
        {
            // Arrange
            var orderEntity = new OrderEntity
            {
                OrderId = Guid.NewGuid().ToString(),
                CustomerName = "Test Customer",
                OrderDate = DateTime.Now,
                Status = OrderStatus.Confirmed,
                TotalAmount = 100,
                ProductList = new List<OrderProduct>
            {
                new OrderProduct { ProductID = 1, Quantity = 2 }
            },
                DeliveryAddress = "Exempelgatan 1"
            };

            // Act
            var orderResponse = OrderFactory.CreateResponseFromOrder(orderEntity);

            // Assert
            Assert.NotNull(orderResponse);
            Assert.Equal(orderEntity.OrderDate, orderResponse.OrderDate);
            Assert.Equal(orderEntity.OrderId, orderResponse.OrderId);

        }
    }
}
