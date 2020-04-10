using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBuild2020_Assessment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DevBuild2020_Assessment5.Controllers
{
    public class RsvpController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public RsvpController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("Party"));
        }

        public IActionResult Index()
        {
            return View("RsvpIndex");
        }

        [HttpPost]
        public IActionResult Add(RsvpForm prod)
        {
            //check the model for validity

            int result = dal.CreateProduct(prod);

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully added";
            }
            else
            {
                TempData["UserMsg"] = "Item not added";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return View("RSVP", prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Rsvp(RsvpForm form)
        {
            
            if (ModelState.IsValid)
            {
                if (form.Attending.Equals("no"))
                {

                    return View("Farewell");
                }
                return View(form);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("RsvpIndex", form);
            }
        }
    }
}