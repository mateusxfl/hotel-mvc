using HotelMVC.Models.ReservationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class CheckoutModel
    {
        public int Id { get; set; }
        public DateTime ExitDate { get; set; }
        public DateTime ExitHour { get; set; }

        public int ReservationId { get; set; }
        public ReservationsModel Reservation { get; set; }
    }
}
