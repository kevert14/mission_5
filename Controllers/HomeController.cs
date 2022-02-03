using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission4.Models;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieContext _MovieContext { get; set; }

        // constructor
        public HomeController(MovieContext movieVariable)
        {

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
            ViewBag.Categories = _MovieContext.Categories.ToList();

            return View();
        }


        [HttpPost]
        public IActionResult InputMovies(Application application)
        {
            if (ModelState.IsValid)
            {
                _MovieContext.Add(application);
                _MovieContext.SaveChanges();
                return View("response", application);
            }
            else
            {
                ViewBag.Categories = _MovieContext.Categories.ToList();
                return View();
            }

           

        }

        public IActionResult movieTable()
        {
            var applications = _MovieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();

            var application = _MovieContext.Responses.Single(x => x.MovieID == applicationid);

            return View("InputMovies", application);
        }

        [HttpPost]
        public IActionResult Edit(Application application)
        {
            _MovieContext.Update(application);
            _MovieContext.SaveChanges();

            return RedirectToAction("movieTable");
        }

        [HttpGet]
        public IActionResult Delete (int applicationid)
        {
            var application = _MovieContext.Responses.Single(x => x.MovieID == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete (Application app)
        {
            _MovieContext.Responses.Remove(app);
            _MovieContext.SaveChanges();

            return View("movieTable");
        }


    }
}
