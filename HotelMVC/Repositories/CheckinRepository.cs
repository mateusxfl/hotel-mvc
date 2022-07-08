using HotelMVC.Data;
using HotelMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class CheckinRepository : ICheckinRepository
    {
        private readonly DataContext _dataContext;

        public CheckinRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public CheckinModel Create(CheckinModel checkin)
        {
            _dataContext.Checkins.Add(checkin);
            _dataContext.SaveChanges();

            return checkin;
        }

        public List<CheckinModel> FindAll()
        {
            return _dataContext.Checkins.ToList();
        }

        public CheckinModel FindById(int id)
        {
            return _dataContext.Checkins.FirstOrDefault(c => c.Id == id);
        }
    }
}
