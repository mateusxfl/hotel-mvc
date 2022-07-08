using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface ICheckoutRepository
    {
        CheckoutModel Create(CheckoutModel checkout);

        List<CheckoutModel> FindAll();

        CheckoutModel FindById(int id);
    }
}
