using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace Presentation.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public IActionResult Product()
        {
            return View();
        }
    }
}