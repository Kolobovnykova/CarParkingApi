using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarParkingApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarParkingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Parking")]
    public class ParkingController : Controller
    {
        private readonly ParkingService parkingService;

        public ParkingController(ParkingService parkingService)
        {
            this.parkingService = parkingService;
        }

        [HttpGet("FreeSpaces")]
        public IActionResult GetFreeSpaces()
        {
            try
            {
                return Json(parkingService.GetFreeSpaces());

            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }

        [HttpGet("TakenSpaces")]
        public IActionResult GetTakenSpaces()
        {
            try
            {
                return Json(parkingService.GetTakenSpaces());
            }
            catch (Exception)
            {
                return StatusCode(400);
            }
        }
    }
}
