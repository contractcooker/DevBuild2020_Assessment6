using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevBuild2020_Assessment5.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
            return View("DishIndex");
        }
    }
}