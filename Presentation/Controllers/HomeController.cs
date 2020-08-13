using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private IStatusService _statusService;
        public IActionResult Index()
        {
            return View();
        }
    }
}