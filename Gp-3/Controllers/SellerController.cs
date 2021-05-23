using Gp_3.Models;
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
        public IActionResult Index()
        {
            return View();
        }
        
        //GET : Add product.
        public IActionResult AddProduct(int id) {
            return View();
        }

        //POST : Add Product/
        public IActionResult AddProduct(Product product)
        {
            return View();
        }
    }
}
