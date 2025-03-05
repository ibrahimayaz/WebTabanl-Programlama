using KursProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursProjesi.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new();

        public StudentController() { }

        
        public IActionResult Index() { 
            return View(); 
        }

        [HttpPost]
        public IActionResult Index(Student s) { 

            students.Add(s);
            return View("List", students); 
        }

    }
}
