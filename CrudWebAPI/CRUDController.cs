using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWebAPI.DataAccess;
using CrudWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CrudWebAPI
{
    [Route("[controller]")]
    public class CRUDController : Controller
    {
        private readonly ILogger<CRUDController> _logger;

        private string _connectionString = string.Empty;
        private DAL dal;
        public CRUDController(ILogger<CRUDController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("InvoiceDbConn");
            dal = new DAL(_connectionString);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public IActionResult GetAllInvoices()
        {
            List<Invoice> lst = new List<Invoice>();
            lst = dal.GetAllInvoices();
            return Ok(lst);
        }
    }
}