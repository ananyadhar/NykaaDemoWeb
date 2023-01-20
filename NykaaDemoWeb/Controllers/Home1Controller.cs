using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NykaaDemoWeb.Data;
using NykaaDemoWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NykaaDemoWeb.Controllers
{
    public class Home1Controller : Controller
    {
        private readonly ILogger<Home1Controller> _logger;

        public Home1Controller(ILogger<Home1Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult MainHomePage()
        {
            using var db = new NykaaDemoContext();

            var d = db.Categories.Include(c => c.SubCategories).ToList();
            return View(d);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
