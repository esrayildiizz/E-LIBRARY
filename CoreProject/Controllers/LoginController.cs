using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin a)
        {
            return View();
        }



        [HttpGet]
        public IActionResult User()
        {
            return View();
        }
        [HttpPost]
        public IActionResult User(User u)
        {
            return View();
        }



        public IActionResult LogOut()
        {
            return View();
        }
    }
}
