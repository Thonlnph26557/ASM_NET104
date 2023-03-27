using ASM.DB.Models;
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
            list = list.Where(c => c.AvaiableQuantity > 5).ToList();
            return View(list);
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            var model = await _svProduct.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _svProduct.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product model)
        {
            if (ModelState.IsValid)
            {
                await _svProduct.CreateAsync(model);
                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                await _svProduct.UpdateAsync(model);
                return RedirectToAction("List");
            }
            return View(model);
        }
    }
}
