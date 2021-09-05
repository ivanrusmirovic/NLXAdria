using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NLXADRIA.Controllers
{
    [Route("[controller]")]
    public class CommuntityManagment : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "CommuntityManagment";

            return View();
        }
    }
}