using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class Parents : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewUsersPage()
        {

            return View();
        }

        public IActionResult NewUsersPage(FormCollection form)
        {
            return View();
        }
    }
}
