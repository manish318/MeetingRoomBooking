using MeetingRoomBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Hall;
using System.Diagnostics;

namespace MeetingRoomBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHallService _hallService;

        public HomeController(IHallService hallService)
        {
            _hallService = hallService;
        }

        public IActionResult Index()
        {
             var name= _hallService.GetName();

            ViewBag.name = name;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}