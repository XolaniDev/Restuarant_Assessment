using Restaurant.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.API.Data.Dtos;

namespace Restaurant.API.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderConverters : IOrderConverters
    {
        /// <summary>
        /// /
        /// </summary>
        public OrderConverters()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDto"></param>
        /// <returns></returns>
        public Order ConvertToOrder(OrderDto orderDto)
        {
            Order order = new Order
            {
                Description = orderDto.Description,
                ReservationId = orderDto.ReservationId
   
            };

            return order;
        }
    }
}
