using System.Diagnostics;
using DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {

            return Content(_messageService.GetMessage());
        }

        
    }
}
