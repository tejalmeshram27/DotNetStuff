namespace MVCMockDemo.Models
{
    public class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category
            {
                CategoryId = 1,
                CategoryName = "Comedy",
                Description = "Comedy Movie",
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "RomCom",
                Description = "RomCom Movie",
            },
            new Category
            {
                CategoryId = 1,
                CategoryName = "Motivational",
                Description = "Motqivational Movie",
            }
        };
    }
}
