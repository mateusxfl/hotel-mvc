using HotelMVC.Data;
using HotelMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelMVC.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _dataContext;

        public RoomRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public RoomModel FindById(int id)
        {
            return _dataContext.Rooms.FirstOrDefault(r => r.Id == id);
        }

        public List<RoomModel> FindAll()
        {
            return _dataContext.Rooms.ToList();
        }

        public RoomModel Create(RoomModel room)
        {
            _dataContext.Rooms.Add(room);
            _dataContext.SaveChanges();

            return room;
        }

        public RoomModel Update(RoomModel room)
        {
            RoomModel DbRoom = FindById(room.Id);

            if (DbRoom == null) throw new System.Exception("Houve um erro na atualização do quarto!");

            DbRoom.Id = room.Id;
            DbRoom.MaximumOccupancy = room.MaximumOccupancy;
            DbRoom.Floor = room.Floor;
            DbRoom.Description = room.Description;
            DbRoom.DailyValue = room.DailyValue;
            DbRoom.Status = room.Status;

            _dataContext.Rooms.Update(DbRoom);
            _dataContext.SaveChanges();

            return DbRoom;
        }

        public bool Delete(int id)
        {
            RoomModel DbRoom = FindById(id);

            if (DbRoom == null) throw new System.Exception("Houve um erro na deleção do quarto!");

            _dataContext.Rooms.Remove(DbRoom);
            _dataContext.SaveChanges();

            return true;
        }
    }
}
