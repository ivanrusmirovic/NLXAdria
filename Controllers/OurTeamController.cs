using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLXADRIA.Models;


namespace NLXADRIA.Controllers
{
    public class OurTeamController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "OurTeam";
            return View();
        }

    }
}