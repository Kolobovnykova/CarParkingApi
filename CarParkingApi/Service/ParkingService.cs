using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarParking.Entities;

namespace CarParkingApi.Service
{
    public class ParkingService
    {
        private readonly Parking parking;

        public ParkingService()
        {
            parking = Parking.Instance;
        }

        public int GetFreeSpaces()
        {
            return parking.GetFreeSpacesNumber();
        }

        public int GetTakenSpaces()
        {
            return parking.GetTakenSpacesNumber();
        }
    }
}
