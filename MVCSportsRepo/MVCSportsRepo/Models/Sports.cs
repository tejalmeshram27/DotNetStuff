namespace MVCSportsRepo.Models
{
	public class Sports
	{

		public int SportsId { get; set; }
		public string name { get; set; }

		public int playersReq { get; set; }

		public string sportsType { get; set; }

		public int categoryId { get; set; }

		public Catergory catergory { get; set; }
	}
}
