
using OrderProvider.Domain.Models;
using System.Collections.Generic;

namespace OrderProvider.Data.Interfaces;



public interface IOrderRepository
{
   
    void UpdateOrder(OrderEntity order);
    List<OrderEntity> GetAllOrders(); 
}
