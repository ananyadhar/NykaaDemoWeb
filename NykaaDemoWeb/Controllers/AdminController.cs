using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NykaaDemoWeb.Data;
using System.Linq;
using System.Security.Policy;

namespace NykaaDemoWeb.Controllers
{
    public class AdminController : Controller
    {
        NykaaDemoContext _context = new NykaaDemoContext();
        Product p;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayProductsPage()
        {
            var ProductList = _context.Products.Select(e => e).ToList();
            return View(ProductList);
        }

        [HttpPost]
        public IActionResult DisplayProductsPage(string PName)
        {
            p = _context.GetProductsByProductName(PName, out int status);
            ViewBag.Status = status;
            ViewBag.p = p;
            return View();
        }


        [HttpGet]
        public IActionResult DisplayProducts()
        {
            var ProductList = _context.Products.Select(e => e).ToList();
            return View(ProductList);
        }

        [HttpPost]
        public IActionResult DisplayProducts(string Pname)
        {
            p = _context.GetProductsByProductName(Pname, out int status);
            ViewBag.Status = status;
            ViewBag.p = p;
            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddProduct(Product ProductModelObj)
        {
            Product product = new Product();
            product.Pid = ProductModelObj.Pid;
            product.Pname = ProductModelObj.Pname;
            product.Pprice = ProductModelObj.Pprice;
            product.Pimg = ProductModelObj.Pimg;
            product.Pbrand = ProductModelObj.Pbrand;
            product.Pdescription = ProductModelObj.Pdescription;
            product.ScatId = ProductModelObj.ScatId;
           
            _context.Add(product);
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {

            var product = _context.Products.Select(e => e).ToList().Single(p => p.Pid == id);
            _context.Remove(product);
            _context.SaveChanges();
            return View();

        }

        [HttpGet]
        public IActionResult UpdateProduct()
        {
            return View();
        }
        [HttpPost]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult UpdateProduct(Product uptemp, int id)
        {
            //ProductModel uptemp = new ProductModel();
            //var ProductList = _context.productModel.Select(e => e).Where(e => e.ProductID == Id).FirstOrDefault();
            //uptemp.ProductID = ProductList.ProductID;
            //uptemp.ProductName = ProductList.ProductName;
            //uptemp.ProductPrice = ProductList.ProductPrice;
            //uptemp.UnitsInStock = ProductList.UnitsInStock;
            //uptemp.SubCategoryID = ProductList.SubCategoryID;
            //uptemp.CategoryID = ProductList.CategoryID;
            //uptemp.Image = ProductList.Image;
            //uptemp.Discount = ProductList.Discount;
            //uptemp = _context.productModel.Select(e => e).Where(e => e.ProductID == Id).FirstOrDefault();




            uptemp.Pid = id;
            _context.Update(uptemp);
            _context.SaveChanges();
            return View();



        }
    }
}
