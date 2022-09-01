using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.API.Data.Dtos;
using Restaurant.API.Data.Models;
using Restaurant.API.Stores;

namespace Restaurant.API.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ReservationService: IReservationService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IReservationStore _reservationStore;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservationStore"></param>
        public ReservationService(IReservationStore reservationStore)
        {
            _reservationStore = reservationStore;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public Task<bool> CreateReservation(Reservation reservationDto)
        {
            return _reservationStore.CreateReservation(reservationDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Reservation>> GetReservations()
        {
            return await _reservationStore.GetReservations();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateReservation"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Reservation> UpdateReservation(Reservation updateReservation, int id)
        {
            return await _reservationStore.UpdateReservation(updateReservation, id);
        }
    }
}
