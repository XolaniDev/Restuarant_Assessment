using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.API.Data.Models;
using Restaurant.API.Data.Dtos;


namespace Restaurant.API.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public class ReservationConverter: IReservationConverters
    {

        /// <summary>
        /// 
        /// </summary>
        public ReservationConverter()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservationDto"></param>
        /// <returns></returns>
        public Reservation ConvertToReservation(ReservationDto reservationDto)
        {
            Reservation reservation = new Reservation
            {
                Description = reservationDto.Description,
                StartDateTime = reservationDto.StartDateTime,
                Orders = reservationDto.Orders,
                ReservationStatusId = reservationDto.ReservationStatusId
            };

            return reservation;
        } 


    }
}
