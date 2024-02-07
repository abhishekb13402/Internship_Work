using Microsoft.AspNetCore.Mvc;
using Relationship.Data;
using Relationship.Models;
using System.Diagnostics;

namespace Relationship.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _applicationDBContext;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(ApplicationDBContext  applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }

        public IActionResult Index()
        {
            var stddata = _applicationDBContext.Employees.ToList();
            return View(stddata);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
