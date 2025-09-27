using System.Diagnostics;
using ASP.NETCOREMVCPracticeFile.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCOREMVCPracticeFile.Controllers
{
    // ViewBag
    public class HomeController : Controller
    {
        public ViewResult Details()
        {
            //Using ViewBag
            ViewBag.Title = "Student Details Page";

            //Using ViewData
            ViewBag.Header = "Student Details";

            //Creating Student Object to Hold Student data
            Student student = new Student()
            {
                StudentId = 1,
                Name = "Umme",
                Branch = "CSE",
                Section = "A",
                Gender = "Female"
            };

            ViewBag.Student = student;

            // Pass the student model instance directly to the View
            return View();
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
