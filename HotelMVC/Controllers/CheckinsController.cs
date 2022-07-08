using HotelMVC.Models;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class CheckinsController : Controller
    {
        private readonly ICheckinRepository _checkinRepository;

        public CheckinsController(ICheckinRepository checkinRepository)
        {
            _checkinRepository = checkinRepository;
        }

        public IActionResult Index(int id)
        {
            CheckinModel checkin = _checkinRepository.FindById(id);
            return PartialView(checkin);
        }

        public IActionResult Store(int id)
        {
            CheckinModel checkin = new CheckinModel { ReservationId = id };
            return PartialView(checkin);
        }

        [HttpPost]
        public IActionResult Store(CheckinModel checkin)
        {
            _checkinRepository.Create(checkin);
            return RedirectToAction("Index", "Reservations");
        }
    }
}
