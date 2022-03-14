using System.ComponentModel.DataAnnotations;

namespace HyperMarket.ViewModels
{
    public class ListBusinessModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(30, ErrorMessage = "Businessname must be atleast 8 characters long.", MinimumLength = 8)]
        public string Businessname { get; set; }
        public string BusinessDescription { get; set; }

        public string location { get; set; }
        public string imageurl { get; set; }
    }
}
