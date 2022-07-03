namespace HotelMVC.Models.ReservationModels
{
    public class ReservationDetailsViewModel
    {
        public ReservationsModel Reservation { get; set; }
        public CustomersModel Customer { get; set; }
        public RoomModel Room { get; set; }
    }
}
