using Microsoft.AspNetCore.Mvc;
using OBS.Data;
using OBS.Models;

namespace OBS.Controllers
{
    public class DepartmentController :Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bolumListesi = _context.Department.ToList();
            return View(bolumListesi);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department d)
        {
            if (ModelState.IsValid)
            {
                _context.Add(d);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
