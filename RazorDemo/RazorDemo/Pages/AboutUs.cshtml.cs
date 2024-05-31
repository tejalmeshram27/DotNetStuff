using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages
{
    public class AboutUsModel : PageModel
    {
        public string about { get; set; }
        public void OnGet()
        {
            about = "One place destination for adventure products";
        }
    }
}
