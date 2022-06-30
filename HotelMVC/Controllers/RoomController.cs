using HotelMVC.Models;
using HotelMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public IActionResult Index()
        {
            List<RoomModel> rooms = _roomRepository.FindAll();

            return View(rooms);
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            RoomModel room = _roomRepository.FindById(id);

            return View(room);
        }

        public IActionResult Details(int id)
        {
            RoomModel room = _roomRepository.FindById(id);

            return PartialView(room);
        }

        [HttpPost]
        public IActionResult Store(RoomModel room)
        {
            _roomRepository.Create(room);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(RoomModel room)
        {
            _roomRepository.Update(room);
            return RedirectToAction("Index");
        }

        public IActionResult Destroy(int id)
        {
            _roomRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
