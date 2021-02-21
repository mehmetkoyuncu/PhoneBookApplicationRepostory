using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneBookApp.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }




    }
}
