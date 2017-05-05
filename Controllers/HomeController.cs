using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace temp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var assemblies = new List<string>
            {
                {typeof(object).GetTypeInfo().Assembly.Location},
                {typeof(Controller).GetTypeInfo().Assembly.Location},
                {typeof(LoggerFactory).GetTypeInfo().Assembly.Location},
                {typeof(IServiceCollection).GetTypeInfo().Assembly.Location}
            };
            ViewData["Message"] = assemblies;

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
