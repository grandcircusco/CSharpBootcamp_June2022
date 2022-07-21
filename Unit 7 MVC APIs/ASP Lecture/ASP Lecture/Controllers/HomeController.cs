using ASP_Lecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Lecture.Controllers
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
            Cat c = new Cat()
            {
                Name = "Yumi",
                Description = "The largest problem."
            };
            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Greeting()
        {
            //ViewBag and ViewData basically interchangable
            ViewBag.Project = "ASP Project";
            return View();
        }

        public IActionResult Info()
        {
            //ViewBag and ViewData basically interchangable
            ViewData["Name"] = "Justin";
            ViewData["Age"] = 25;
            return View();
        }

        public IActionResult CatForm()
        {
            return View();
        }

        //Any value sent through form must be caught by parameters
        //public IActionResult CatResult(string Name, string Description)
        //{
        //    Cat c = new Cat(Name, Description);
        //    return View(c);
        //}

        //if form values match an object, you can just take in an object
        public IActionResult CatResult(Cat c)
        {
            if(c.Name == "a")
            {
                return RedirectToAction("CatForm");
            }
            return View(c);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}