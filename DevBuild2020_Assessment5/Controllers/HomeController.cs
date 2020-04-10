using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevBuild2020_Assessment5.Models;
using Microsoft.Extensions.Configuration;

namespace DevBuild2020_Assessment5.Controllers
{

    public class HomeController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public HomeController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("Party"));
        }
           

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rsvp()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
