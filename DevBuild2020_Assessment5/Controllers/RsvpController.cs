using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBuild2020_Assessment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevBuild2020_Assessment5.Controllers
{
    public class RsvpController : Controller
    {
        public IActionResult Index()
        {
            return View("RsvpIndex");
        }

        public IActionResult Rsvp(RsvpForm form)
        {
            return View(form);
        }
    }
}