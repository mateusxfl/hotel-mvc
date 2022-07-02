using HotelMVC.Data;
using HotelMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public EmployeesModel Create(EmployeesModel employee)
        {
            _dataContext.Employees.Add(employee);
            _dataContext.SaveChanges();

            return employee;
        }

        public bool Delete(int id)
        {
            EmployeesModel DbEmployee = FindById(id);

            if (DbEmployee == null) throw new System.Exception("Houve um erro na deleção do funcionário!");

            _dataContext.Employees.Remove(DbEmployee);
            _dataContext.SaveChanges();

            return true;
        }

        public List<EmployeesModel> FindAll()
        {
            return _dataContext.Employees.ToList();
        }

        public EmployeesModel FindById(int id)
        {
            return _dataContext.Employees.FirstOrDefault(c => c.Id == id);
        }

        public EmployeesModel Update(EmployeesModel employee)
        {
            EmployeesModel DbEmployee = FindById(employee.Id);

            if (DbEmployee == null) throw new System.Exception("Houve um erro na atualização do funcionário!");

            DbEmployee.Name = employee.Name;
            DbEmployee.Cpf = employee.Cpf;
            DbEmployee.Email = employee.Email;
            DbEmployee.Telephone = employee.Telephone;
            DbEmployee.Road = employee.Road;
            DbEmployee.District = employee.District;
            DbEmployee.Number = employee.Number;
            DbEmployee.City = employee.City;
            DbEmployee.User = employee.User;
            DbEmployee.Password = employee.Password;
            DbEmployee.Admission = employee.Admission;

            _dataContext.Employees.Update(DbEmployee);
            _dataContext.SaveChanges();

            return DbEmployee;
        }
    }
}
