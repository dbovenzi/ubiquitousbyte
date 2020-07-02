using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ubiquitousbyte.Models;

namespace ubiquitousbyte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewData["MachineName"] = Environment.MachineName;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ServiceReport()
        {
            var serviceReports = new List<ServiceReport>();
            // Loop through each microservice and call /heath - record reponse

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
