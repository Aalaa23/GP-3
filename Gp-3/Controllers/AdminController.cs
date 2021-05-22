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
        private readonly IShoppingRepository<Category> categoryRepository;
        private readonly IShoppingRepository<Seller> sellerRepository;
        private readonly IShoppingRepository<Customer> customerRepository;
        private readonly IWebHostEnvironment hosting;
        public AdminController(IShoppingRepository<Category> categoryRepository,
            IShoppingRepository<Seller> sellerRepository,
            IShoppingRepository<Customer> customerRepository,
            IWebHostEnvironment hosting)
        {
            this.categoryRepository = categoryRepository;
            this.sellerRepository = sellerRepository;
            this.customerRepository = customerRepository;
            this.hosting = hosting;
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

        public IActionResult DeleteCustomer(int id)
        {
            Customer customer = customerRepository.Find(id);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            customerRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSeller(int id)
        {
            Seller seller = sellerRepository.Find(id);
            if (seller == null)
            {
                return RedirectToAction("Index");
            }
            sellerRepository.Delete(id);
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
