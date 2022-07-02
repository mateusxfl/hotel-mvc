using HotelMVC.Data;
using HotelMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public CustomersModel Create(CustomersModel customer)
        {
            _dataContext.Customers.Add(customer);
            _dataContext.SaveChanges();

            return customer;
        }

        public bool Delete(int id)
        {
            CustomersModel DbCustomer = FindById(id);

            if (DbCustomer == null) throw new System.Exception("Houve um erro na deleção do cliente!");

            _dataContext.Customers.Remove(DbCustomer);
            _dataContext.SaveChanges();

            return true;
        }

        public List<CustomersModel> FindAll()
        {
            return _dataContext.Customers.ToList();
        }

        public CustomersModel FindById(int id)
        {
            return _dataContext.Customers.FirstOrDefault(c => c.Id == id);
        }

        public CustomersModel Update(CustomersModel customer)
        {
            CustomersModel DbCustomer = FindById(customer.Id);

            if (DbCustomer == null) throw new System.Exception("Houve um erro na atualização do cliente!");

            DbCustomer.Name = customer.Name;
            DbCustomer.Cpf = customer.Cpf;
            DbCustomer.Email = customer.Email;
            DbCustomer.Telephone = customer.Telephone;
            DbCustomer.Road = customer.Road;
            DbCustomer.District = customer.District;
            DbCustomer.Number = customer.Number;
            DbCustomer.City = customer.City;

            _dataContext.Customers.Update(DbCustomer);
            _dataContext.SaveChanges();

            return DbCustomer;
        }
    }
}
