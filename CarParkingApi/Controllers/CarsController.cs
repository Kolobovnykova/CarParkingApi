using System;
using CarParkingApi.Models;
using CarParkingApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarParkingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Cars")]
    public class CarsController : Controller
    {
        private readonly CarService carService;

        public CarsController(CarService carService)
        {
            this.carService = carService;
        }

        // GET: api/Cars
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(carService.GetCars());
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var car = carService.GetCarById(id);

            if (car == null)
            {
                return StatusCode(400);
            }

            return Json(car);
        }

        // POST: api/Cars
        [HttpPost]
        public StatusCodeResult Post([FromBody] CarBuilder value)
        {
            try
            {
                carService.AddCar(value);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public StatusCodeResult Delete(int id)
        {
            try
            {
                carService.RemoveCar(id);
                return StatusCode(200);
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }
    }
}