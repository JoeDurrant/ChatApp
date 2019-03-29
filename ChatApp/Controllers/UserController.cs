using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            Models.UserModel um = new Models.UserModel();
            return View();
        }
        public ActionResult CreateAccount(Models.UserModel userModel)
        {
            userModel.RegistrationDate = DateTime.Now;
            userModel.UserID = Guid.NewGuid();
            return Redirect("/home");
        }
    }
}