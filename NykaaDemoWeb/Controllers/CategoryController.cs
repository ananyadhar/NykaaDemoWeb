
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NykaaDemoWeb.Data;
using System.Linq;
 
namespace NykaaDemoWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NykaaDemoContext dbContext;
        public CategoryController(NykaaDemoContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayCategory()
        {
            //using var db = new NykaaDemoContext();

            var d = this.dbContext.Categories.Include(c => c.SubCategories).ToList();
            return View(d);

        }
        [HttpGet]
        public IActionResult DisplayProducts(int id)
        {
            var d = this.dbContext.Products.Where(c => c.ScatId == id).ToList();
            return View(d);

        }
    }
}


