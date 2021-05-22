using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gp_3.Controllers
{
    public class CustomerController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
