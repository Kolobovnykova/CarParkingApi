using System;
using CarParkingApi.Models;
using CarParkingApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarParkingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Transactions")]
    public class TransactionsController : Controller
    {
        private readonly TransactionService transactionService;

        public TransactionsController(TransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        // GET: api/Transactions
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(transactionService.GetLogFile());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Transactions/income
        [HttpGet("income")]
        public IActionResult GetIncome()
        {
            try
            {
                return Json(transactionService.GetParkingIncomeForPastMinute());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Transactions/income/5
        [HttpGet("income/{id}")]
        public IActionResult GetIncome(int id)
        {
            try
            {
                return Json(transactionService.GetParkingIncomeForPastMinute(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Transactions/pastminute
        [HttpGet("pastminute")]
        public IActionResult GetTransactionsForPastMinute()
        {
            try
            {
                return Json(transactionService.GetParkingTransactionsForPastMinute());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Transactions/pastminute/5
        [HttpGet("pastminute/{id}")]
        public IActionResult GetTransactionsForPastMinute(int id)
        {
            try
            {
                return Json(transactionService.GetParkingTransactionsForPastMinute(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT: api/Transactions/replenish/5
        [HttpPut("replenish/{id}")]
        public IActionResult ReplenishAccount(int id, [FromBody] AmountBuilder c)
        {
            try
            {
                transactionService.ReplenishAccountById(id, c.Amount);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}