using System.Security.Cryptography.X509Certificates;
using MVCSportsRepo.Models;

namespace MVCSportsRepo.ViewModel
{
	public class SportsListViewModel
	{

		public IEnumerable<Sports> Sports { get; set; }

		public string CurrentCategory { get; set; }

		public SportsListViewModel( IEnumerable<Sports> sports, string currentCategory ) 
		{
			Sports = sports;
			CurrentCategory = currentCategory;
		}


	}
}
