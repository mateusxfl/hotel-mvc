using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models.ReservationModels
{
    public class ReservationsModel
    {
        public int Id { get; set; }
        public int NumberOfOccupants { get; set; }
        public DateTime ExpectedEntryDate { get; set; }
        public DateTime ExpectedDepartureDate { get; set; }
        public short Status { get; set; }

        public int CustomerId { get; set; }
        public CustomersModel Customer { get; set; }
        public int RoomId { get; set; }
        public RoomModel Room { get; set; }
    }
}
