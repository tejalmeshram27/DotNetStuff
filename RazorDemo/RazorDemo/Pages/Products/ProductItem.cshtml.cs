using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages.Products
{
    public class ProductItemModel : PageModel
    {
        public List<ProductItem> ProductList { get; set; }

        public void OnGet()
        {
            var jscontent = System.IO.File.ReadAllText("wwwroot/sampledata/products.json");

            ProductList = JsonSerializer.Deserialize<List<ProductItem>>(jscontent)
        }
    }
}
