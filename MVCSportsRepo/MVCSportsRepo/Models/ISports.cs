namespace MVCSportsRepo.Models
{
	public interface ISports
	{
		public IEnumerable<Sports> AllSports { get; }

		Sports GetSportsById(int SportsId);
	}
}
