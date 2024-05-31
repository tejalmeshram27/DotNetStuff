using Microsoft.AspNetCore.Mvc;

namespace MVCMockDemo.Controllers
{
	public class MusicController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public  IActionResult Welcome()
		{
			return View();
		}

		//public 
	}
}
