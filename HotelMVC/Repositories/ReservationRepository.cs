using HotelMVC.Data;
using HotelMVC.Models.ReservationModels;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly DataContext _dataContext;

        public ReservationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ReservationsModel Create(ReservationsModel reservation)
        {
            _dataContext.Reservations.Add(reservation);
            _dataContext.SaveChanges();

            return reservation;
        }

        public bool Delete(int id)
        {
            ReservationsModel DbReservation = FindById(id);

            if (DbReservation == null) throw new System.Exception("Houve um erro na deleção da reserva!");

            _dataContext.Reservations.Remove(DbReservation);
            _dataContext.SaveChanges();

            return true;
        }

        public List<ReservationsModel> FindAll()
        {
            return _dataContext.Reservations.ToList();
        }

        public ReservationsModel FindById(int id)
        {
            return _dataContext.Reservations.FirstOrDefault(r => r.Id == id);
        }

        public ReservationsModel Update(ReservationsModel reservation)
        {
            ReservationsModel DbReservation = FindById(reservation.Id);

            if (DbReservation == null) throw new System.Exception("Houve um erro na atualização da reserva!");

            DbReservation.NumberOfOccupants = reservation.NumberOfOccupants;
            DbReservation.ExpectedEntryDate = reservation.ExpectedEntryDate;
            DbReservation.ExpectedDepartureDate = reservation.ExpectedDepartureDate;
            DbReservation.Status = reservation.Status;
            DbReservation.CustomerId = reservation.CustomerId;
            DbReservation.RoomId = reservation.RoomId;

            _dataContext.Reservations.Update(DbReservation);
            _dataContext.SaveChanges();

            return DbReservation;
        }
    }
}
