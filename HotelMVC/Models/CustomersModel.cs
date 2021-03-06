using HotelMVC.Models.ReservationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Models
{
    public class CustomersModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Road { get; set; }
        public string District { get; set; }
        public short Number { get; set; }
        public string City { get; set; }

        public List<ReservationsModel> Reservations { get; set; }
    }
}
