using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class CheckinModel
    {
        public int IdReservation { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime EntryHour { get; set; }
    }
}
