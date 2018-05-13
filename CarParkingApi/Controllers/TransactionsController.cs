using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarParkingApi.Service;
using Microsoft.AspNetCore.Http;
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
        public string Get()
        {
            try
            {
                return transactionService.GetLogFile();
            }
            catch (Exception)
            {
                return StatusCode(400).ToString();
            }
        }
    }
}
