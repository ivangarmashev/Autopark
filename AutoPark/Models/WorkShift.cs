using System;

namespace AutoPark.Models
{
    public class WorkShift
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}