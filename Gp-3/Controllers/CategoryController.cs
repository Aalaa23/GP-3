using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gp_3.Models.Repositories;
using Gp_3.Models;

namespace Gp_3.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IShoppingRepository<Category> categoryRepository;

        public CategoryController(IShoppingRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            var category = categoryRepository.List();

            return View(category);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categoryRepository.Find(id);

            return View(category);
        }

        //GET : Add category
        public IActionResult AddCategory()
        {
            return View();
        }

        //POST : Add category
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category category)
        {
            try
            {
                categoryRepository.Add(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var category = categoryRepository.Find(id);
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                categoryRepository.Update(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var seller = categoryRepository.Find(id);
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                categoryRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
