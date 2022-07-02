using HotelMVC.Models;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            List<EmployeesModel> employees = _employeeRepository.FindAll();

            return View(employees);
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            EmployeesModel employee = _employeeRepository.FindById(id);

            return View(employee);
        }

        public IActionResult Details(int id)
        {
            EmployeesModel employee = _employeeRepository.FindById(id);

            return PartialView(employee);
        }

        [HttpPost]
        public IActionResult Store(EmployeesModel employee)
        {
            _employeeRepository.Create(employee);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(EmployeesModel employee)
        {
            _employeeRepository.Update(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Destroy(int id)
        {
            _employeeRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
