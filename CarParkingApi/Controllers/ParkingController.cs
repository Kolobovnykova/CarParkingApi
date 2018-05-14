using System;
using CarParkingApi.Service;
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

        // GET: api/Parking/freeSpaces
        [HttpGet("freeSpaces")]
        public IActionResult GetFreeSpaces()
        {
            try
            {
                return Json(parkingService.GetFreeSpaces());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Parking/takenspaces
        [HttpGet("takenSpaces")]
        public IActionResult GetTakenSpaces()
        {
            try
            {
                return Json(parkingService.GetTakenSpaces());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Parking/balance
        [HttpGet("balance")]
        public IActionResult GetParkingBalance()
        {
            try
            {
                return Json(parkingService.GetParkingBalance());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}