using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMVC.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Destroy()
        {
            return View();
        }
    }
}
