using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DTV_App.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}