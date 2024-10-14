using AzureDB.Models;
using BusinessObject.Models;
using DataAccess;
using DataAccess.DAO;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AppDbContext _appDbContext = new AppDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = _appDbContext.Courses.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            _appDbContext.Courses.Add(course);
            _appDbContext.SaveChanges();

            return View(course);
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
