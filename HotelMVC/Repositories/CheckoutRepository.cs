using HotelMVC.Data;
using HotelMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class CheckoutRepository : ICheckoutRepository
    {
        private readonly DataContext _dataContext;

        public CheckoutRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public CheckoutModel Create(CheckoutModel checkout)
        {
            _dataContext.Checkouts.Add(checkout);
            _dataContext.SaveChanges();

            return checkout;
        }

        public List<CheckoutModel> FindAll()
        {
            return _dataContext.Checkouts.ToList();
        }

        public CheckoutModel FindById(int id)
        {
            return _dataContext.Checkouts.FirstOrDefault(c => c.Id == id);
        }
    }
}
