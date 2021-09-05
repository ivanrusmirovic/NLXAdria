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
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Services";
            return View();
        }
    }
}