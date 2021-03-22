using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StringConcatWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatWebApp.Controllers
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

        public IActionResult Results(string word, int repetitions)
        {
            // What are you actually appending?

            var sb = new StringBuilder();
            for (int i = 0; i <= repetitions; i++)
            {
                sb.AppendLine(word.ToString());
            }

            // store that information in a viewdata
            //Console.WriteLine(sb.ToString());
            ViewData["Message"] = word;
            ViewData["NumTimes"] = repetitions;
            ViewData["Results"] = sb;

            // create the view
            // display the information on the view
            // create a link that directs to the index view
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
