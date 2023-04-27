using EsercizioFinale.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioFinale.Controllers
{
    public class LoginController : Controller
    {
        private readonly List<User> Users = new List<User>(){
                new User("ciao", "ciao"),
                new User("davide", "davide"),
                new User("avanade", "avanade")
        };

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var userAttamptToLogin = Users.FirstOrDefault(u => u.UserName == username && u.Password == password);


            if (userAttamptToLogin != null)
            {
                return RedirectToAction("LoginSuccess", "Login");
            }
            else return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}
