namespace MVCSportsRepo.Models
{
	public class MockCategoryRepo : ICategory
	{
		public IEnumerable<Catergory> GetAllCategories => new List<Catergory>
		{
			new Catergory
			{
				catergoryId = 1,
				categoryName = "High",
				description = "Popularity is High"

			},
			new Catergory
			{
				catergoryId = 2,
				categoryName = "Medium",
				description = "Popularity is Medium"

			},
			new Catergory
			{
				catergoryId = 3,
				categoryName = "Low",
				description = "Popularity is Low"

			}
		};
	}
}
