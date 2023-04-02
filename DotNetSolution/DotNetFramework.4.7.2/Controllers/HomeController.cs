using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetFramework._4._7._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //========================Ajax Call Show Json Data in Popup

        public JsonResult GetUsersData()
        {
            var users = GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
        private List<UserModel> GetUsers()
        {
            var usersList = new List<UserModel>
            {
                //new UserModel
                //{
                //    UserId = 1,
                //    UserName = "Ram",
                //    Company = "Mindfire Solutions"
                //},
                //new UserModel
                //{
                //    UserId = 1,
                //    UserName = "chand",
                //    Company = "Mindfire Solutions"
                //},
                new UserModel
                {
                    UserId = 1,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };

            return usersList;
        }
        public class UserModel
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Company { get; set; }
        }


    }
}