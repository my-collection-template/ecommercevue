using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Features.Models;

namespace Features.Controllers
{
    public class HomeController : Controller
    {
        public HomeController () { }

        public IActionResult Index ()
        {
            // TODO: Your code here
            return View ();
        }
        
    }
}