using System.Collections.Generic;

namespace HotelMVC.Models.ReservationModels
{
    public class ReservationFormViewModel
    {
        public ReservationsModel Reservation { get; set; }
        public List<CustomersModel> Customers { get; set; }
        public List<RoomModel> Rooms { get; set; }
    }
}
