using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NykaaDemoWeb.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NykaaDemoWeb.Controllers
{
    public class ProductController : Controller
    {
        NykaaDemoContext _context=new NykaaDemoContext();
        Product p;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayProductsPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayProductsPage(string PName)
        {
            p = _context.GetProductsByProductName(PName, out int status);
            ViewBag.Status = status;
            ViewBag.p = p;
            return View();
        }

        

        //[HttpGet]
        //public IActionResult DeleteProducts(string pname)
        //{
        //    var product = _context.GetProductsByProductNameDelete(pname).FirstOrDefault();
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult DeleteProducts(string pname, FormCollection collection)
        //{
        //    return View();
        //}




        //[HttpGet]
        //public IActionResult AddProducts()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddProducts()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult DeleteProducts()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteProducts()
        //{
        //    return View();
        //}


    }
}
