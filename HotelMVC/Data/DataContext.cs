using HotelMVC.Models;
using HotelMVC.Models.ReservationModels;
using Microsoft.EntityFrameworkCore;

namespace HotelMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<RoomModel> Rooms { get; set; }

        public DbSet<CustomersModel> Customers { get; set; }

        public DbSet<EmployeesModel> Employees { get; set; }

        public DbSet<ReservationsModel> Reservations { get; set; }

        public DbSet<PaymentModel> Payments { get; set; }
    }
}