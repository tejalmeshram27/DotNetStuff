using Microsoft.AspNetCore.Mvc;
using MvcTemplateDemo.Models;
using Newtonsoft.Json;

namespace MvcTemplateDemo.Controllers
{
    public class TempController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer()
            {
                CName = "Riya",
                City = "Melbourne"
            };

            string strcust = JsonConvert.SerializeObject(customer);

            TempData["CustInfo"] = strcust;

            return new RedirectResult(@"\Home");

            //return View();
        }
    }
}
