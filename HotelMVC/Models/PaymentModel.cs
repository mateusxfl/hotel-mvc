using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class PaymentModel
    {
        public int IdReservation { get; set; }
        public double ReservationValue { get; set; }
        public string FormOfPayment { get; set; }
        public string Proof { get; set; }
    }
}
