using DotNetFramework._4._7._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetFramework._4._7._2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authenticate(string username, string password)
        {
            // TODO: Validate the user's credentials

            if (username == "admin" && password == "password")
            {
                // Redirect to the dashboard page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Display an error message
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View("Login");
            }
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Create user and redirect to dashboard
            }

            return View(model);
        }

    }
}