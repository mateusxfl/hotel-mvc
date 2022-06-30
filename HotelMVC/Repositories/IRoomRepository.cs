using HotelMVC.Models;
using System.Collections.Generic;

namespace HotelMVC.Repositories
{
    public interface IRoomRepository
    {
        RoomModel FindById(int id);

        List<RoomModel> FindAll();

        RoomModel Create(RoomModel room);

        RoomModel Update(RoomModel room);

        bool Delete(int id);
    }
}
