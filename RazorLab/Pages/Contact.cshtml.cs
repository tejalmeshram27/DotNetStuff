using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorLab.Pages
{
    public class ContactModel : PageModel
    {
        public string contact { get; set; }

        public void OnGet()
        {
            contact = "We're here to listen, answer your questions, and assist you in any way we can. Your feedback and inquiries are valuable to us. Here's how you can get in touch:\r\n\r\nCustomer Support:\r\n\r\nIf you have any issues, concerns, or questions related to our website, content, or services, our customer support team is ready to assist you. We strive to provide timely and helpful responses to ensure your experience with us is smooth and enjoyable.\r\n\r\nEmail: customer.support@sportswebsitename.com\r\n\r\nPhone: [Your Contact Number Here]\r\n\r\nSocial Media:\r\n\r\nConnect with us on social media for the latest updates, engaging discussions, and a chance to interact with our community of sports enthusiasts.\r\n\r\nTwitter\r\nFacebook\r\nInstagram\r\nEditorial Team:\r\n\r\nHave a suggestion for a story, a topic you'd like us to cover, or a collaboration opportunity? Our editorial team is eager to hear your ideas and work together to bring compelling content to our readers.\r\n\r\nEmail: editorial@sportswebsitename.com\r\n\r\nAdvertising and Partnerships:\r\n\r\nIf you're interested in advertising on our platform or exploring potential partnerships, we'd love to discuss how we can work together to reach our shared goals.\r\n\r\nEmail: partnerships@sportswebsitename.com\r\n\r\nGeneral Inquiries:\r\n\r\nFor any other inquiries, comments, or just to say hello, feel free to use our general contact information.\r\n\r\nEmail: info@sportswebsitename.com\r\n\r\nMailing Address:\r\n\r\n[Your Company Name]\r\n[Street Address]\r\n[City, State, Zip Code]\r\n[Country]\r\n\r\nFeedback Form:\r\n\r\nIf you prefer, you can also use our online feedback form to submit your comments, suggestions, or questions directly through our website. Visit the \"Contact Us\" section on our website to access the form.\r\n\r\nWe value your input and strive to provide a prompt and courteous response. Thank you for choosing [Sports Website Name] as your source for all things sports-related. Your engagement enriches our community, and we look forward to connecting with you!";
        }
    }
}
