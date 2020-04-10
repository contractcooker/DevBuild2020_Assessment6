using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBuild2020_Assessment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DevBuild2020_Assessment5.Controllers
{
    public class DishController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public DishController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("Party"));
        }
        public IActionResult Index()
        {
            return View("DishIndex");
        }

        [HttpPost]
        public IActionResult Add(DishForm prod)
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
            return View("Dish", prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Dish(DishForm form)
        {
            if (ModelState.IsValid)
            {
                return View(form);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("DishIndex", form);
            }
        }

        public IActionResult DishList()
        {
            ViewData["Dishes"] = dal.GetAllDishes();
            return View();
        }
    }
}