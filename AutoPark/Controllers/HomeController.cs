using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoPark.Models;

namespace AutoPark.Controllers
{
    public class HomeController : Controller
    {
        CarContext db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CarContext carContext)
        {
            _logger = logger;
            db = carContext;
        }

        public IActionResult Index()
        {
            return View(db.Cars.ToList());
        }
        
        public IActionResult Car()
        {
            return View(db.Cars.ToList());
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
            return Redirect("~/Home/Car");
        }

        [HttpGet]
        public IActionResult DeleteCar(int id)
        {
            db.Cars.Remove(db.Cars.Find(id));
            db.SaveChanges();
            return Redirect("~/Home/Car");
        }
    }
}