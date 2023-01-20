using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using NykaaDemoWeb.Data;
using System.Linq;

namespace NykaaDemoWeb.Controllers
{
    public class OrdersController : Controller
    {
        private readonly NykaaDemoContext dbContext;
        public OrdersController(NykaaDemoContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CalculateBill()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CalculateBill(int id)
        {
            var d = this.dbContext.Products.Where(c => c.Pid == id).FirstOrDefault();
            var price1 = d.Pprice;
            var key1 = "BillAmount";
            if (HttpContext.Session.Keys.Any(s => s.Contains(key1)) )
            {
                price1 = (int)(HttpContext.Session.GetInt32("BillAmount") + price1);
            }
            HttpContext.Session.SetInt32("BillAmount", (int)price1);
            var key2 = "login";
            if(HttpContext.Session.Keys.Any(s => s.Contains(key2))){
                return RedirectToAction("UserHomePage", "UserPageHome");
            }
            
            

            return RedirectToAction("MainHomePage", "Home1");
        }

        public IActionResult BillAmount()
        {
            var key1 = "BillAmount";
            ViewBag.TotalBillAmount = 0;
            if (HttpContext.Session.Keys.Any(s => s.Contains(key1)))
            {
                ViewBag.TotalBillAmount = HttpContext.Session.GetInt32("BillAmount");
            }
            return View();
        }
    }
}
