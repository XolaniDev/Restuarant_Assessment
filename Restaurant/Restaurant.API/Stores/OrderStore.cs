using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.API.Data;
using Restaurant.API.Data.Models;

namespace Restaurant.API.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderStore: IOrderStore
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly RestaurantDbContext _dbContext;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurantDbContext"></param>
        public OrderStore(RestaurantDbContext restaurantDbContext)
        {
            _dbContext = restaurantDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public async Task<bool> PlaceOrder(Order orders)
        {
            bool exist = _dbContext.Orders
                .Where(x => x.Id == orders.Id)
                .ToList().Count > 0;

            if (exist) return false;

            _dbContext.Add(orders);
            var results = await _dbContext.SaveChangesAsync();
            return results > 0;

        }

     
    }
}
