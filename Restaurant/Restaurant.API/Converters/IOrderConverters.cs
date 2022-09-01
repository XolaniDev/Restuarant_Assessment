using Restaurant.API.Data.Dtos;
using Restaurant.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.API.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderConverters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderDto"></param>
        /// <returns></returns>
        public Order ConvertToOrder(OrderDto orderDto);
    }
}
