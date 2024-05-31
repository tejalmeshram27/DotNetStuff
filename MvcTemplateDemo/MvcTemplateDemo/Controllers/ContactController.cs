using Microsoft.AspNetCore.Mvc;

namespace MvcTemplateDemo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
