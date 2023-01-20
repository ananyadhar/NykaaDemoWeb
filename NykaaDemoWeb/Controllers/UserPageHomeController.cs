using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NykaaDemoWeb.Data;
using System.Linq;

namespace NykaaDemoWeb.Controllers
{
    public class UserPageHomeController : Controller
    {
        //User Home Page
        //[HttpGet]
        //[Route("/")]
        public IActionResult UserHomePage()
        {
            //if (!TempData["UserName"].Equals(""))
            //{
            //    ViewBag.Username = TempData["UserName"];
            //}

            //ViewBag.Username = TempData["UserName"];

            using var db = new NykaaDemoContext();

            var d = db.Categories.Include(c => c.SubCategories).ToList();
            return View(d);
            
        }

        //Admin Home Page
        public IActionResult AdminHomePage()
        {
            return View();
        }

        //Categories 

    }
}
