using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Controllers
{
     public class LoginController : Controller
    {

         private DatabaseContext db = new ApplicationDbContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            
            var users = db.Users.ToList();
            if (Email != null && Password != null)
            {
                var user = (from u in users where u.Email.Equals(Email) && u.Password.Equals(Password) select u).FirstOrDefault<User>();
                if (user != null)
                {
                    Session["UserData"] = user;
                    if (user.Role.Title == "Admin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (user.Role.Title == "Seller")
                    {
                        return RedirectToAction("Index", "Seller");
                    }
                    else
                    {
                        return RedirectToAction("Index", "User");
                    }
                }
            }
            return View();
        }
    }


}