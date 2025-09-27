using ASP.NETCOREMVCPracticeFile.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCOREMVCPracticeFile.Controllers
{
    public class StronglyTypedViewController : Controller
    {
        public ViewResult Details()
        {
            //Using ViewBag
            ViewBag.Title = "Student Details Page";
            //Using ViewData
            ViewData["Header"] = "Student Details";
            //Creating Student Object to Hold Student data
            Student student = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            // Pass the student model instance directly to the View
            return View(student);
        }
    }
}
