using Gp_3.Data;
using Gp_3.Models;
using Gp_3.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Controllers
{
    public class AdminController : Controller
    {
        private readonly ShoppingDbContext db;

        public AdminController(ShoppingDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }
        //private readonly SignInManager<IdentityUser> signInManager;
        //public AdminController(SignInManager<IdentityUser> signInManager)
        //{
        //    this.signInManager = signInManager;
        //}

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("index", "home");
        //}

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await signInManager.PasswordSignInAsync(
        //            model.Email, model.Password, model.RememberMe, false);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("index", "home");
        //        }

        //        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
        //    }

        //    return View(model);
        //}

        public IActionResult DeleteCustomer(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       

    }
}
