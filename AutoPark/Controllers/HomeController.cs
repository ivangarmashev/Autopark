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
        
        public IActionResult Cars()
        {
            return View(db.Cars.ToList());
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
            return Redirect("~/Home/Cars");
        }

        [HttpGet]
        public IActionResult DeleteCar(int id)
        {
            db.Cars.Remove(db.Cars.Find(id));
            db.SaveChanges();
            return Redirect("~/Home/Cars");
        }
        
        public IActionResult AddDriver()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDriver(Driver driver)
        {
            db.Drivers.Add(driver);
            db.SaveChanges();
            return Redirect("~/Home/Drivers");
        }

        [HttpGet]
        public IActionResult DeleteDriver(int id)
        {
            db.Drivers.Remove(db.Drivers.Find(id));
            db.SaveChanges();
            return Redirect("~/Home/Drivers");
        }

        public IActionResult Drivers()
        {
            return View(db.Drivers.ToList());
        }
    }
}