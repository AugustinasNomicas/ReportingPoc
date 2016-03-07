using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Visma.ReportingPoc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InteractiveReport()
        {
            return View();
        }

        public IActionResult LargeReport()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
