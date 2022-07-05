using HotelMVC.Models;
using HotelMVC.Models.ReservationModels;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelMVC.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IRoomRepository _roomRepository;

        public PaymentsController(IPaymentRepository paymentRepository, IReservationRepository reservationRepository, IRoomRepository roomRepository)
        {
            _paymentRepository = paymentRepository;
            _reservationRepository = reservationRepository;
            _roomRepository = roomRepository;
        }

        public IActionResult Store(int id)
        {
            ReservationsModel reservation = _reservationRepository.FindById(id);
            RoomModel room = _roomRepository.FindById(reservation.RoomId);

            int totalDays = (int) reservation.ExpectedDepartureDate.Subtract(reservation.ExpectedEntryDate).TotalDays;

            var reservationValue = room.DailyValue * totalDays;

            if(reservationValue == 0)
                reservationValue = room.DailyValue;

            var viewModel = new PaymentStoreViewModel
            {
                Reservation = reservation,
                Payment = new PaymentModel { ReservationValue = reservationValue }
            };

            return PartialView(viewModel);
        }

        public IActionResult Edit(int id)
        {
            PaymentModel payment = _paymentRepository.FindById(id);

            return PartialView(payment);
        }

        [HttpPost]
        public IActionResult Store(PaymentModel payment)
        {
            ReservationsModel reservation = _reservationRepository.FindById(payment.ReservationId);
            
            var viewModel = new PaymentStoreViewModel
            {
                Reservation = reservation,
                Payment = payment
            };

            _paymentRepository.Create(viewModel);

            return RedirectToAction("Index", "Reservations");
        }

        [HttpPost]
        public IActionResult Edit(PaymentModel payment)
        {
            _paymentRepository.Update(payment);
            return RedirectToAction("Index", "Reservations");
        }
    }
}
