using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface IPaymentRepository
    {
        PaymentModel Create(PaymentStoreViewModel paymentStoreView);

        PaymentModel FindById(int id);

        List<PaymentModel> FindAll();

        PaymentModel Update(PaymentModel payment);
    }
}
