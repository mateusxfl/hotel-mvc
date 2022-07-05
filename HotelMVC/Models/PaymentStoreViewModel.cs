using HotelMVC.Models.ReservationModels;

namespace HotelMVC.Models
{
    public class PaymentStoreViewModel
    {
        public PaymentModel Payment { get; set; }
        public ReservationsModel Reservation { get; set; }
    }
}
