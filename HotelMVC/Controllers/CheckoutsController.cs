using HotelMVC.Models;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class CheckoutsController : Controller
    {
        private readonly ICheckoutRepository _checkoutRepository;

        public CheckoutsController(ICheckoutRepository checkoutRepository)
        {
            _checkoutRepository = checkoutRepository;
        }

        public IActionResult Index(int id)
        {
            CheckoutModel checkout = _checkoutRepository.FindById(id);
            return PartialView(checkout);
        }

        public IActionResult Store(int id)
        {
            CheckoutModel checkout = new CheckoutModel { ReservationId = id };
            return PartialView(checkout);
        }

        [HttpPost]
        public IActionResult Store(CheckoutModel checkout)
        {
            _checkoutRepository.Create(checkout);
            return RedirectToAction("Index", "Reservations");
        }
    }
}
