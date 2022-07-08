using HotelMVC.Models;
using HotelMVC.Models.ReservationModels;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly ICheckinRepository _checkinRepository;

        public ReservationsController(
            IReservationRepository reservationRepository, 
            ICustomerRepository customerRepository,
            IRoomRepository roomRepository,
            ICheckinRepository checkinRepository
        )
        {
            _reservationRepository = reservationRepository;
            _customerRepository = customerRepository;
            _roomRepository = roomRepository;
            _checkinRepository = checkinRepository;
        }

        public IActionResult Index()
        {
            List<ReservationsModel> reservations = _reservationRepository.FindAll();
            List<CustomersModel> customers = _customerRepository.FindAll();
            List<RoomModel> rooms = _roomRepository.FindAll();
            List<CheckinModel> checkins = _checkinRepository.FindAll();

            var viewModel = new ReservationIndexViewModel
            {
                Reservations = reservations,
                Customers = customers,
                Rooms = rooms,
                Checkins = checkins
            };

            return View(viewModel);
        }

        public IActionResult Store()
        {
            List<CustomersModel> customers = _customerRepository.FindAll();
            List<RoomModel> rooms = _roomRepository.FindAll();

            var viewModel = new ReservationFormViewModel
            {
                Customers = customers,
                Rooms = rooms
            };

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            ReservationsModel reservation = _reservationRepository.FindById(id);
            List<CustomersModel> customers = _customerRepository.FindAll();
            List<RoomModel> rooms = _roomRepository.FindAll();

            var viewModel = new ReservationFormViewModel
            {
                Reservation = reservation,
                Customers = customers,
                Rooms = rooms
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            ReservationsModel reservation = _reservationRepository.FindById(id);
            CustomersModel customers = _customerRepository.FindById(reservation.CustomerId);
            RoomModel rooms = _roomRepository.FindById(reservation.RoomId);

            var viewModel = new ReservationDetailsViewModel
            {
                Reservation = reservation,
                Customer = customers,
                Room = rooms
            };

            return PartialView(viewModel);
        }

        [HttpPost]
        public IActionResult Store(ReservationsModel reservation)
        {
            _reservationRepository.Create(reservation);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(ReservationsModel reservation)
        {
            _reservationRepository.Update(reservation);
            return RedirectToAction("Index");
        }

        public IActionResult Destroy(int id)
        {
            _reservationRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
