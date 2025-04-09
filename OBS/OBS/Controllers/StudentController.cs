using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBS.Data;
using OBS.Models;

namespace OBS.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Student.Include(x=>x.Department).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id is not null)
            {
                ViewBag.BolumListesi = _context.Department.ToList();
                var ogr=_context.Student.Where(x => x.Id == id).SingleOrDefault();
                return View(ogr);
            }
            else
            {
                return RedirectToAction("Index");
            }
                
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student s)
        {
            ViewBag.BolumListesi = _context.Department.ToList();

            if (ModelState.IsValid)
            {
                _context.Update(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
               
        }
    }
}
