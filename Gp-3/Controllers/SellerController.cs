using Gp_3.Models;
using Gp_3.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Controllers
{
    public class SellerController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public SellerController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        //GET : Add Product/
        public IActionResult AddProduct()
        {
            return View();
        }

        //POST : Add product.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(int id) {
            
            return View();
        }
        public IActionResult InvList(int id)
        {

            return View();
        }
        public IActionResult Profile(int id)
        {

            return View();
        }


    }
}
