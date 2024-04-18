using CHECKPOINT2_DOTNET.Data;
using CHECKPOINT2_DOTNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CHECKPOINT2_DOTNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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