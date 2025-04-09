using Microsoft.AspNetCore.Mvc;
using OBS.Data;

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
    }
}
