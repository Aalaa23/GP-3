using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Controllers
{
    public class ShipperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
