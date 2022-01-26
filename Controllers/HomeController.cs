using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission4.Models;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _MovieContext { get; set; }

        // constructor
        public HomeController(ILogger<HomeController> logger, MovieContext movieVariable)
        {
            _logger = logger;

            _MovieContext = movieVariable;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GoPodcasts()
        {
            return View("MyPodcasts");
        }


        [HttpGet]
        public IActionResult InputMovies()
        {
            return View("Movies");
        }


        [HttpPost]
        public IActionResult InputMovies(Application application)
        {
            _MovieContext.Add(application);
            _MovieContext.SaveChanges();
            return View("response", application);

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
