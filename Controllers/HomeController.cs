using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PostgresSampleApp.Controllers
{
    public class HomeController : Controller
    {
        static int _count;
        
        public IActionResult Incr()
        {
            _count++;
            return Content("Done!");
        }
        
        public IActionResult Show()
        {
            return Content(_count.ToString());
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
