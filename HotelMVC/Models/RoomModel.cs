using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int MaximumOccupancy { get; set; }
        public int Floor { get; set; }
        public string Description { get; set; }
        public double DailyValue { get; set; }
        public string Status { get; set; }
    }
}
