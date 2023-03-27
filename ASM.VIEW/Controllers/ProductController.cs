using ASM.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM.VIEW.Controllers
{
    public class ProductController : Controller
    {
        ProductServices _svProduct;
        public ProductController()
        {
            _svProduct = new ProductServices();
        }
        public async Task<IActionResult> List()
        {
            var list = await _svProduct.GetAllAsync();
            return View(list);
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            var model = await _svProduct.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
