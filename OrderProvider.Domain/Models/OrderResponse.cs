

namespace OrderProvider.Domain.Models;


public class OrderResponse:OrderBase
{                          
    public DateTime EstimatedDeliveryDate { get; set; }
      
}
//Kan anvönda här StatusMessage String.