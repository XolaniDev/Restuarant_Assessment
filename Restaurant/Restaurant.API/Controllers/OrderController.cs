using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.API.Services;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Http;
using Restaurant.API.Data.Models;
using Restaurant.API.Data.Dtos;
using Restaurant.API.Converters;

namespace Restaurant.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly IOrderService _orderService;

        /// <summary>
        /// 
        /// </summary>
        private readonly IOrderConverters _orderConverters;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderService"></param>
        public OrderController(IOrderService orderService , IOrderConverters orderConverters)
        {
            _orderService = orderService;
            _orderConverters = orderConverters;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(201, type: typeof(Order), description: "Created a order")]
        [SwaggerResponse(400, type: typeof(Order), description: "Created a order was unsuccessful")]
        public async Task<IActionResult> PlaceOrder([FromBody] OrderDto ordersDto)
        {
            if (ordersDto is null) return BadRequest("Not created");

            var newOrder = _orderConverters.ConvertToOrder(ordersDto);

            if (newOrder is null) return BadRequest();

            var results = await _orderService.PlaceOrder(newOrder);

                if (results)
                {
                    return Created(nameof(PlaceOrder), true);
                }
                else
                {
                    return BadRequest("reservation already exists.");
                }
            
        }
    }
}
