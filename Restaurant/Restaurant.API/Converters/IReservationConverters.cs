using Restaurant.API.Data.Dtos;
using Restaurant.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.API.Converters
{
    public interface IReservationConverters
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservationDto"></param>
        /// <returns></returns>
        public Reservation ConvertToReservation(ReservationDto reservationDto);

    }
}
