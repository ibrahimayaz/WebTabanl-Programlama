using DataAnnotationBEU.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotationBEU.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserVM userVm)
        {
            if (ModelState.IsValid)
            {
                //Problem yok kaydı gerçekleştir.
                return View();
            }
            else
            {
                return View(userVm);
            }
        }
    }
}
