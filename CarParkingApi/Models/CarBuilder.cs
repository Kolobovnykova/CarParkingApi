using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarParking.Entities;

namespace CarParkingApi.Models
{
    public class CarBuilder
    {
        public int Type { get; set; }
        public double Balance { get; set; }
    }
}
