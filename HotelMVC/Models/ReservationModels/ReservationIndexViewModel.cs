using System.Collections.Generic;

namespace HotelMVC.Models.ReservationModels
{
    public class ReservationIndexViewModel
    {
        public List<ReservationsModel> Reservations { get; set; }
        public List<CustomersModel> Customers { get; set; }
        public List<RoomModel> Rooms { get; set; }
        public PaymentModel Payment { get; set; }
    }
}
