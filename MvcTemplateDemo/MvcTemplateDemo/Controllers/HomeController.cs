using System.Diagnostics;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MvcTemplateDemo.Models;

namespace MvcTemplateDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //actions
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "From the View Bag";

            ViewData["MovieInfo"] = "Hollywood Movie"; 

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [NonAction]
        public int add()
        {
            return 4 + 4;
        }

        public JsonResult jsondata()
        {
            string result = "Json action";
            return Json(result);
        }

        public string Welcome(string custname, int id)
        {
            return HttpUtility.HtmlEncode("Welcome! " + custname + ":" +  id);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}