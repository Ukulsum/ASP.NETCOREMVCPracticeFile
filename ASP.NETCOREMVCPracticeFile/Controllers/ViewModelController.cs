using ASP.NETCOREMVCPracticeFile.Models;
using ASP.NETCOREMVCPracticeFile.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCOREMVCPracticeFile.Controllers
{
    public class ViewModelController : Controller
    {
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 1,
                Name = "Umme",
                Branch = "CSE",
                Section = "A",
                Gender = "Female"
            };

            // Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };

            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details"
            };

            // Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }
    }
}
