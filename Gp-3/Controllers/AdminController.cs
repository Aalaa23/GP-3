using Gp_3.Data;
using Gp_3.Models;
using Gp_3.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IShoppingRepository<Category> CategoryRepository;
        private readonly IShoppingRepository<Customer> CustomerRepository;
        private readonly IWebHostEnvironment hosting;
        public AdminController(IShoppingRepository<Category> CategoryRepository,
            IShoppingRepository<Customer> CustomerRepository,
            IWebHostEnvironment hosting)
        {
            this.CategoryRepository = CategoryRepository;
            this.CustomerRepository = CustomerRepository;
            this.hosting = hosting;
        }

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

        public IActionResult DeleteSeller(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Seller seller = db.Sellers.Find(id);
            if (seller == null)
            {
                return RedirectToAction("Index");
            }
            db.Sellers.Remove(seller);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET : Add category
        public IActionResult AddCategory(int id)
        {
            return View();
        }

        //POST : Add category.
        public IActionResult AddCategory()
        {
            return View();
        }
    }
}
