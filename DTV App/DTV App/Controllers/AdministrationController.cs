using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTV_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DTV_App.Controllers
{
    public class AdministrationController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginAdminVM model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Wypełnij wszystkie pola!");
                return View(model);
            }


            if (model.Login == "d" && model.Password == "d")
            {
                int id = 1;
                string url = "Admindex/" + id;
                return Redirect(url);
            }
            ModelState.AddModelError("", "Błędny login lub hasło!");
            model.Password = null;
            return View(model);
        }

        [HttpGet]
        public IActionResult Admindex(string id, LoginAdminVM model)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Login");
            }
            return View(model);
        }
    }
}