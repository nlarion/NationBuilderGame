using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NationBuilderGame.Models;
using Microsoft.AspNet.Mvc;

namespace NationBuilderGame.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }
    }
}
