using System;
using System.Collections.Generic;
using CarParking.Entities;
using CarParkingApi.Models;

namespace CarParkingApi.Service
{
    public class CarService
    {
        private readonly Parking parking;

        public CarService()
        {
            parking = Parking.Instance;
        }

        public List<Car> GetCars()
        {
            return parking.GetListOfParkedCars();
        }

        public Car GetCarById(int id)
        {
            return parking.GetCarById(id);
        }

        public void AddCar(CarBuilder value)
        {
            CarType type = (CarType) Enum.ToObject(typeof(CarType), value.Type);
            parking.AddCar(type, value.Balance);
        }

        public void RemoveCar(int id)
        {
            parking.RemoveCar(id);
        }
    }
}