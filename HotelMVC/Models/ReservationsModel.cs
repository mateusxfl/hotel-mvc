using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class ReservationsModel
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdRoom { get; set; }
        public int NumberOfOccupants { get; set; }
        public DateTime ExpectedEntryDate { get; set; }
        public DateTime ExpectedDepartureDate { get; set; }
        public short Status { get; set; }
    }
}
