using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface IEmployeeRepository
    {
        EmployeesModel Create(EmployeesModel employee);

        bool Delete(int id);

        List<EmployeesModel> FindAll();

        EmployeesModel FindById(int id);

        EmployeesModel Update(EmployeesModel employee);
    }
}
