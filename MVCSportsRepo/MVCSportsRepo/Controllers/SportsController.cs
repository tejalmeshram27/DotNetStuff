using Microsoft.AspNetCore.Mvc;
using MVCSportsRepo.Models;
using MVCSportsRepo.ViewModel;

namespace MVCSportsRepo.Controllers
{
	public class SportsController : Controller
	{

		//DI
		private ISports _sportsRepo;
		private ICategory _categoryRepo;

		public SportsController (ISports sportsRepo, ICategory categoryRepo)
		{
			_sportsRepo = sportsRepo;
			_categoryRepo = categoryRepo;
		}

		//[Route("Sports/Index/{id}")]
		public IActionResult Index(int Id, string query)
		{
			IEnumerable<Sports> sports;

			//if (query == string.Empty && (Id == 1 || Id == 2 || Id == 3) )
			if ( Id == 1 || Id == 2 || Id == 3)
			{
				//if (Id == 1 || Id == 2 || Id == 3)
				//{
					sports = _sportsRepo.AllSports.Where(s => s.categoryId == Id).OrderBy(n => n.name);
				//}


				//else
				//{
				//	sports = _sportsRepo.AllSports.OrderBy(n => n.name);
				//}
			}

			else if (query != string.Empty)
			{
				sports = _sportsRepo.AllSports.Where(s=>s.name==query).OrderBy(n => n.name);
			}

			else
			{
				sports = _sportsRepo.AllSports.OrderBy(n => n.name);
			}

			SportsListViewModel sportsListViewModel = new SportsListViewModel
				(_sportsRepo.AllSports, "High Popularity");





			//string currentCategory;

			//sports = _sportsRepo.AllSports.OrderBy(m => m.SportsId);
			//currentCategory = "All Sports";

			return View(sportsListViewModel);
		}
	}
}
