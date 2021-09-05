using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NLXADRIA.Controllers
{
    public class ProjectManagementController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "ProjectManagement";
            return View();
        }
    }
}