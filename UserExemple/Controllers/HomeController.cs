using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserExemple.Data;
using UserExemple.Models;
using UserExemple.Models.ViewModel;

namespace UserExemple.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {

            
            User? user = FakeDb.users.SingleOrDefault(u => u.Email == login.Email);

            if (user != null)
            {
                if (user.Password == login.Password)
                {
                    HttpContext.Session.SetString("Email", user.Email);
                    HttpContext.Session.SetString("Role", user.IsAdmin ? "Admin" : "User");
                    return RedirectToAction("Index");
                }
                
            }
            return View(login);
            
        }
    }
}