using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface ICheckinRepository
    {
        CheckinModel Create(CheckinModel checkin);

        List<CheckinModel> FindAll();

        CheckinModel FindById(int id);
    }
}
