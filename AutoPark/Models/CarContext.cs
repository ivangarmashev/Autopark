using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPark.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

}