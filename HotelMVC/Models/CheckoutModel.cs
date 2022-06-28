using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class CheckoutModel
    {
        public int IdReservation { get; set; }
        public DateTime ExitDate { get; set; }
        public DateTime ExitHour { get; set; }
    }
}
