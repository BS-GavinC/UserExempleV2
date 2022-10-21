using Microsoft.AspNetCore.Mvc;
using UserExemple.Data;
using UserExemple.Models;
using UserExemple.Models.ViewModel;

namespace UserExemple.Controllers
    
{
    public class UserController : Controller
    {

        
        
        public IActionResult Index()
        {
            return View(FakeDb.users);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            user.Id = FakeDb.users[FakeDb.users.Count - 1].Id + 1;
            FakeDb.users.Add(user);
            return RedirectToAction("Index");
        
        }

        public IActionResult Read()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
