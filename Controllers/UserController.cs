using Microsoft.AspNetCore.Mvc;
using projectsign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectsign.Controllers
{
    public class UserController : Controller
    {

        private readonly context _con;
        public UserController(context con)
        {
            _con = con;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult signUpForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult signUpForm(signup s)
        {
            _con.Add(s);
            _con.SaveChanges();
            ViewBag.message = "saved "+ " "+  s.Name;
            return View();

        }
    }
}
