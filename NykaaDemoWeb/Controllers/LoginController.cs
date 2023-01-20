
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NykaaDemoWeb.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NykaaDemoWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        string _username;
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Index()
        {
            LoginModel _logModel = new LoginModel();
            return View(_logModel);
        }

        [HttpPost]
        public IActionResult Index(LoginModel _logModel)
        {
            NykaaDemoContext _nykademoContext = new NykaaDemoContext();
            var status = _nykademoContext.Users.Where(m => m.UserName == _logModel.UserName && m.PassWrd == _logModel.Password).FirstOrDefault();
            if (status == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                if (status.UserType == "User")
                {
                    ViewBag.Username = status.UserName;
                    //TempData["UserName"] = status.UserName;
                    HttpContext.Session.SetInt32("login", 10);
                    return RedirectToAction("UserHomePage", "UserPageHome");
                }
                else
                {
                    return RedirectToAction("DisplayProductsPage", "Admin");
                }
            }

            return View(_logModel);
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("MainHomePage", "Home1");
        }

    }
}
