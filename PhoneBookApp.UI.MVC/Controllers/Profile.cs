using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.UI.MVC.Controllers
{
    public class Profile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
