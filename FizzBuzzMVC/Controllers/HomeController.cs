using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzzMVC.Models;
using System.Text;

namespace FizzBuzzMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solve(string input1, string input2)
        {
            var fizzNum = Convert.ToInt32(input1);
            var buzzNum = Convert.ToInt32(input2);

            var output = new StringBuilder();

            if (fizzNum == 0 || buzzNum == 0)
            {
                return View();
            }

            for (var index = 1; index <= 100; index++)
            {
                if (index % fizzNum == 0 && index % buzzNum == 0)
                {
                    output.AppendLine("FizzBuzz");
                }
                else if (index % fizzNum == 0)
                {
                    output.AppendLine("Fizz");
                }
                else if (index % buzzNum == 0)
                {
                    output.AppendLine("Buzz");
                }
                else
                {
                    output.AppendLine(index.ToString());
                }
            }

            ViewData["Output"] = output;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
