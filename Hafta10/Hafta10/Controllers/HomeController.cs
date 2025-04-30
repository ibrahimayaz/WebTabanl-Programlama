using Hafta10.Data;
using Hafta10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hafta10.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var durum = _context.Ogrenci.Any();

            if (!durum)
            {
                _context.Ogrenci.Add(new Ogrenci()
                {
                    Id = 1,
                    Ad = "Ahmet",
                    Soyad = "YILMAZ",
                    BolumAdi = "Bilgisayar Müh."
                });
                
                _context.SaveChanges();
            }
            return Content("Merhaba !");
        }

    }
}
