using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorLab.Pages
{
    public class AboutModel : PageModel
    {
        public string about { get; set; }

        public void OnGet()
        {
            about = "We believe that sports are more than just games – they are a source of inspiration, unity, and unbridled passion. Our mission is to capture the essence of these values and share them with the world through our platform.\r\n\r\nOur Vision\r\n\r\nWe envision a world where sports transcend boundaries, bringing people together and igniting a sense of camaraderie that bridges cultures, languages, and backgrounds. Through our website, we aim to foster a global community that celebrates the beauty of competition and the indomitable spirit of athletes.\r\n\r\nWho We Are\r\n\r\nWe are a dedicated team of sports enthusiasts, writers, analysts, and creatives, united by our unwavering love for all things sports. Our diverse backgrounds and experiences contribute to the rich tapestry of perspectives that define our content. From the heart-pounding moments on the field to the strategic decisions made behind the scenes, we're committed to delivering insightful, engaging, and authentic content.\r\n\r\nOur Commitment\r\n\r\nAccuracy and Integrity: We take our role as purveyors of sports information seriously. Our commitment to accuracy ensures that every piece of news, analysis, and feature we present is thoroughly researched and verified.\r\n\r\nPassion for the Game: Our passion for sports drives us to go beyond the surface and delve into the heart of the action. We bring you stories that capture the dedication, sacrifices, and triumphs that define the world of sports.\r\n\r\nInclusivity: Sports know no boundaries, and neither do we. We embrace diversity in sports and aim to cover a wide range of sports from across the globe. Our platform is a space for everyone, regardless of their background, to come together and celebrate their shared love for sports.\r\n\r\nEngaging Community: We believe that the true essence of sports is best experienced when shared. Our platform fosters a community of fans who can interact, share opinions, and engage in meaningful discussions. We provide a safe and respectful space for every voice to be heard.\r\n\r\nJoin Us in Celebrating Sports\r\n\r\nWhether you're a seasoned sports fanatic or a newcomer curious about the magic of the game, [Sports Website Name] welcomes you. We invite you to explore our diverse content, share your thoughts, and embark on a journey that celebrates the highs, the lows, and the sheer excitement that make sports an integral part of our lives.\r\n\r\nThank you for being a part of our community. Together, let's celebrate the spirit of sports in all its glory!";
        }
    }
}
