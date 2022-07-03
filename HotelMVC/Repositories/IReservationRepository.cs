using HotelMVC.Models.ReservationModels;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface IReservationRepository
    {
        ReservationsModel Create(ReservationsModel resevation);

        bool Delete(int id);

        List<ReservationsModel> FindAll();

        ReservationsModel FindById(int id);

        ReservationsModel Update(ReservationsModel resevation);
    }
}
