using Gp_3.Models;
using Gp_3.Models.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gp_3.Models.ViewModel;

namespace Gp_3.Controllers
{
    public class SellerController : Controller
    {
        private readonly IShoppingRepository<Category> categoryRepository;

        public SellerController(IShoppingRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        //private readonly SignInManager<IdentityUser> signInManager;
        //public SellerController(SignInManager<IdentityUser> signInManager)
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

        //GET : Add product.
        public IActionResult Create(int sellerId)
        {
            var Categories = categoryRepository.List().ToList();
            var model = new AddProductVM
            {
                Categories = Categories,
                SellerID = sellerId
            };
            return View();
        }

        //POST : Add Product/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
