using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPark.Models;

namespace AutoPark
{
    public class CarData
    {
        public static void Initialize(CarContext context)
        {
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car()
                    {
                        Model = "Tesla",
                        Odometer = 25000,
                        HorsePower = 650
                    },
                    new Car()
                    {
                        Model = "Nicola",
                        Odometer = 15000,
                        HorsePower = 700
                    },
                    new Car()
                    {
                        Model = "Lada",
                        Odometer = 250250,
                        HorsePower = 76
                    });
                context.SaveChanges();
            }
            
            if (!context.Drivers.Any())
            {
                context.Drivers.AddRange(
                    new Driver()
                    {
                        FirstName = "Nikola",
                        SecondName = "Tesla",
                        Age = 35,
                        Experience = 10
                    },
                    new Driver()
                    {
                        FirstName = "Ivan",
                        SecondName = "Ivanov",
                        Age = 25,
                        Experience = 7
                    },
                    new Driver()
                    {
                        FirstName = "Petr",
                        SecondName = "Petrov",
                        Age = 50,
                        Experience = 30
                    });
                context.SaveChanges();
            }
        }
    }
}