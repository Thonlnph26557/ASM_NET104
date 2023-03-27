using ASM.MVC.Services;
using ASM.VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASM.VIEW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductServices _svProduct;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _svProduct = new ProductServices();
        }

        public async Task<IActionResult> Index()
        {
            var list = await _svProduct.GetAllAsync();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}