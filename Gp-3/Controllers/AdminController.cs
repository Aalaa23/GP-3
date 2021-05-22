using Gp_3.Data;
using Gp_3.Models;
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

    }
}
