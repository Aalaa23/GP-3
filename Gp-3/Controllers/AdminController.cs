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
        private readonly IShoppingRepository<Seller> sellerRepository;
        private readonly IShoppingRepository<Customer> customerRepository;
        private readonly IWebHostEnvironment hosting;
        public AdminController(IShoppingRepository<Category> categoryRepository,
            IShoppingRepository<Seller> sellerRepository,
            IShoppingRepository<Customer> customerRepository,
            IWebHostEnvironment hosting)
        {
            this.sellerRepository = sellerRepository;
            this.customerRepository = customerRepository;
            this.hosting = hosting;
        }

        public IActionResult Index()
        {
            return View();
        }

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
        }
    }
            
