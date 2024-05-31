using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorLab.Pages
{
    public class SportcshtmlModel : PageModel
    {
        public string sport { get; set; }

        public List<string> cardDesc = new List<string>();

        public List<string> cardTitle = new List<string>();

        public void OnGet()
        {
            cardTitle.Add("Cricket");

            cardTitle.Add("Football");

            cardTitle.Add("Volleyball");

            cardTitle.Add("Hockey");


            cardDesc.Add("Lorem ipsum, dolor sit amet consectetur adipisicing elit. Optio cupiditate nulla quod exercitationem explicabo officiis perspiciatis sed ratione nam sapiente molestiae facere dolorem laudantium consequuntur, obcaecati et tempore, saepe aspernatur.\r\n");

            cardDesc.Add("Lorem ipsum dolor sit, amet consectetur adipisicing elit. Dignissimos recusandae, praesentium possimus, quod sit deleniti earum quasi velit dolorem ea cum provident ipsam amet autem veniam? Est minima dolor optio.\r\n");

            cardDesc.Add("Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit, nisi.\r\n");

            cardDesc.Add("Lorem, ipsum dolor sit amet consectetur adipisicing elit. Deleniti adipisci unde voluptatibus architecto maiores. Quia.\r\n");


            sport = "Sports Tab: Explore the Thrills and Triumphs of Your Favorite Games";
        }
    }
}
