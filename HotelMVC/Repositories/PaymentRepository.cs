using HotelMVC.Data;
using HotelMVC.Models;
using HotelMVC.Models.ReservationModels;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DataContext _dataContext;

        public PaymentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public PaymentModel Create(PaymentStoreViewModel paymentStoreView)
        {
            ReservationsModel DbReservation = paymentStoreView.Reservation;
            DbReservation.Status = 1;

            _dataContext.Payments.Add(paymentStoreView.Payment);
            _dataContext.Reservations.Update(DbReservation);
            _dataContext.SaveChanges();

            return paymentStoreView.Payment;
        }

        public PaymentModel FindById(int id)
        {
            return _dataContext.Payments.FirstOrDefault(p => p.Id == id);
        }

        public PaymentModel Update(PaymentModel payment)
        {
            PaymentModel DbPayment = FindById(payment.Id);

            if (DbPayment == null) throw new System.Exception("Houve um erro na atualização do pagamento!");

            DbPayment.ReservationValue = payment.ReservationValue;
            DbPayment.FormOfPayment = payment.FormOfPayment;
            DbPayment.Proof = payment.Proof;
            DbPayment.ReservationId = payment.ReservationId;

            _dataContext.Payments.Update(DbPayment);
            _dataContext.SaveChanges();

            return DbPayment;
        }
    }
}
