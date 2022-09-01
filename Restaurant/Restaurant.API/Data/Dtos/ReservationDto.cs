using Restaurant.API.Data.Models;
using Restaurant.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.API.Data.Dtos
{
    public class ReservationDto
    {

        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReservationStatus ReservationStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}
