using CW12.Models;
using CW12.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace CW12.Controllers
{
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        private ProductService service = new ProductService();

        [Route("/Product")]
        [Route("~/Product/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel productModel)
        {
            if (ModelState.IsValid)
            {
                service.Create(productModel);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }
    }
}
