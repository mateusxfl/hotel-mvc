using HotelMVC.Models;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Controllers
{
    public class CustomersController : Controller
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            List<CustomersModel> customers = _customerRepository.FindAll();

            return View(customers);
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            CustomersModel customer = _customerRepository.FindById(id);

            return View(customer);
        }

        public IActionResult Details(int id)
        {
            CustomersModel customer = _customerRepository.FindById(id);

            return PartialView(customer);
        }

        [HttpPost]
        public IActionResult Store(CustomersModel customer)
        {
            _customerRepository.Create(customer);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(CustomersModel customer)
        {
            _customerRepository.Update(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Destroy(int id)
        {
            _customerRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
