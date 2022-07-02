using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface ICustomerRepository
    {
        CustomersModel Create(CustomersModel customer);

        bool Delete(int id);

        List<CustomersModel> FindAll();

        CustomersModel FindById(int id);

        CustomersModel Update(CustomersModel customer);
    }
}
