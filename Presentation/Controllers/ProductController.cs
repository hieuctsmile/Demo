using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace Presentation.Controllers
{
    public class ProductController : Controller
    {
        private IStatusService _statusService;
        public IActionResult Product()
        {
            return View();
        }
    }
}