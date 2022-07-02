using HotelMVC.Models;
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

    }
}
