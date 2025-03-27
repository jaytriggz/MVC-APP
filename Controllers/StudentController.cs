using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Sample list of students
            var students = new List<string>
            {
                "Troy",
                "Nicole",
                "Charlie",
                "Femi",
                "Beyonce"
            };

            return View(students); // Pass the list to the view
        }
    }
}