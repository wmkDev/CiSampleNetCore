using CiSampleNetCore.Contracts;
using CiSampleNetCore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoService _todoService;

        public HomeController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult Index()
        {
            var vmHome = new HomeViewModel
            {
                TodoViewModels = _todoService.GetAllAsync()
            };

            return View(vmHome);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
