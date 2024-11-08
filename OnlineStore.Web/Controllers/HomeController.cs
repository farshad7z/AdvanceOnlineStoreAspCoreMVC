using Microsoft.AspNetCore.Mvc;
using OnlineStore.BLL.Interfaces;
using OnlineStore.BLL.Services;
using OnlineStore.Web.Models;
using System.Diagnostics;

namespace OnlineStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductServices _productService;

        public HomeController(ILogger<HomeController> logger , IProductServices productServices)
        {
            _logger = logger;
            _productService = productServices;
        }

        public async Task<IActionResult> Index()
        {
            var m = await _productService.GetAllProductAsync();

            return View(m);
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
